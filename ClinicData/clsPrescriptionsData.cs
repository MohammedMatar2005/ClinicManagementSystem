
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


public class clsPrescriptionsData
{
    // 1. Get All Prescriptions using SP_Prescriptions_GetAll
    public static DataTable GetAllPrescriptions()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_GetAll", connection))
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

    // 2. Get Info By ID using SP_Prescriptions_GetByID
    public static bool GetPrescriptionInfoByID(int PrescriptionId, ref int VisitId, ref int PatientId, ref string MedicineName, ref string Dosage, ref string Frequency, ref int Duration, ref string Instructions, ref int Quantity, ref DateTime StartDate, ref DateTime EndDate, ref DateTime CreatedDate)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_GetByID", connection))
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
                            PatientId = (int)reader["PatientId"];
                            MedicineName = (string)reader["MedicineName"];
                            Dosage = (string)reader["Dosage"];
                            Frequency = (string)reader["Frequency"];
                            Duration = (int)reader["Duration"];
                            Instructions = (string)reader["Instructions"];
                            Quantity = (int)reader["Quantity"];
                            StartDate = (DateTime)reader["StartDate"];
                            EndDate = (DateTime)reader["EndDate"];
                            CreatedDate = (DateTime)reader["CreatedDate"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New Prescription using SP_Prescriptions_Insert
    public static int AddNewPrescription(int VisitId, int PatientId, string MedicineName, string Dosage, string Frequency, int Duration, string Instructions, int Quantity, DateTime StartDate, DateTime EndDate, DateTime CreatedDate)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@MedicineName", MedicineName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);
                command.Parameters.AddWithValue("@Duration", Duration);
                command.Parameters.AddWithValue("@Instructions", Instructions);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
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

    // 4. Update Prescription using SP_Prescriptions_Update
    public static bool UpdatePrescription(int PrescriptionId, int VisitId, int PatientId, string MedicineName, string Dosage, string Frequency, int Duration, string Instructions, int Quantity, DateTime StartDate, DateTime EndDate, DateTime CreatedDate)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);
                command.Parameters.AddWithValue("@VisitId", VisitId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@MedicineName", MedicineName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);
                command.Parameters.AddWithValue("@Duration", Duration);
                command.Parameters.AddWithValue("@Instructions", Instructions);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Prescription using SP_Prescriptions_Delete
    public static bool DeletePrescription(int PrescriptionId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Prescriptions_IsExist
    public static bool IsPrescriptionExist(int PrescriptionId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Prescriptions_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);

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