using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsDoctorsData
{
    // =========================================
    // Get All Doctors
    // =========================================
    public static DataTable GetAllDoctors()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_GetAll", connection))
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
    // Get Doctor By Id
    // =========================================
    public static bool GetDoctorById(
        int doctorId,
        ref int userId,
        ref string specialization,
        ref string licenseNumber,
        ref decimal? salary,
        ref string officeLocation,
        ref int? experienceYears,
        ref bool isActive,
        ref DateTime createdDate)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DoctorId", doctorId);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            userId = (int)reader["UserId"];

                            specialization =
                                (string)reader["Specialization"];

                            licenseNumber =
                                (string)reader["LicenseNumber"];

                            salary =
                                reader["Salary"] != DBNull.Value
                                ? (decimal?)reader["Salary"]
                                : null;

                            officeLocation =
                                reader["OfficeLocation"] != DBNull.Value
                                ? (string)reader["OfficeLocation"]
                                : string.Empty;

                            experienceYears =
                                reader["ExperienceYears"] != DBNull.Value
                                ? (int?)reader["ExperienceYears"]
                                : null;

                            isActive = (bool)reader["IsActive"];

                            createdDate =
                                (DateTime)reader["CreatedDate"];
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
    // Insert Doctor
    // =========================================
    public static int AddNewDoctor(
        int userId,
        string specialization,
        string licenseNumber,
        decimal? salary,
        string officeLocation,
        int? experienceYears,
        bool isActive)
    {
        int newDoctorId = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);

                command.Parameters.AddWithValue(
                    "@Specialization",
                    specialization);

                command.Parameters.AddWithValue(
                    "@LicenseNumber",
                    licenseNumber);

                command.Parameters.AddWithValue(
                    "@Salary",
                    salary.HasValue
                    ? (object)salary.Value
                    : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@OfficeLocation",
                    string.IsNullOrWhiteSpace(officeLocation)
                    ? DBNull.Value
                    : (object)officeLocation);

                command.Parameters.AddWithValue(
                    "@ExperienceYears",
                    experienceYears.HasValue
                    ? (object)experienceYears.Value
                    : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@IsActive",
                    isActive);

              

                try
                {
                    connection.Open();



                    newDoctorId = (int)command.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newDoctorId;
    }

    // =========================================
    // Update Doctor
    // =========================================
    public static bool UpdateDoctor(
        int doctorId,
        int userId,
        string specialization,
        string licenseNumber,
        decimal? salary,
        string officeLocation,
        int? experienceYears,
        bool isActive)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DoctorId", doctorId);

                command.Parameters.AddWithValue("@UserId", userId);

                command.Parameters.AddWithValue(
                    "@Specialization",
                    specialization);

                command.Parameters.AddWithValue(
                    "@LicenseNumber",
                    licenseNumber);

                command.Parameters.AddWithValue(
                    "@Salary",
                    salary.HasValue
                    ? (object)salary.Value
                    : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@OfficeLocation",
                    string.IsNullOrWhiteSpace(officeLocation)
                    ? DBNull.Value
                    : (object)officeLocation);

                command.Parameters.AddWithValue(
                    "@ExperienceYears",
                    experienceYears.HasValue
                    ? (object)experienceYears.Value
                    : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@IsActive",
                    isActive);

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
    // Delete Doctor
    // =========================================
    public static bool DeleteDoctor(int doctorId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DoctorId", doctorId);

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
    // Is Doctor Exists By UserId
    // =========================================
    public static bool IsDoctorExistByUserId(int userId)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_IsExist_ByUserId", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);

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

    // =========================================
    // Is Doctor Exists By License Number
    // =========================================
    public static bool IsDoctorExistByLicenseNumber(
        string licenseNumber)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Doctors_IsExist_ByLicenseNumber", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@LicenseNumber",
                    licenseNumber);

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