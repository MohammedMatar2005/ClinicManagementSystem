

using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPaymentsData
{
    // 1. Get All Payments using SP_Payments_GetAll
    public static DataTable GetAllPayments()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) dt.Load(reader);
                    }
                }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return dt;
    }

    // 2. Get Info By ID using SP_Payments_GetByID
    public static bool GetPaymentInfoByID(int PaymentId, ref int InvoiceId, ref int PatientId, ref decimal PaymentAmount, ref string PaymentMethod, ref string PaymentStatus, ref string TransactionReference, ref DateTime PaymentDate, ref string Notes, ref DateTime CreatedDate, ref bool IsActive)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            InvoiceId = (int)reader["InvoiceId"];
                            PatientId = (int)reader["PatientId"];
                            PaymentAmount = (decimal)reader["PaymentAmount"];
                            PaymentMethod = (string)reader["PaymentMethod"];
                            PaymentStatus = (string)reader["PaymentStatus"];
                            TransactionReference = (string)reader["TransactionReference"];
                            PaymentDate = (DateTime)reader["PaymentDate"];
                            Notes = (string)reader["Notes"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            IsActive = (bool)reader["IsActive"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New Payment using SP_Payments_Insert
    public static int AddNewPayment(int InvoiceId, int PatientId, decimal PaymentAmount, string PaymentMethod, string PaymentStatus, string TransactionReference, DateTime PaymentDate, string Notes, DateTime CreatedDate, bool IsActive)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                command.Parameters.AddWithValue("@TransactionReference", TransactionReference);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);


                // نفترض أن الـ SP يحتوي على Parameter مخرجات لإعادة الـ ID الجديد
                SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    newID = (int)command.Parameters["@NewID"].Value;
                }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return newID;
    }

    // 4. Update Payment using SP_Payments_Update
    public static bool UpdatePayment(int PaymentId, int InvoiceId, int PatientId, decimal PaymentAmount, string PaymentMethod, string PaymentStatus, string TransactionReference, DateTime PaymentDate, string Notes, DateTime CreatedDate, bool IsActive)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                command.Parameters.AddWithValue("@TransactionReference", TransactionReference);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Payment using SP_Payments_Delete
    public static bool DeletePayment(int PaymentId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Payments_IsExist
    public static bool IsPaymentExist(int PaymentId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Payments_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
                catch { isFound = false; }
            }
        }
        return isFound;
    }
}