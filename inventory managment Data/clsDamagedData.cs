using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsDamagedData
    {
        public static int Add(int StockID, string Resons, DateTime date, int Quantity)
        {
            int ID = -1;
            try { 
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"INSERT INTO [dbo].[Damageds]
                                   ([StockID]
                                   ,[DamageResons]
                                   ,[DamageDate]
                                   ,[quntityDamaged])
                             VALUES
                                   (
                                   @StockID
                                   ,@Resons
                                   ,@date
                                   ,@Quantity);SELECT SCOPE_IDENTITY();";
                    connection.Open();
                    using(SqlCommand command =  new SqlCommand(quary,connection))
                    {
                        command.Parameters.AddWithValue("@StockID", StockID);
                        command.Parameters.AddWithValue("@Resons", Resons);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@Quantity", Quantity);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ID = insertedID;
                        }

                    }
                }
            }
            catch
            {
                ID = -1;
            }

            return ID;

        }

        public static bool find(int ID,ref int StockID, ref string Resons, ref DateTime date, ref int Quantity)
        {
            bool isFound = false;
            try
            {
                using( SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select * from Damageds where DamagedID = @ID";
                    connection.Open();
                    using(SqlCommand command = new SqlCommand( quary,connection))
                    {
                        command.Parameters.AddWithValue("@ID",ID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                                StockID = (int)reader["StockID"];
                                Resons = (string)reader["DamageResons"];
                                date = (DateTime)reader["DamageDate"];
                                Quantity = (int)reader["quntityDamaged"];
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

        public static bool Update(int ID, int StockID, string Resons, DateTime date, int Quantity)
        {
            int RowsAffeced = 0;
            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"UPDATE [dbo].[Damageds]
                                   SET [StockID] = @StockID
                                      ,[DamageResons] = @Resons
                                      ,[DamageDate] = @date
                                      ,[quntityDamaged] = @Quantity
                                 WHERE DamagedID = @ID";
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(quary,connection))
                    {
                        command.Parameters.AddWithValue("@StockID", StockID);
                        command.Parameters.AddWithValue("@Resons", Resons);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@ID", ID);

                        RowsAffeced =  command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                RowsAffeced = 0;
            }
            return RowsAffeced > 0;
        }

        public static bool Delete(int ID)
        {
            int RowsAffeced = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"delete from Damageds where DamagedID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
             
                        command.Parameters.AddWithValue("@ID", ID);

                        RowsAffeced = command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                RowsAffeced = 0;
            }
            return RowsAffeced > 0;
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable(); 
            try
            { 
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                    d.DamagedID as 'معرف التالف',
                                    p.productName as 'المنتج',
                                    p.GTIN as 'الرقم العالمي',
                                    d.DamageDate as 'تاريخ التلف',
                                    d.DamageResons as 'اسباب التلف',
                                    d.quntityDamaged as 'الكمية التالفة',
                                    d.StockID as 'معرف الكمية',
                                    s.Entrancequantity as 'عدد الكمية الاجمالي',
                                    s.EntranceDate as 'تاريخ دخول الكمية',
                                    s.CostPrice as 'سعر الشراء للحبة'
                                    from Damageds d 
                                    join stock s on d.StockID = s.StockID
                                    join Products p on s.productID = p.productID";
                    connection.Open();
                    using(SqlCommand command= new SqlCommand(quary, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return dt;
        }
    }
}
