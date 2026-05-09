using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsInvoicesData
{
    // ==========================================
    // Get All Invoices
    // ==========================================
    public static DataTable GetAllInvoices()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return dt;
    }

    // ==========================================
    // Invoices List View
    // ==========================================
    public static DataTable GetInvoicesListView()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_ListView", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return dt;
    }

    // ==========================================
    // Get Invoice By ID
    // ==========================================
    public static bool GetInvoiceInfoByID(
       int InvoiceId,
       ref int VisitId,
       ref string InvoiceNumber,
       ref DateTime InvoiceDate,
       ref decimal ConsultationFee,
       ref decimal LabTestFee,
       ref decimal ProcedureFee,
       ref decimal OtherCharges,
       ref decimal? TaxPercentage,
       ref decimal? TaxAmount,
       ref decimal? DiscountPercentage,
       ref decimal? DiscountAmount,
       ref decimal SubTotal,
       ref decimal FinalAmount,
       ref byte StatusId,
       ref DateTime? DueDate,
       ref DateTime CreatedDate,
       ref bool IsActive)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_GetById", connection))
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
                            InvoiceNumber = (string)reader["InvoiceNumber"];
                            InvoiceDate = (DateTime)reader["InvoiceDate"];

                            ConsultationFee = (decimal)reader["ConsultationFee"];
                            LabTestFee = (decimal)reader["LabTestFee"];
                            ProcedureFee = (decimal)reader["ProcedureFee"];
                            OtherCharges = (decimal)reader["OtherCharges"];

                            TaxPercentage = reader["TaxPercentage"] != DBNull.Value
                                ? (decimal?)reader["TaxPercentage"]
                                : null;

                            TaxAmount = reader["TaxAmount"] != DBNull.Value
                                ? (decimal?)reader["TaxAmount"]
                                : null;

                            DiscountPercentage = reader["DiscountPercentage"] != DBNull.Value
                                ? (decimal?)reader["DiscountPercentage"]
                                : null;

                            DiscountAmount = reader["DiscountAmount"] != DBNull.Value
                                ? (decimal?)reader["DiscountAmount"]
                                : null;

                            SubTotal = (decimal)reader["SubTotal"];
                            FinalAmount = (decimal)reader["FinalAmount"];

                            StatusId = Convert.ToByte(reader["StatusId"]);

                            DueDate = reader["DueDate"] != DBNull.Value
                                ? (DateTime?)reader["DueDate"]
                                : null;

                            CreatedDate = (DateTime)reader["CreatedDate"];
                            IsActive = (bool)reader["IsActive"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;

                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return isFound;
    }

    // ==========================================
    // Add New Invoice
    // ==========================================
    public static int AddNewInvoice(
        int VisitId,
        string InvoiceNumber,
        DateTime InvoiceDate,
        decimal ConsultationFee,
        decimal LabTestFee,
        decimal ProcedureFee,
        decimal OtherCharges,
        decimal? TaxPercentage,
        decimal? TaxAmount,
        decimal? DiscountPercentage,
        decimal? DiscountAmount,
        byte StatusId,
        DateTime? DueDate)
    {
        int newInvoiceId = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@VisitId", VisitId);

                command.Parameters.AddWithValue("@InvoiceNumber",
                    InvoiceNumber);

                command.Parameters.AddWithValue("@InvoiceDate",
                    InvoiceDate);

                command.Parameters.AddWithValue("@ConsultationFee",
                    ConsultationFee);

                command.Parameters.AddWithValue("@LabTestFee",
                    LabTestFee);

                command.Parameters.AddWithValue("@ProcedureFee",
                    ProcedureFee);

                command.Parameters.AddWithValue("@OtherCharges",
                    OtherCharges);

                command.Parameters.AddWithValue("@TaxPercentage",
                    (object)TaxPercentage ?? DBNull.Value);

                command.Parameters.AddWithValue("@TaxAmount",
                    (object)TaxAmount ?? DBNull.Value);

                command.Parameters.AddWithValue("@DiscountPercentage",
                    (object)DiscountPercentage ?? DBNull.Value);

                command.Parameters.AddWithValue("@DiscountAmount",
                    (object)DiscountAmount ?? DBNull.Value);

                command.Parameters.AddWithValue("@StatusId",
                    StatusId);

                command.Parameters.AddWithValue("@DueDate",
                    (object)DueDate ?? DBNull.Value);

                try
                {
                    connection.Open();

                    newInvoiceId = (int)command.ExecuteScalar();

                   
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newInvoiceId;
    }
    // ==========================================
    // Update Invoice
    // ==========================================
    public static bool UpdateInvoice(
        int InvoiceId,
        int VisitId,
        string InvoiceNumber,
        DateTime InvoiceDate,
        decimal ConsultationFee,
        decimal LabTestFee,
        decimal ProcedureFee,
        decimal OtherCharges,
        decimal? TaxPercentage,
        decimal? TaxAmount,
        decimal? DiscountPercentage,
        decimal? DiscountAmount,
        byte StatusId,
        DateTime? DueDate,
        bool IsActive)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);
                command.Parameters.AddWithValue("@VisitId", VisitId);

                command.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber);
                command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);

                command.Parameters.AddWithValue("@ConsultationFee", ConsultationFee);
                command.Parameters.AddWithValue("@LabTestFee", LabTestFee);
                command.Parameters.AddWithValue("@ProcedureFee", ProcedureFee);
                command.Parameters.AddWithValue("@OtherCharges", OtherCharges);

                command.Parameters.AddWithValue("@TaxPercentage",
                    (object)TaxPercentage ?? DBNull.Value);

                command.Parameters.AddWithValue("@TaxAmount",
                    (object)TaxAmount ?? DBNull.Value);

                command.Parameters.AddWithValue("@DiscountPercentage",
                    (object)DiscountPercentage ?? DBNull.Value);

                command.Parameters.AddWithValue("@DiscountAmount",
                    (object)DiscountAmount ?? DBNull.Value);

                command.Parameters.AddWithValue("@StatusId", StatusId);

                command.Parameters.AddWithValue("@DueDate",
                    (object)DueDate ?? DBNull.Value);

                command.Parameters.AddWithValue("@IsActive", IsActive);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return (rowsAffected > 0);
    }
    // ==========================================
    // Delete Invoice (Soft Delete)
    // ==========================================
    public static bool DeleteInvoice(int InvoiceId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@InvoiceId", InvoiceId);

                try
                {
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return (rowsAffected > 0);
    }

    // ==========================================
    // Get Overdue Invoices
    // ==========================================
    public static DataTable GetOverdueInvoices()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Invoices_GetOverdue", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return dt;
    }
}