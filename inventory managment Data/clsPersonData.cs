using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace inventory_managment_Data
{
    public class clsPersonData
    {
        public static int AddPerson(string firstName, string secondName, string thirdName, string lastName, string phone, string email, string imageLocation, string address)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"INSERT INTO [dbo].[people]
           ([FisrtName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[Phone]
           ,[Email]
           ,[imageLocation]
           ,[Address])
     VALUES
           (@FirstName
           ,@secondName
           ,@ThirdName
           ,@lastName
           ,@phone
           ,@Email
           ,@Imagepath
           ,@Address); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@phone", phone);

            if (email != "" && email != null)
                command.Parameters.AddWithValue("@Email", email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (imageLocation != null && imageLocation != "")
                command.Parameters.AddWithValue("@Imagepath", imageLocation);
            else
                command.Parameters.AddWithValue("@Imagepath", System.DBNull.Value);

            command.Parameters.AddWithValue("@Address", address);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return PersonID;

        }

        public static bool GetByID(int personID, ref string firstName, ref string secondName
            , ref string thirdName, ref string LastName, ref string phone
            , ref string email, ref string imagePath, ref string Address)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = "Select * from people where personID = @personID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    firstName = (string)reader["FisrtName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["lastName"];
                    phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    if (reader["Email"] != DBNull.Value)
                        email = (string)reader["Email"];
                    else
                        email = "";

                    if (reader["imageLocation"] != DBNull.Value)
                        imagePath = (string)reader["imageLocation"];
                    else
                        imagePath = "";


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }
        public static bool isExistByID(int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = "Select Found=1 from people where personID = @personID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool UpdatePersonByID(int personID, string firstName, string secondName, string thirdName
            , string lastName, string phone,
            string email, string imageLocation, string address)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"UPDATE [dbo].[people]
                           SET [FisrtName] = @firstName
                              ,[SecondName] = @secondName
                              ,[ThirdName] = @thirdName
                              ,[LastName] = @lastName
	                          ,[Phone] = @phone
                              ,[Email] = @email
                              ,[imageLocation] = @imagelocation
                              ,[Address] = @address
                         WHERE personID = @personID";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@personID", personID);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@phone", phone);
            if(email != null && email != "" )
                command.Parameters.AddWithValue("@email", email);
            else
                command.Parameters.AddWithValue("@email", DBNull.Value);
            if (imageLocation != null && imageLocation != "")
                command.Parameters.AddWithValue("@imagelocation", imageLocation);
            else
                command.Parameters.AddWithValue("@imagelocation", DBNull.Value);

            command.Parameters.AddWithValue("@address", address);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally 
            { 
                connection.Close(); 
            }

            return rowsAffected>0;
        }

        public static bool DeletePersonByID(int personID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"DELETE FROM [dbo].[people] WHERE personID = @personID ";
            
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch { rowsAffected = 0; }
            finally { connection.Close(); }
            return rowsAffected > 0;

        }
    }
}
