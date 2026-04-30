
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


public class clsInvoicesData
{
    // 1. Get All Invoices using SP_Invoices_GetAll
    public static DataTable GetAllInvoices()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_GetAll", connection))
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

    public static DataTable GetAllInvoices_Sorted()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("sp_GetAllInvoicesSortedByStatus", connection))
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


    // 2. Get Info By ID using SP_Invoices_GetByID
    public static bool GetInvoiceInfoByID(int InvoiceId, ref int VisitId, ref int PatientId, ref string InvoiceNumber, ref DateTime InvoiceDate, ref decimal ConsultationFee, ref decimal LabTestFee, ref decimal ProcedureFee, ref decimal OtherCharges, ref decimal SubTotal, ref decimal TaxPercentage, ref decimal TaxAmount, ref decimal DiscountPercentage, ref decimal DiscountAmount, ref decimal FinalAmount, ref int StatusId, ref DateTime DueDate, ref DateTime CreatedDate, ref bool IsActive)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            VisitId = (int)reader["VisitId"];
                            PatientId = (int)reader["PatientId"];
                            InvoiceNumber = (string)reader["InvoiceNumber"];
                            InvoiceDate = (DateTime)reader["InvoiceDate"];
                            ConsultationFee = (decimal)reader["ConsultationFee"];
                            LabTestFee = (decimal)reader["LabTestFee"];
                            ProcedureFee = (decimal)reader["ProcedureFee"];
                            OtherCharges = (decimal)reader["OtherCharges"];
                            SubTotal = (decimal)reader["SubTotal"];
                            TaxPercentage = (decimal)reader["TaxPercentage"];
                            TaxAmount = (decimal)reader["TaxAmount"];
                            DiscountPercentage = (decimal)reader["DiscountPercentage"];
                            DiscountAmount = (decimal)reader["DiscountAmount"];
                            FinalAmount = (decimal)reader["FinalAmount"];
                            StatusId = (int)reader["StatusId"];
                            DueDate = (DateTime)reader["DueDate"];
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

    // 3. Add New Invoice using SP_Invoices_Insert
    public static int AddNewInvoice(int VisitId, int PatientId, string InvoiceNumber, DateTime InvoiceDate, decimal ConsultationFee, decimal LabTestFee, decimal ProcedureFee, decimal OtherCharges, decimal SubTotal, decimal TaxPercentage, decimal TaxAmount, decimal DiscountPercentage, decimal DiscountAmount, decimal FinalAmount, int StatusId, DateTime DueDate, DateTime CreatedDate, bool IsActive)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);
                command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                command.Parameters.AddWithValue("@ConsultationFee", ConsultationFee);
                command.Parameters.AddWithValue("@LabTestFee", LabTestFee);
                command.Parameters.AddWithValue("@ProcedureFee", ProcedureFee);
                command.Parameters.AddWithValue("@OtherCharges", OtherCharges);
                command.Parameters.AddWithValue("@SubTotal", SubTotal);
                command.Parameters.AddWithValue("@TaxPercentage", TaxPercentage);
                command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                command.Parameters.AddWithValue("@DiscountPercentage", DiscountPercentage);
                command.Parameters.AddWithValue("@DiscountAmount", DiscountAmount);
                command.Parameters.AddWithValue("@FinalAmount", FinalAmount);
                command.Parameters.AddWithValue("@StatusId", StatusId);
                command.Parameters.AddWithValue("@DueDate", DueDate);
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

    // 4. Update Invoice using SP_Invoices_Update
    public static bool UpdateInvoice(int InvoiceId, int VisitId, int PatientId, string InvoiceNumber, DateTime InvoiceDate, decimal ConsultationFee, decimal LabTestFee, decimal ProcedureFee, decimal OtherCharges, decimal SubTotal, decimal TaxPercentage, decimal TaxAmount, decimal DiscountPercentage, decimal DiscountAmount, decimal FinalAmount, int StatusId, DateTime DueDate, DateTime CreatedDate, bool IsActive)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);
                command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                command.Parameters.AddWithValue("@ConsultationFee", ConsultationFee);
                command.Parameters.AddWithValue("@LabTestFee", LabTestFee);
                command.Parameters.AddWithValue("@ProcedureFee", ProcedureFee);
                command.Parameters.AddWithValue("@OtherCharges", OtherCharges);
                command.Parameters.AddWithValue("@SubTotal", SubTotal);
                command.Parameters.AddWithValue("@TaxPercentage", TaxPercentage);
                command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                command.Parameters.AddWithValue("@DiscountPercentage", DiscountPercentage);
                command.Parameters.AddWithValue("@DiscountAmount", DiscountAmount);
                command.Parameters.AddWithValue("@FinalAmount", FinalAmount);
                command.Parameters.AddWithValue("@StatusId", StatusId);
                command.Parameters.AddWithValue("@DueDate", DueDate);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Invoice using SP_Invoices_Delete
    public static bool DeleteInvoice(int InvoiceId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Invoices_IsExist
    public static bool IsInvoiceExist(int InvoiceId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Invoices_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

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