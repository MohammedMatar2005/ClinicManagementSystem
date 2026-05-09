using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPrescriptionsData
{
    // 1. Get All Prescriptions
    public static DataTable GetAllPrescriptions()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_GetAll", connection))
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

    // 2. Get By ID
    public static bool GetPrescriptionInfoByID(
        int PrescriptionId,
        ref int VisitId,
        ref string MedicineName,
        ref string Dosage,
        ref string Frequency,
        ref int? Duration,
        ref string Instructions,
        ref int? Quantity,
        ref DateTime? StartDate,
        ref DateTime? EndDate,
        ref DateTime CreatedDate)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            VisitId = (int)reader["VisitId"];
                            MedicineName = (string)reader["MedicineName"];
                            Dosage = (string)reader["Dosage"];
                            Frequency = (string)reader["Frequency"];

                            Duration = reader["Duration"] != DBNull.Value
                                ? (int?)reader["Duration"]
                                : null;

                            Instructions = reader["Instructions"] != DBNull.Value
                                ? (string)reader["Instructions"]
                                : null;

                            Quantity = reader["Quantity"] != DBNull.Value
                                ? (int?)reader["Quantity"]
                                : null;

                            StartDate = reader["StartDate"] != DBNull.Value
                                ? (DateTime?)reader["StartDate"]
                                : null;

                            EndDate = reader["EndDate"] != DBNull.Value
                                ? (DateTime?)reader["EndDate"]
                                : null;

                            CreatedDate = (DateTime)reader["CreatedDate"];
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

    // 3. Add Prescription
    public static int AddNewPrescription(
        int VisitId,
        string MedicineName,
        string Dosage,
        string Frequency,
        int? Duration,
        string Instructions,
        int? Quantity,
        DateTime? StartDate,
        DateTime? EndDate)
    {
        int newID = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@MedicineName", MedicineName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);

                command.Parameters.AddWithValue("@Duration",
                    (object)Duration ?? DBNull.Value);

                command.Parameters.AddWithValue("@Instructions",
                    (object)Instructions ?? DBNull.Value);

                command.Parameters.AddWithValue("@Quantity",
                    (object)Quantity ?? DBNull.Value);

                command.Parameters.AddWithValue("@StartDate",
                    (object)StartDate ?? DBNull.Value);

                command.Parameters.AddWithValue("@EndDate",
                    (object)EndDate ?? DBNull.Value);

               

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        newID = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newID;
    }

    // 4. Update Prescription
    public static bool UpdatePrescription(
        int PrescriptionId,
        int VisitId,
        string MedicineName,
        string Dosage,
        string Frequency,
        int? Duration,
        string Instructions,
        int? Quantity,
        DateTime? StartDate,
        DateTime? EndDate)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@MedicineName", MedicineName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);

                command.Parameters.AddWithValue("@Duration",
                    (object)Duration ?? DBNull.Value);

                command.Parameters.AddWithValue("@Instructions",
                    (object)Instructions ?? DBNull.Value);

                command.Parameters.AddWithValue("@Quantity",
                    (object)Quantity ?? DBNull.Value);

                command.Parameters.AddWithValue("@StartDate",
                    (object)StartDate ?? DBNull.Value);

                command.Parameters.AddWithValue("@EndDate",
                    (object)EndDate ?? DBNull.Value);

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

    // 5. Delete Prescription
    public static bool DeletePrescription(int PrescriptionId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);

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

    // 6. Exists
    public static bool IsPrescriptionExist(int PrescriptionId)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("SP_Prescriptions_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
                catch
                {
                    isFound = false;
                }
            }
        }

        return isFound;
    }
}