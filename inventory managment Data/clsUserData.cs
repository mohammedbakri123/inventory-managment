using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
