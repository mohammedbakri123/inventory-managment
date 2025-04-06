using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsPaymentData
    {
        public static int Add(DateTime date, string note, int ClientID, int amount)
        {
            int ID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"
                                    INSERT INTO [dbo].[DebtPayment]
                                               ([PaymentDate]
                                               ,[OtherInfo]
                                               ,[ClientID]
                                               ,[Amount])
                                         VALUES
                                               (@date
                                               ,@note
                                               ,@ClientID
                                               ,@amount);
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@note", note);
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@amount", amount);

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

        public static bool Update(int ID, DateTime date, string note, int ClientID, int amount)
        {
            int rowsAffeced = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"UPDATE [dbo].[DebtPayment]
                                   SET [PaymentDate] = @date
                                      ,[OtherInfo] = @note
                                      ,[ClientID] = @ClientID
                                      ,[Amount] = @amount
                                 WHERE PaymentID = @ID";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@note", note);
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@amount", amount);

                        rowsAffeced = command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                rowsAffeced = 0;
            }
            return rowsAffeced > 0;
        }

        public static bool Delete(int ID)
        {
            int rowsAffeced = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"delete from DebtPayment where PaymentID = @ID";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);

                        rowsAffeced = command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                rowsAffeced = 0;
            }
            return rowsAffeced > 0;
        }

        public static bool Find(int ID, ref DateTime date, ref string note, ref int ClientID, ref int amount)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"select * from DebtPayment where PaymentID = @ID";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                date = (DateTime)reader["PaymentDate"];
                                note = (string)reader["OtherInfo"];
                                ClientID = (int)reader["ClientID"];
                                amount = (int)reader["Amount"];

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

        public static DataTable GetAll(int ID)
        {
            {

                DataTable dt = new DataTable();
                try
                {
                    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                    {

                        string quary = @"select
                                        PaymentID as 'معرف عملية الدفع',
                                        PaymentDate as 'التاريخ',
                                        OtherInfo as 'ملاحظات',
                                        Amount as 'المبلغ'
                                        from DebtPayment where ClientID = @ID";
                        using (SqlCommand command = new SqlCommand(quary, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@ID", ID);

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
                catch
                {

                }
                return dt;
            }

        }
    }
}
