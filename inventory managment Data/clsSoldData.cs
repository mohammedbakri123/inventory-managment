using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsSoldData
    {
        public static int Add(int stockID, int billID, int quantity, SqlMoney pricePerOne, SqlMoney totalPrice)
        {
            int ID = -1;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"INSERT INTO [dbo].[Solds]
                                       ([stockID]
                                       ,[BillID]
                                       ,[quntity]
                                       ,[PeicePerOne]
                                       ,[TotalPrice])
                                 VALUES
                                       (@stockID
                                       ,@billID
                                       ,@quantity
                                       ,@pricePerOne
                                       ,@totalPrice);SELECT SCOPE_IDENTITY();";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@stockID", stockID);
                        command.Parameters.AddWithValue("@billID", billID);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);
                        command.Parameters.AddWithValue("@pricePerOne", pricePerOne);


                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ID = insertedID;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ID = -1;
            }
            return ID;
            
        }

        public static bool Update(int ID,int stockID, int billID, int quantity, SqlMoney pricePerOne, SqlMoney totalPrice)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"UPDATE [dbo].[Solds]
                                       SET [stockID] = @stockID
                                          ,[BillID] = @billID
                                          ,[quntity] = @quantity
                                          ,[PeicePerOne] = @pricePerOne
                                          ,[TotalPrice] = @totalPrice
                                     WHERE soldID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@stockID", stockID);
                        command.Parameters.AddWithValue("@billID", billID);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);
                        command.Parameters.AddWithValue("@pricePerOne", pricePerOne);
                        command.Parameters.AddWithValue("@ID", ID);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }

            return rowsAffected > 0;
        }

        public static bool Delete(int ID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"delete from Solds where soldID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }

            return rowsAffected > 0;
        }

        public static bool find(int ID,ref int stockID,ref int billID,ref int quantity,ref SqlMoney pricePerOne,ref SqlMoney totalPrice)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select * from Solds where soldID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                             
                                isFound = true;
                                stockID = (int)reader["ClientID"];
                                billID = (int)reader["BillID"];
                                quantity = (int)reader["quntity"];
                                totalPrice = new SqlMoney((decimal)reader["TotalPrice"]);
                                pricePerOne = new SqlMoney((decimal)reader["PeicePerOne"]);





                            }
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            return isFound;
        }

        public static DataTable GetAll(int ID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                        s.soldID as 'معرف البيع',
                                        p.GTIN as 'الرقم العالمي للمنتج',
                                        p.productName as 'اسم النتج',
                                        s.quntity as 'الكمية المباعة',
                                        s.PeicePerOne as 'سعر الحبة',
                                        s.TotalPrice as 'السعر الاجمالي'
                                        from solds s
                                        join stock st on st.StockID = s.stockID
                                        join Products p on st.productID = p.productID
                                        join Bills b on b.BillID = s.BillID
	                                    where s.BillID = @ID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue ("@ID", ID); 
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }



                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }


    }
}
