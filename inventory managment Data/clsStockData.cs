using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsStockData
    {
        public static int Add(int ProductID, int EntranceQuantity, int CurrentQuantity, DateTime EntranceDate, DateTime ExpireDate, SqlMoney CostPrice , SqlMoney Sellprice, string position,bool isDone)
        
        {
            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"INSERT INTO [dbo].[stock]
                                    ([productID]
                                    ,[Entrancequantity]
                                    ,[currentquantity]
                                    ,[EntranceDate]
                                    ,[expireData]
                                    ,[Position]
                                    ,[CostPrice]
                                    ,[sellPrice]
                                    ,[isDone])
                                VALUES
                                    (@ProductID
                                    ,@EntranceQuantity
                                    ,@CurrentQuantity
                                    ,@EntranceDate
                                    ,@ExpireDate
                                    ,@position
                                    ,@CostPrice
                                    ,@Sellprice
                                    ,@isDone);SELECT SCOPE_IDENTITY();";
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(quary,connection)) 
                    {

                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@EntranceQuantity", EntranceQuantity);
                        command.Parameters.AddWithValue("@CurrentQuantity", CurrentQuantity);
                        command.Parameters.AddWithValue("@EntranceDate", EntranceDate);
                        command.Parameters.AddWithValue("@ExpireDate", ExpireDate);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@CostPrice", CostPrice);
                        command.Parameters.AddWithValue("@Sellprice", Sellprice);
                        command.Parameters.AddWithValue("@isDone", isDone);

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

        public static bool GetByID(int ID,ref int ProductID, ref int EntranceQuantity, ref int CurrentQuantity, ref DateTime EntranceDate, ref DateTime ExpireDate, ref SqlMoney CostPrice, ref SqlMoney Sellprice, ref string position, ref bool isDone)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select * from stock where stockID = @ID;";
                    using(SqlCommand command = new SqlCommand(quary,connection)) 
                    {
                        command.Parameters.AddWithValue("@ID",ID);
                            connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ProductID = (int)reader["productID"];
                                EntranceQuantity = (int)reader["Entrancequantity"];
                                CurrentQuantity = (int)reader["currentquantity"];
                                EntranceDate = (DateTime)reader["EntranceDate"];
                                ExpireDate = (DateTime)reader["expireData"];
                                position = (string)reader["Position"];
                                CostPrice = new SqlMoney ((Decimal)reader["CostPrice"]);
                                Sellprice = new SqlMoney((Decimal)reader["sellPrice"]);
                                isDone = (bool)reader["isDone"];


                            }
                        }
                    }
                }
            }
            catch
            {
                isFound = false;
            }
                    return isFound;
        }

        public static bool Update(int ID,int ProductID, int EntranceQuantity, int CurrentQuantity, DateTime EntranceDate, DateTime ExpireDate, SqlMoney CostPrice, SqlMoney Sellprice, string position,bool isDone)
        {
            int RowsAffected = 0;
            try {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"UPDATE [dbo].[stock]
                                       SET [productID] = @ProductID
                                          ,[Entrancequantity] = @EntranceQuantity
                                          ,[currentquantity] = @CurrentQuantity
                                          ,[EntranceDate] = @EntranceDate
                                          ,[expireData] = @ExpireDate
                                          ,[Position] = @position
                                          ,[CostPrice] = @CostPrice
                                          ,[sellPrice] = @Sellprice
                                          ,[isDone] = @isDone
                                     WHERE stockID = @ID;";
                        connection.Open();
                    using(SqlCommand command = new SqlCommand(quary,connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@EntranceQuantity", EntranceQuantity);
                        command.Parameters.AddWithValue("@CurrentQuantity", CurrentQuantity);
                        command.Parameters.AddWithValue("@EntranceDate", EntranceDate);
                        command.Parameters.AddWithValue("@ExpireDate", ExpireDate);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@CostPrice", CostPrice);
                        command.Parameters.AddWithValue("@Sellprice", Sellprice);
                       
                        command.Parameters.AddWithValue("@isDone", isDone);

                        RowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch
            {
                RowsAffected = 0;
            }
            return RowsAffected > 0;
        }

        public static bool delete(int ID)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"delete from stock where StockID = @ID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);

                        RowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch
            {
                RowsAffected = 0;
            }
            return RowsAffected > 0;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {

                    string quary = @"select 
                                    s.StockID as 'معرف الكمية',
                                    p.productName as 'المنتج',
                                    p.GTIN as 'الرقم العالمي',
                                    s.EntranceDate as 'تاريخ دخول المخزن',
                                    s.expireData as 'تاريخ الانتهاء',
                                    s.Entrancequantity as 'عدد الكمية عند دخولها',
                                    s.currentquantity as 'العدد الحالي للكمية',
                                    s.CostPrice as 'سعر الشراء للحبة',
                                    s.sellPrice as 'سعر البيع للحبة',
                                    s.Position as 'موقع الكمية',
                                    
                                    s.isDone as 'تم نفاذ الكمية'
                                    from stock s 
                                    join Products p on  p.productID = s.productID;";
                    using (SqlCommand command = new SqlCommand(quary , connection))
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                table.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return table;
        }

        public static DataTable GetAllShortened()
        {
            DataTable table = new DataTable();
            string quary = @"WITH StockRanked AS (
                                SELECT 
                                    s.StockID,
                                    p.productName,
                                    p.GTIN,
                                    s.sellPrice,
                                    ROW_NUMBER() OVER (
                                        PARTITION BY s.productID 
                                        ORDER BY s.EntranceDate
                                    ) AS rownum
                                FROM stock s
                                JOIN Products p ON s.productID = p.productID
                                WHERE s.isDone = 0
                            )
                            SELECT 
                                StockID AS 'معرف المخزون',
                                productName AS 'اسم المنتج',
                                GTIN AS 'الرقم العالمي',
                                sellPrice AS 'سعر البيع'
                            FROM StockRanked
                            WHERE rownum = 1;";
            try
            {
                using (SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using( SqlCommand command = new SqlCommand( quary , connection))
                    {
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                table.Load(reader);
                            }
                        }
                    }

                }
            }
            catch
            {

            }

            return table;
        }



        
    }
}
