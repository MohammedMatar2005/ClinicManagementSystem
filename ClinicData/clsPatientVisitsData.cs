
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


public class clsPatientVisitsData
{
    // 1. Get All PatientVisits using SP_PatientVisits_GetAll
    public static DataTable GetAllPatientVisits()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_GetAll", connection))
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

    // 2. Get Info By ID using SP_PatientVisits_GetByID
    public static bool GetPatientVisitInfoByID(int VisitId, ref int AppointmentId, ref int PatientId, ref int DoctorId, ref DateTime VisitDate, ref string Symptoms, ref string Diagnosis, ref string TreatmentPlan, ref string BloodPressure, ref decimal Temperature, ref int HeartRate, ref int RespiratoryRate, ref decimal Weight, ref decimal Height, ref string Notes, ref DateTime CreatedDate)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_GetByID", connection))
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
                            PatientId = (int)reader["PatientId"];
                            DoctorId = (int)reader["DoctorId"];
                            VisitDate = (DateTime)reader["VisitDate"];
                            Symptoms = (string)reader["Symptoms"];
                            Diagnosis = (string)reader["Diagnosis"];
                            TreatmentPlan = (string)reader["TreatmentPlan"];
                            BloodPressure = (string)reader["BloodPressure"];
                            Temperature = (decimal)reader["Temperature"];
                            HeartRate = (int)reader["HeartRate"];
                            RespiratoryRate = (int)reader["RespiratoryRate"];
                            Weight = (decimal)reader["Weight"];
                            Height = (decimal)reader["Height"];
                            Notes = (string)reader["Notes"];
                            CreatedDate = (DateTime)reader["CreatedDate"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New PatientVisit using SP_PatientVisits_Insert
    public static int AddNewPatientVisit(int AppointmentId, int PatientId, int DoctorId, DateTime VisitDate, string Symptoms, string Diagnosis, string TreatmentPlan, string BloodPressure, decimal Temperature, int HeartRate, int RespiratoryRate, decimal Weight, decimal Height, string Notes, DateTime CreatedDate)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@DoctorId", DoctorId);
                command.Parameters.AddWithValue("@VisitDate", VisitDate);
                command.Parameters.AddWithValue("@Symptoms", Symptoms);
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                command.Parameters.AddWithValue("@TreatmentPlan", TreatmentPlan);
                command.Parameters.AddWithValue("@BloodPressure", BloodPressure);
                command.Parameters.AddWithValue("@Temperature", Temperature);
                command.Parameters.AddWithValue("@HeartRate", HeartRate);
                command.Parameters.AddWithValue("@RespiratoryRate", RespiratoryRate);
                command.Parameters.AddWithValue("@Weight", Weight);
                command.Parameters.AddWithValue("@Height", Height);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


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

    // 4. Update PatientVisit using SP_PatientVisits_Update
    public static bool UpdatePatientVisit(int VisitId, int AppointmentId, int PatientId, int DoctorId, DateTime VisitDate, string Symptoms, string Diagnosis, string TreatmentPlan, string BloodPressure, decimal Temperature, int HeartRate, int RespiratoryRate, decimal Weight, decimal Height, string Notes, DateTime CreatedDate)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@DoctorId", DoctorId);
                command.Parameters.AddWithValue("@VisitDate", VisitDate);
                command.Parameters.AddWithValue("@Symptoms", Symptoms);
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                command.Parameters.AddWithValue("@TreatmentPlan", TreatmentPlan);
                command.Parameters.AddWithValue("@BloodPressure", BloodPressure);
                command.Parameters.AddWithValue("@Temperature", Temperature);
                command.Parameters.AddWithValue("@HeartRate", HeartRate);
                command.Parameters.AddWithValue("@RespiratoryRate", RespiratoryRate);
                command.Parameters.AddWithValue("@Weight", Weight);
                command.Parameters.AddWithValue("@Height", Height);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete PatientVisit using SP_PatientVisits_Delete
    public static bool DeletePatientVisit(int VisitId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_PatientVisits_IsExist
    public static bool IsPatientVisitExist(int VisitId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_PatientVisits_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);

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