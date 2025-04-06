using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsCatagoryData
    {
        public static bool GetByID(int ID , ref string Name)
        {
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"SELECT *
                              FROM [dbo].[Catagoryies]
                              where CatagoryID  = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Name = (string)reader["CatagoryName"];
                    isFound = true;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetByName(string Name , ref int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"SELECT *
                              FROM [dbo].[Catagoryies]
                              where CatagoryName  = @Name";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["CatagoryID"];
                    isFound = true;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"SELECT *  FROM [dbo].[Catagoryies] order by CatagoryID;";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return dt;
        }

        public static int Add(string Name)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Quary = @"INSERT INTO [dbo].[Catagoryies]
                           ([CatagoryName])
                     VALUES
                           (@Name);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Quary, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }

        public static bool Delete(int ID) 
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"DELETE FROM [dbo].[Catagoryies]
                             WHERE CatagoryID = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch {
                RowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return RowsAffected > 0;
        }

        public static bool Update(int ID, string Name)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"UPDATE [dbo].[Catagoryies]
                           SET [CatagoryName] = @Name
                         WHERE CatagoryID = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                RowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return RowsAffected > 0;
        }
    }
}
