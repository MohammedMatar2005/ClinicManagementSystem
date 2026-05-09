using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPatientsData
{
    // =========================================
    // Get All Patients
    // =========================================
    public static DataTable GetAllPatients()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_GetAll", connection))
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

    // =========================================
    // Get Patient By ID
    // =========================================
    public static bool GetPatientById(
        int patientId,
        ref int personId,
        ref string emergencyContact,
        ref string emergencyPhone,
        ref string bloodType,
        ref string allergies,
        ref string medicalHistory,
        ref bool isActive,
        ref DateTime createdDate)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientId", patientId);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            personId = (int)reader["PersonId"];

                            emergencyContact =
                                reader["EmergencyContact"] != DBNull.Value
                                ? (string)reader["EmergencyContact"]
                                : string.Empty;

                            emergencyPhone =
                                reader["EmergencyPhone"] != DBNull.Value
                                ? (string)reader["EmergencyPhone"]
                                : string.Empty;

                            bloodType =
                                reader["BloodType"] != DBNull.Value
                                ? (string)reader["BloodType"]
                                : string.Empty;

                            allergies =
                                reader["Allergies"] != DBNull.Value
                                ? (string)reader["Allergies"]
                                : string.Empty;

                            medicalHistory =
                                reader["MedicalHistory"] != DBNull.Value
                                ? (string)reader["MedicalHistory"]
                                : string.Empty;

                            isActive = (bool)reader["IsActive"];

                            createdDate = (DateTime)reader["CreatedDate"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);

                    isFound = false;
                }
            }
        }

        return isFound;
    }

    // =========================================
    // Insert Patient
    // =========================================
    public static int AddNewPatient(
        int personId,
        string emergencyContact,
        string emergencyPhone,
        string bloodType,
        string allergies,
        string medicalHistory,
        bool isActive)
    {
        int newPatientId = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);

                command.Parameters.AddWithValue(
                    "@EmergencyContact",
                    string.IsNullOrWhiteSpace(emergencyContact)
                    ? DBNull.Value
                    : (object)emergencyContact);

                command.Parameters.AddWithValue(
                    "@EmergencyPhone",
                    string.IsNullOrWhiteSpace(emergencyPhone)
                    ? DBNull.Value
                    : (object)emergencyPhone);

                command.Parameters.AddWithValue(
                    "@BloodType",
                    string.IsNullOrWhiteSpace(bloodType)
                    ? DBNull.Value
                    : (object)bloodType);

                command.Parameters.AddWithValue(
                    "@Allergies",
                    string.IsNullOrWhiteSpace(allergies)
                    ? DBNull.Value
                    : (object)allergies);

                command.Parameters.AddWithValue(
                    "@MedicalHistory",
                    string.IsNullOrWhiteSpace(medicalHistory)
                    ? DBNull.Value
                    : (object)medicalHistory);

                command.Parameters.AddWithValue("@IsActive", isActive);

             

                try
                {
                    connection.Open();

                   

                    newPatientId = (int)command.ExecuteScalar();
                      
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newPatientId;
    }

    // =========================================
    // Update Patient
    // =========================================
    public static bool UpdatePatient(
        int patientId,
        int personId,
        string emergencyContact,
        string emergencyPhone,
        string bloodType,
        string allergies,
        string medicalHistory,
        bool isActive)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientId", patientId);

                command.Parameters.AddWithValue("@PersonId", personId);

                command.Parameters.AddWithValue(
                    "@EmergencyContact",
                    string.IsNullOrWhiteSpace(emergencyContact)
                    ? DBNull.Value
                    : (object)emergencyContact);

                command.Parameters.AddWithValue(
                    "@EmergencyPhone",
                    string.IsNullOrWhiteSpace(emergencyPhone)
                    ? DBNull.Value
                    : (object)emergencyPhone);

                command.Parameters.AddWithValue(
                    "@BloodType",
                    string.IsNullOrWhiteSpace(bloodType)
                    ? DBNull.Value
                    : (object)bloodType);

                command.Parameters.AddWithValue(
                    "@Allergies",
                    string.IsNullOrWhiteSpace(allergies)
                    ? DBNull.Value
                    : (object)allergies);

                command.Parameters.AddWithValue(
                    "@MedicalHistory",
                    string.IsNullOrWhiteSpace(medicalHistory)
                    ? DBNull.Value
                    : (object)medicalHistory);

                command.Parameters.AddWithValue("@IsActive", isActive);

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

    // =========================================
    // Soft Delete Patient
    // =========================================
    public static bool DeletePatient(int patientId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientId", patientId);

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

    // =========================================
    // Is Patient Exists By PersonId
    // =========================================
    public static bool IsPatientExistByPersonId(int personId)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Patients_IsExist_ByPersonId", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    isFound = (result != null);
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);

                    isFound = false;
                }
            }
        }

        return isFound;
    }
}