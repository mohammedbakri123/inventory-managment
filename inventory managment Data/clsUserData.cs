using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventory_managment_Data
{
    public class clsUserData
    {
        public static int AddNew(string UserName , string Password , int role , int PersonID)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"INSERT INTO [dbo].[Users]
                               ([UserName]
                               ,[Password]
                               ,[role]
                               ,[personID])
                         VALUES
                               (@UserName
                               ,@Passwoed
                               ,@role
                               ,@PersonID;SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@PersonID" , PersonID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                UserID = -1;
            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool GetByUserID(int UserID , ref string UserName, ref string password , ref int role , ref int personID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection (DataAccessSettings.ConnectionString);

            string quary = @"select * from Users where UserID = @UserID ";

            SqlCommand command = new SqlCommand( quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    role = (int)reader["role"];
                    personID = (int)reader["personID"];
                }
                reader.Close();
            }
            catch {
                
                isFound = false; 
            
            }
            finally {
                
                connection.Close();
            }
            return isFound;
        }
       
        public static bool GetByUserNameAndPassword(ref int UserID,  string UserName,  string password, ref int role, ref int personID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"select * from Users where UserName = @UserName and Password = @Password ";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    role = (int)reader["role"];
                    personID = (int)reader["personID"];
                }
                reader.Close();
            }
            catch
            {

                isFound = false;

            }
            finally
            {

                connection.Close();
            }
            return isFound;
        }
    
        public static bool isUserExistByID(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"select isFound=1 from Users where UserID = @UserID ";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch
            {

                isFound = false;

            }
            finally
            {

                connection.Close();
            }
            return isFound;

        }

        public static bool isUserExistByUserNameAndPassword(string UserName, string password)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"select * from Users where UserName = @UserName and Password = @Password ";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch
            {

                isFound = false;

            }
            finally
            {

                connection.Close();
            }
            return isFound;

        }

        public static bool Update(int UserID,string UserName, string Password, int role, int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[Users]
                               SET [UserName] = @UserName
                                  ,[Password] = @Password
                                  ,[role] = @role
                                  ,[personID] = @PersonID
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand( quary, connection);

            command.Parameters.AddWithValue("@UserName" , UserName);
            command.Parameters.AddWithValue ("@Password" , Password);
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@PersonID" , PersonID);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;

        }

        public static bool Delete(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"Delete from Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(quary, connection);

        
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable result = new DataTable();

            SqlConnection connection = new SqlConnection (DataAccessSettings.ConnectionString);

            string quary = @"SELECT 
                                u.UserID AS 'معرف المستخدم',
                                u.UserName AS 'اسم المستخدم',
                                CONCAT(COALESCE(p.FirstName, ''), ' ', 
                                       COALESCE(p.SecondName, ''), ' ', 
                                       COALESCE(p.ThirdName, ''), ' ', 
                                       COALESCE(p.LastName, '')) AS 'الاسم',
                                COALESCE(p.Phone, 'غير متوفر') AS 'رقم الهاتف',
                                CASE 
                                    WHEN u.role = 1 THEN 'مدير النظام'
                                    WHEN u.role = 2 THEN 'مسؤول المخزون'
                                    WHEN u.role = 3 THEN 'أمين الصندوق'
                                    ELSE 'غير محدد'
                                END AS 'الدور الوظيفي'
                            FROM Users u
                            JOIN people p ON u.personID = p.personID;";
            SqlCommand command = new SqlCommand( quary, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    result.Load(reader);
                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close ();
            }

            return result;
        }
    }
}
