using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsProductData
    {
        public static bool GetByID(int ID,ref string name, ref string description, ref int catagoryID, ref string supplier, ref string GTIN, ref string imagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"SELECT 
                          [productName]
                          ,[productinfo]
                          ,[catagoryID]
                          ,[Supplier]
                          ,[GTIN]
                          ,[ImagePath]
                      FROM [dbo].[Products] where [productID] = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    name = (string)reader["productName"];
                    description = (string)reader["productinfo"];
                    catagoryID = (int)reader["catagoryID"];
                    supplier = (string)reader["Supplier"];
                    GTIN = (string)reader["GTIN"];
                    if (reader["ImagePath"] != System.DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";
                    reader.Close();
                }
            }
            catch
            {
                isFound=false;
            }
            finally { connection.Close(); }
         
            return isFound;
        }

        public static bool GetByName(ref int ID,  string name, ref string description, ref int catagoryID, ref string supplier, ref string GTIN, ref string imagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"SELECT 
                           [productID]
                          
                          ,[productinfo]
                          ,[catagoryID]
                          ,[Supplier]
                          ,[GTIN]
                          ,[ImagePath]
                      FROM [dbo].[Products] where [productName] = @name";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@name", name);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["productID"];
                    description = (string)reader["productinfo"];
                    catagoryID = (int)reader["catagoryID"];
                    supplier = (string)reader["Supplier"];
                    GTIN = (string)reader["GTIN"];
                    if (reader["ImagePath"] != System.DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";
                    reader.Close();
                }
            }
            catch
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetByGTIN(ref int ID, ref string name, ref string description, ref int catagoryID, ref string supplier,  string GTIN, ref string imagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"SELECT 
                           [productID]
                          
                          ,[productinfo]
                          ,[catagoryID]
                          ,[Supplier]
                          ,[productName]
                          ,[ImagePath]
                      FROM [dbo].[Products] where [GTIN] = @GTIN";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@GTIN", GTIN);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["productID"];
                    description = (string)reader["productinfo"];
                    catagoryID = (int)reader["catagoryID"];
                    supplier = (string)reader["Supplier"];
                    name = (string)reader["productName"];
                    if (reader["ImagePath"] != System.DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";
                    reader.Close();
                }
            }
            catch
            {
                isFound = false;
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static int Add(string name, string description, int catagoryID, string supplier, string GTIN, string imagePath)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"INSERT INTO [dbo].[Products]
                           (
                           [productName]
                           ,[productinfo]
                           ,[catagoryID]
                           ,[Supplier]
                           ,[GTIN]
                           ,[ImagePath])
                     VALUES
                           (
                           @name
                           ,@description
                           ,@catagoryID
                           ,@supplier
                           ,@GTIN
                           ,@imagePath);SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@catagoryID", catagoryID);
            command.Parameters.AddWithValue("@supplier", supplier);
            command.Parameters.AddWithValue("@GTIN", GTIN);
            if(imagePath != "" && imagePath != null)
                command.Parameters.AddWithValue("@imagePath", imagePath);
            else
                command.Parameters.AddWithValue("@imagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }

            }
            catch (Exception ex)
            {
                ID = -1;
            }
            finally
            {
                connection.Close();
            }



            return ID;
        }

        public static bool Update( int ID, string name, string description, int catagoryID, string supplier, string GTIN, string imagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string quary = @"UPDATE [dbo].[Products]
                           SET 
                              [productName] = @name
                              ,[productinfo] = @description
                              ,[catagoryID] = @catagoryID
                              ,[Supplier] = @supplier
                              ,[GTIN] = @GTIN
                              ,[ImagePath] = @imagePath
                         WHERE [productID] = @ID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@name", name);

            command.Parameters.AddWithValue("@description", description);

            command.Parameters.AddWithValue("@catagoryID", catagoryID);

            command.Parameters.AddWithValue("@supplier", supplier);

            command.Parameters.AddWithValue("@GTIN", GTIN);

            if(imagePath != "" && imagePath != null)
                command.Parameters.AddWithValue("@imagePath", imagePath);
            else
            
                command.Parameters.AddWithValue("@imagePath", System.DBNull.Value);

            

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch {
                rowsAffected = 0;

            }
            finally { 
            connection.Close() ;
            }
            return rowsAffected > 0;
        }

        public static bool Delete(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"DELETE FROM [dbo].[Products]
                                WHERE [productID] = @ID";

            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@ID" , ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch {
                rowsAffected = 0;
            }
            finally { connection.Close() ; }

            return rowsAffected > 0;
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string quary = @"SELECT 
                    p.productID AS 'معرف المنتج',
                    p.productName AS 'اسم المنتج',
                    p.productInfo AS 'وصف المنتج',
                    c.CatagoryName 'التصنيف',
                    p.supplier AS 'المورد',
                    p.GTIN AS 'الرقم العالمي'
                FROM Products p
                LEFT JOIN Catagoryies c ON p.catagoryID = c.CatagoryID;
                ";

            SqlCommand command = new SqlCommand(quary,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                    reader.Close();
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetProductMovement(int ID)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
