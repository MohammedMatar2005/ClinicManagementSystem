

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
            using (SqlCommand command = new SqlCommand("Sp_Payments_GetAll", connection))
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
    public static bool GetPaymentInfoByID(int PaymentId, ref int InvoiceId, ref string PatientFullName, ref string DoctorFullName, ref decimal PaymentAmount, ref string PaymentMethod,
        ref byte PaymentStatusId, ref string TransactionReference, ref DateTime PaymentDate,
        ref string Notes, ref DateTime CreatedDate, ref bool IsActive)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_Payments_GetById", connection))
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

                            DoctorFullName = (string)reader["DoctorFullName"];
                            PatientFullName = (string)reader["PatientFullName"];


                            PaymentAmount = (decimal)reader["PaymentAmount"];
                            
                            PaymentStatusId = (byte)reader["PaymentStatusId"];
                            TransactionReference = (string)reader["TransactionReference"];
                            PaymentDate = (DateTime)reader["PaymentDate"];
                           
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            IsActive = (bool)reader["IsActive"];


                            PaymentMethod =
                                reader["PaymentMethod"] != DBNull.Value
                                ? (string)reader["PaymentMethod"]
                                : string.Empty;

                            Notes =
                                reader["Notes"] != DBNull.Value
                                ? (string)reader["Notes"]
                                : string.Empty;

                        }
                    }
                }
                catch (Exception ex) { isFound = false; EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return isFound;
    }

    // 3. Add New Payment using SP_Payments_Insert
    public static int AddNewPayment(int InvoiceId, decimal PaymentAmount, string PaymentMethod, byte PaymentStatusId, string TransactionReference, DateTime PaymentDate, string Notes, DateTime CreatedDate, bool IsActive)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_Payments_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                command.Parameters.AddWithValue("@PaymentMethod", string.IsNullOrWhiteSpace(PaymentMethod)? DBNull.Value : (object) PaymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", PaymentStatusId);
                command.Parameters.AddWithValue("@TransactionReference", string.IsNullOrWhiteSpace(TransactionReference) ? DBNull.Value : (object)TransactionReference);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(Notes) ? DBNull.Value : (object)Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);


                // نفترض أن الـ SP يحتوي على Parameter مخرجات لإعادة الـ ID الجديد

                try
                {
                    connection.Open();
                     newID = (int)command.ExecuteScalar();
                  
                }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return newID;
    }

    // 4. Update Payment using SP_Payments_Update
    public static bool UpdatePayment(int PaymentId, int InvoiceId,  decimal PaymentAmount, string PaymentMethod, byte PaymentStatusId, string TransactionReference, DateTime PaymentDate, string Notes, DateTime CreatedDate, bool IsActive)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_Payments_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                command.Parameters.AddWithValue("@PaymentMethod", string.IsNullOrWhiteSpace( PaymentMethod) ? DBNull.Value : (object)PaymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", PaymentStatusId);
                command.Parameters.AddWithValue("@TransactionReference", string.IsNullOrWhiteSpace(TransactionReference) ? DBNull.Value : (object)TransactionReference);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(Notes) ? DBNull.Value : (object)Notes);
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
            using (SqlCommand command = new SqlCommand("Sp_Payments_SoftDelete", connection))
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
            using (SqlCommand command = new SqlCommand("Sp_Payments_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentId", PaymentId);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
                catch(Exception ex) { isFound = false; EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return isFound;
    }
}