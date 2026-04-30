
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using System.Windows;


public class clsPatientsData
{
    // 1. Get All Patients using SP_Patients_GetAll
    public static DataTable GetAllPatients()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_GetAll", connection))
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
                   // MessageBox.Show($"خطأ في GetAllPatients: {ex.Message}");
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); 
                }
            }
        }
        return dt;
    }
    // 2. Get Info By ID using SP_Patients_GetByID
    public static bool GetPatientInfoByID(int PatientId, ref int PersonId, ref string EmergencyContact, ref string EmergencyPhone, ref string BloodType, ref string Allergies, ref string MedicalHistory, ref bool IsActive, ref DateTime CreatedDate, ref string Email)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientId", PatientId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonId = (int)reader["PersonId"];
                            EmergencyContact = (string)reader["EmergencyContact"];
                            EmergencyPhone = (string)reader["EmergencyPhone"];
                            BloodType = (string)reader["BloodType"];
                            Allergies = (string)reader["Allergies"];
                            MedicalHistory = (string)reader["MedicalHistory"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            Email = (string)reader["Email"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New Patient using SP_Patients_Insert
    public static int AddNewPatient(int PersonId, string EmergencyContact, string EmergencyPhone, string BloodType, string Allergies, string MedicalHistory, bool IsActive, DateTime CreatedDate, string Email)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@EmergencyContact", EmergencyContact);
                command.Parameters.AddWithValue("@EmergencyPhone", EmergencyPhone);
                command.Parameters.AddWithValue("@BloodType", BloodType);
                command.Parameters.AddWithValue("@Allergies", Allergies);
                command.Parameters.AddWithValue("@MedicalHistory", MedicalHistory);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@Email", Email);


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

    // 4. Update Patient using SP_Patients_Update
    public static bool UpdatePatient(int PatientId, int PersonId, string EmergencyContact, string EmergencyPhone, string BloodType, string Allergies, string MedicalHistory, bool IsActive, DateTime CreatedDate, string Email)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@EmergencyContact", EmergencyContact);
                command.Parameters.AddWithValue("@EmergencyPhone", EmergencyPhone);
                command.Parameters.AddWithValue("@BloodType", BloodType);
                command.Parameters.AddWithValue("@Allergies", Allergies);
                command.Parameters.AddWithValue("@MedicalHistory", MedicalHistory);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@Email", Email);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Patient using SP_Patients_Delete
    public static bool DeletePatient(int PatientId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientId", PatientId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Patients_IsExist
    public static bool IsPatientExist(int PatientId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Patients_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientId", PatientId);

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