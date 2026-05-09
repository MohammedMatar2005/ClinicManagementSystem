using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPatientVisitsData
{
    // 1. Get All PatientVisits
    public static DataTable GetAllPatientVisits()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_GetAll", connection))
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
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }
        return dt;
    }

    // 2. Get Info By ID
    public static bool GetPatientVisitInfoByID(int VisitId, ref int AppointmentId, ref DateTime VisitDate,
        ref string Symptoms, ref string Diagnosis, ref string TreatmentPlan, ref string BloodPressure,
        ref decimal? Temperature, ref int? HeartRate, ref int? RespiratoryRate,
        ref decimal? Weight, ref decimal? Height, ref string Notes, ref DateTime CreatedDate)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            AppointmentId = (int)reader["AppointmentId"];
                            VisitDate = (DateTime)reader["VisitDate"];

                            // معالجة النصوص التي تقبل NULL
                            Symptoms = reader["Symptoms"] != DBNull.Value ? (string)reader["Symptoms"] : string.Empty;
                            Diagnosis = reader["Diagnosis"] != DBNull.Value ? (string)reader["Diagnosis"] : string.Empty;
                            TreatmentPlan = reader["TreatmentPlan"] != DBNull.Value ? (string)reader["TreatmentPlan"] : string.Empty;
                            BloodPressure = reader["BloodPressure"] != DBNull.Value ? (string)reader["BloodPressure"] : string.Empty;
                            Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : string.Empty;

                            // معالجة الأرقام التي تقبل NULL (Nullable Types)
                            Temperature = reader["Temperature"] != DBNull.Value ? (decimal?)reader["Temperature"] : null;
                            HeartRate = reader["HeartRate"] != DBNull.Value ? (int?)reader["HeartRate"] : null;
                            RespiratoryRate = reader["RespiratoryRate"] != DBNull.Value ? (int?)reader["RespiratoryRate"] : null;
                            Weight = reader["Weight"] != DBNull.Value ? (decimal?)reader["Weight"] : null;
                            Height = reader["Height"] != DBNull.Value ? (decimal?)reader["Height"] : null;

                            CreatedDate = (DateTime)reader["CreatedDate"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                    isFound = false;
                }
            }
        }
        return isFound;
    }

    // 3. Add New PatientVisit
    public static int AddNewPatientVisit(int AppointmentId, DateTime VisitDate, string Symptoms,
        string Diagnosis, string TreatmentPlan, string BloodPressure, decimal? Temperature,
        int? HeartRate, int? RespiratoryRate, decimal? Weight, decimal? Height, string Notes)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                command.Parameters.AddWithValue("@VisitDate", VisitDate);

                // معالجة النصوص: إرسال DBNull إذا كانت فارغة
                command.Parameters.AddWithValue("@Symptoms", (object)Symptoms ?? DBNull.Value);
                command.Parameters.AddWithValue("@Diagnosis", (object)Diagnosis ?? DBNull.Value);
                command.Parameters.AddWithValue("@TreatmentPlan", (object)TreatmentPlan ?? DBNull.Value);
                command.Parameters.AddWithValue("@BloodPressure", (object)BloodPressure ?? DBNull.Value);
                command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

                // معالجة الأرقام: إرسال DBNull إذا كانت Null
                command.Parameters.AddWithValue("@Temperature", (object)Temperature ?? DBNull.Value);
                command.Parameters.AddWithValue("@HeartRate", (object)HeartRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@RespiratoryRate", (object)RespiratoryRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@Weight", (object)Weight ?? DBNull.Value);
                command.Parameters.AddWithValue("@Height", (object)Height ?? DBNull.Value);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedId))
                    {
                        newID = insertedId;
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }
        return newID;
    }

    // 4. Update PatientVisit
    public static bool UpdatePatientVisit(int VisitId, int AppointmentId, DateTime VisitDate,
        string Symptoms, string Diagnosis, string TreatmentPlan, string BloodPressure,
        decimal? Temperature, int? HeartRate, int? RespiratoryRate, decimal? Weight, decimal? Height, string Notes)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                command.Parameters.AddWithValue("@VisitDate", VisitDate);

                command.Parameters.AddWithValue("@Symptoms", (object)Symptoms ?? DBNull.Value);
                command.Parameters.AddWithValue("@Diagnosis", (object)Diagnosis ?? DBNull.Value);
                command.Parameters.AddWithValue("@TreatmentPlan", (object)TreatmentPlan ?? DBNull.Value);
                command.Parameters.AddWithValue("@BloodPressure", (object)BloodPressure ?? DBNull.Value);
                command.Parameters.AddWithValue("@Temperature", (object)Temperature ?? DBNull.Value);
                command.Parameters.AddWithValue("@HeartRate", (object)HeartRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@RespiratoryRate", (object)RespiratoryRate ?? DBNull.Value);
                command.Parameters.AddWithValue("@Weight", (object)Weight ?? DBNull.Value);
                command.Parameters.AddWithValue("@Height", (object)Height ?? DBNull.Value);
                command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete PatientVisit
    public static bool DeletePatientVisit(int VisitId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence
    public static bool IsPatientVisitExist(int VisitId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_PatientVisits_GetById", connection)) // نستخدم GetById للتحقق
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isFound = reader.HasRows;
                    }
                }
                catch { isFound = false; }
            }
        }
        return isFound;
    }
}