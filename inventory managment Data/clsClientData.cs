using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_managment_Data
{
    public class clsClientData
    {
        public static int Add(int PersonID, DateTime registereDate, string CompanyName, int TotalDebt)
        {
            int ID = -1;
            try
            {
                using(SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"INSERT INTO [dbo].[Clients]
                                       ([PersonID]
                                       ,[totalDebts]
                                       ,[registereDate]
                                       ,[CompanyName])
                                 VALUES
                                       (@PersonID
                                       ,@TotalDebt
                                       ,@registereDate
                                       ,@CompanyName);SELECT SCOPE_IDENTITY();";
                    using(SqlCommand command = new SqlCommand(quary , connection)) 
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@registereDate", registereDate);
                        command.Parameters.AddWithValue("@CompanyName", CompanyName);
                        command.Parameters.AddWithValue("@TotalDebt", TotalDebt);
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

        public static bool Update(int ID,int PersonID, DateTime registereDate, string CompanyName, int TotalDebt)
        {
            int rowsAffeced = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"UPDATE [dbo].[Clients]
                                       SET [PersonID] = @PersonID
                                          ,[totalDebts] = @TotalDebt
                                          ,[registereDate] = @registereDate
                                          ,[CompanyName] = @CompanyName
                                        WHERE ClientID = @ID";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@registereDate", registereDate);
                        command.Parameters.AddWithValue("@CompanyName", CompanyName);
                        command.Parameters.AddWithValue("@TotalDebt", TotalDebt);
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

        public static bool Delete(int ID)
        {
            int rowsAffeced = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"delete from Clients where ClientID = @ID";
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

        public static bool Find(int ID, ref int PersonID, ref DateTime registereDate, ref string CompanyName, ref int TotalDebt)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string quary = @"select * from Clients where ClientID = @ID";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {

                        command.Parameters.AddWithValue("@ID", ID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                registereDate = (DateTime)reader["registereDate"];
                                CompanyName = (string)reader["CompanyName"];
                                TotalDebt = (int)reader["totalDebts"];

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
          
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {

                    string quary = @"select 
                                    c.ClientID as 'معرف الزبون',
                                    (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'الاسم',
                                    c.registereDate as 'تاريخ التسجيل',
                                    p.Phone as 'رقم الهاتف',
                                    c.CompanyName as 'الاسم التوضيحي',
                                    c.totalDebts as 'اجمالي الديون'
                                    from Clients c 
                                    join people p on p.personID = c.PersonID ";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        connection.Open();
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
        public static DataTable GetAllShortened()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {

                    string quary = @"select 
                                        c.ClientID as 'معرف الزبون',
                                        (p.FirstName + ' ' +p.SecondName+ ' ' +p.ThirdName+ ' ' +p.LastName) as 'الاسم',
                                        c.CompanyName as 'الاسم التوضيحي',
                                        c.totalDebts as 'اجمالي الديون'
                                        from Clients c 
                                        join people p on p.personID = c.PersonID ";
                    using (SqlCommand command = new SqlCommand(quary, connection))
                    {
                        connection.Open();
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
