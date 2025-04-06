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
    public class clsSellPointData
    {
        public static int Add( int UserID, DateTime Start, DateTime End, SqlMoney Amount, int TotalBills)
        {
            int ID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"INSERT INTO [dbo].[SellPoint]
                                       ([UserID]
                                       ,[startDate]
                                       ,[endDate]
                                       ,[totalAmount]
                                       ,[totalBills])
                                 VALUES
                                       (@UserID
                                       ,@Start
                                       ,@End
                                       ,@Amount
                                       ,@TotalBills);SELECT SCOPE_IDENTITY();";

                    connection.Open();
                    using(SqlCommand command = new SqlCommand(quary , connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Start", Start);
                        
                            command.Parameters.AddWithValue("@End", End);
                        
                        
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@TotalBills", TotalBills);
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ID = insertedID;
                        }
                    }
                }
            }
            catch {
                ID = -1;
            }
            return ID;

        }

        public static bool Update(int ID, int UserID, DateTime Start, DateTime End, SqlMoney Amount, int TotalBills)
        {
            int RowAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"UPDATE [dbo].[SellPoint]
                                   SET [UserID] =@UserID
                                      ,[startDate] = @Start
                                      ,[endDate] = @End
                                      ,[totalAmount] = @Amount
                                      ,[totalBills] = @TotalBills
                                 WHERE SellPointID = @ID";

                    connection.Open ();
                    using(SqlCommand command = new SqlCommand( quary , connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Start", Start);
                        command.Parameters.AddWithValue("@End", End);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@TotalBills", TotalBills);

                        RowAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch 
            {
                RowAffected = 0;
            }

            return RowAffected > 0;
        }

        public static bool Delete(int ID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"delete from SellPoint where SellPointID = @ID;";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
           

                        RowAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch
            {
                RowAffected = 0;
            }

            return RowAffected > 0;
        }

        public static bool Find(int ID, ref int UserID, ref DateTime Start, ref DateTime End, ref SqlMoney Amount, ref int TotalBills)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = "select * from SellPoint where SellPointID = @ID;";
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(quary , connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                Start = (DateTime)reader["startDate"];
                                End = (DateTime)reader["endDate"];
                                Amount = new SqlMoney((Decimal)reader["totalAmount"]);
                                TotalBills = (int)reader["totalBills"];
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

        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string quary = @"select 
                                    s.SellPointID as 'معرف النقطة',
                                    u.UserID as 'معرف المستخدم',
                                    (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'الاسم',
                                    s.startDate as 'بدء النقطة',
                                    COALESCE(s.endDate,' ') as 'انهاء النقطة',
                                    COALESCE(s.totalAmount,' ') as 'المبلغ الاجمالي',
                                    COALESCE(s.totalBills ,' ') as 'اجمالي عدد الفواتير'

                                    from SellPoint s
                                    join Users u on u.UserID = s.UserID 
                                    join people p on p.personID = u.personID;";
                    connection.Open ();
                    using(SqlCommand command = new SqlCommand( quary , connection))
                    {
                        using(SqlDataReader r = command.ExecuteReader())
                        {
                            if(r.HasRows)
                            {
                                dataTable.Load(r);
                            }
                        }
                    }
                }

            }
            catch
            {

            }

            return dataTable; 
        }

        public static int GetTotalAmount(int ID)
        {
            int Amount = 0;
            string quary = "select SUM(PaidPrice) as sum  from Bills where sellPointID = @ID";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(quary, sqlConnection))
                    {
                        sqlConnection.Open();
                        command.Parameters.AddWithValue("@ID", ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["sum"] == System.DBNull.Value)
                                    Amount = 0;
                                else
                                {
                                    Amount = (int)reader["sum"];
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return Amount;
        }

        public static int GetTotalBills(int ID)
        {
            int Bills = 0;
            string quary = "select count(*) as count from Bills where sellPointID = @ID";
            try
            {
                using(SqlConnection sqlConnection = new SqlConnection (DataAccessSettings.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand ( quary , sqlConnection))
                    {
                        sqlConnection.Open ();
                        command.Parameters.AddWithValue("@ID", ID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Bills = (int)reader["count"];
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            return Bills;
        }
    }
}
