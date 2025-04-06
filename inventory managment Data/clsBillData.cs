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
    public class clsBillData
    {
        public static int Add(int ClientID, int SellPointID, DateTime issueDate, SqlMoney totalPrice, SqlMoney PaidPrice)
        {
            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"INSERT INTO [dbo].[Bills]
                                    ([sellPointID]
                                    ,[ClientID]
                                    ,[billDate]
                                    ,[totalPrice]
                                    ,[PaidPrice])
                                VALUES
                                    (@SellPointID
                                    ,@ClientID
                                    ,@issueDate
                                    ,@totalPrice
                                    ,@PaidPrice);SELECT SCOPE_IDENTITY();";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@SellPointID", SellPointID);
                        command.Parameters.AddWithValue("@issueDate", issueDate);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);
                        command.Parameters.AddWithValue("@PaidPrice", PaidPrice);


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

        public static bool Update(int ID , int ClientID, int SellPointID, DateTime issueDate, SqlMoney totalPrice, SqlMoney PaidPrice)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"UPDATE [dbo].[Bills]
                                       SET [sellPointID] = @SellPointID
                                          ,[ClientID] = @ClientID
                                          ,[billDate] = @issueDate
                                          ,[totalPrice] = @totalPrice
                                          ,[PaidPrice] = @PaidPrice
                                     WHERE BillID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@SellPointID", SellPointID);
                        command.Parameters.AddWithValue("@issueDate", issueDate);
                        command.Parameters.AddWithValue("@totalPrice", totalPrice);
                        command.Parameters.AddWithValue("@PaidPrice", PaidPrice);
                        command.Parameters.AddWithValue("@ID",ID);

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
                    string quary = @"Delete from Bills where BillID = @ID";
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

        public static bool find(int ID,ref int ClientID, ref int SellPointID, ref DateTime issueDate, ref SqlMoney totalPrice, ref SqlMoney PaidPrice)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select * from Bills where BillID = @ID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                       
                                isFound = true;
                                ClientID = (int)reader["ClientID"];
                                SellPointID = (int)reader["sellPointID"];
                                issueDate = (DateTime)reader["billDate"];
                                totalPrice = new SqlMoney((decimal)reader["totalPrice"]);
                                PaidPrice = new SqlMoney((decimal)reader["PaidPrice"]);





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

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                        b.BillID as 'معرف الفاتورة',
                                        b.billDate as 'تاريخ صدورها',
                                        b.totalPrice as 'قيمة الفاتورة',
                                        b.PaidPrice as 'المبلغ المدفوع',
                                        c.ClientID as 'معرف العميل',
                                        c.CompanyName as 'اسم العميل' ,
	                                    b.sellPointID as 'نقطة البيع',
                                        u.UserID as 'معرف المستخدم' ,
                                        (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'اسم المستخدم'

                                        from Bills b 
                                        join Clients c on c.ClientID = b.ClientID
                                        join SellPoint s on s.SellPointID = b.sellPointID
                                        join Users u on u.UserID = s.UserID
                                        join people p on p.personID = u.personID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
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
            catch (Exception ex)
            {
             
            }
            return dt;
        }

        public static DataTable GetAllForUser(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                        b.BillID as 'معرف الفاتورة',
                                        b.billDate as 'تاريخ صدورها',
                                        b.totalPrice as 'قيمة الفاتورة',
                                        b.PaidPrice as 'المبلغ المدفوع',
                                        c.ClientID as 'معرف العميل',
                                        c.CompanyName as 'اسم العميل' ,
                                        b.sellPointID as 'نقطة البيع',
                                        u.UserID as 'معرف المستخدم' ,
                                        (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'اسم المستخدم'

                                        from Bills b 
                                        join Clients c on c.ClientID = b.ClientID
                                        join SellPoint s on s.SellPointID = b.sellPointID
                                        join Users u on u.UserID = s.UserID
                                        join people p on p.personID = u.personID
                                        where s.UserID = @ID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ID", UserID);

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

        public static DataTable GetAllForClient(int ClientID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                        b.BillID as 'معرف الفاتورة',
                                        b.billDate as 'تاريخ صدورها',
                                        b.totalPrice as 'قيمة الفاتورة',
                                        b.PaidPrice as 'المبلغ المدفوع',
                                        c.ClientID as 'معرف العميل',
                                        c.CompanyName as 'اسم العميل' ,
                                        b.sellPointID as 'نقطة البيع',
                                        u.UserID as 'معرف المستخدم' ,
                                        (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'اسم المستخدم'

                                        from Bills b 
                                        join Clients c on c.ClientID = b.ClientID
                                        join SellPoint s on s.SellPointID = b.sellPointID
                                        join Users u on u.UserID = s.UserID
                                        join people p on p.personID = u.personID
                                        where b.ClientID = @ID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ClientID);

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


        public static DataTable GetAllForSellPoint(int SellPointID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                        b.BillID as 'معرف الفاتورة',
                                        b.billDate as 'تاريخ صدورها',
                                        b.totalPrice as 'قيمة الفاتورة',
                                        b.PaidPrice as 'المبلغ المدفوع',
                                        c.ClientID as 'معرف العميل',
                                        c.CompanyName as 'اسم العميل' ,
                                        b.sellPointID as 'نقطة البيع',
                                        u.UserID as 'معرف المستخدم' ,
                                        (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'اسم المستخدم'

                                        from Bills b 
                                        join Clients c on c.ClientID = b.ClientID
                                        join SellPoint s on s.SellPointID = b.sellPointID
                                        join Users u on u.UserID = s.UserID
                                        join people p on p.personID = u.personID
                                        where b.sellPointID = @ID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ID", SellPointID);

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
