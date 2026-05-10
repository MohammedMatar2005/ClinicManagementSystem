using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsAppointmentsData
{
    // =========================================
    // Get All Appointments
    // =========================================
    public static DataTable GetAllAppointments()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_GetAll", connection))
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
    // Get Appointment By Id
    // =========================================
    public static bool GetAppointmentById(
        int appointmentId,
        ref int patientId,
        ref string patientFullName, // ÃÖÝäÇ åÐÇ
        ref int doctorId,
        ref string doctorFullName,  // æÃÖÝäÇ åÐÇ
        ref DateTime appointmentDate,
        ref string reasonForVisit,
        ref int statusId,
        ref string statusName,      // íÝÖá ÌáÈ ÇÓã ÇáÍÇáÉ ÃíÖÇð (ãËáÇð: Pending)
        ref string notes,
        ref DateTime createdDate,
        ref DateTime updatedDate,
        ref bool isActive)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_Appointments_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            patientId = (int)reader["PatientId"];
                            patientFullName = (string)reader["PatientFullName"]; // ÇáÞíãÉ ãä ÇáÜ SP

                            doctorId = (int)reader["DoctorId"];
                            doctorFullName = (string)reader["DoctorFullName"];   // ÇáÞíãÉ ãä ÇáÜ SP

                            appointmentDate = (DateTime)reader["AppointmentDate"];

                            reasonForVisit = reader["ReasonForVisit"] != DBNull.Value
                                ? (string)reader["ReasonForVisit"] : string.Empty;

                            statusId = (int)reader["StatusId"];
                            statusName = (string)reader["StatusName"]; // ÅÐÇ ßäÊ ÌÇáÈåÇ Ýí ÇáÜ SP

                            notes = reader["Notes"] != DBNull.Value
                                ? (string)reader["Notes"] : string.Empty;

                            createdDate = (DateTime)reader["CreatedDate"];
                            updatedDate = (DateTime)reader["UpdatedDate"];
                            isActive = (bool)reader["IsActive"];
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
    // Insert Appointment
    // =========================================
    public static int AddNewAppointment(
      int patientId,
      int doctorId,
      DateTime appointmentDate,
      string reasonForVisit,
      int statusId,
      string notes,
      bool isActive)
    {
        int newAppointmentId = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientId", patientId);
                command.Parameters.AddWithValue("@DoctorId", doctorId);
                command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);

                command.Parameters.AddWithValue("@ReasonForVisit",
                    string.IsNullOrWhiteSpace(reasonForVisit)
                    ? DBNull.Value
                    : (object)reasonForVisit);

                command.Parameters.AddWithValue("@StatusId", statusId);

                command.Parameters.AddWithValue("@Notes",
                    string.IsNullOrWhiteSpace(notes)
                    ? DBNull.Value
                    : (object)notes);

                command.Parameters.AddWithValue("@IsActive", isActive);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        newAppointmentId = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newAppointmentId;
    }

    // =========================================
    // Update Appointment
    // =========================================
    public static bool UpdateAppointment(
        int appointmentId,
        int patientId,
        int doctorId,
        DateTime appointmentDate,
        string reasonForVisit,
        int statusId,
        string notes,
        bool isActive)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@AppointmentId",
                    appointmentId);

                command.Parameters.AddWithValue(
                    "@PatientId",
                    patientId);

                command.Parameters.AddWithValue(
                    "@DoctorId",
                    doctorId);

                command.Parameters.AddWithValue(
                    "@AppointmentDate",
                    appointmentDate);

                command.Parameters.AddWithValue(
                    "@ReasonForVisit",
                    string.IsNullOrWhiteSpace(reasonForVisit)
                    ? DBNull.Value
                    : (object)reasonForVisit);

                command.Parameters.AddWithValue(
                    "@StatusId",
                    statusId);

                command.Parameters.AddWithValue(
                    "@Notes",
                    string.IsNullOrWhiteSpace(notes)
                    ? DBNull.Value
                    : (object)notes);

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
    // Delete Appointment
    // =========================================
    public static bool DeleteAppointment(int appointmentId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@AppointmentId",
                    appointmentId);

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
    // Get Appointments By Patient
    // =========================================
    public static DataTable GetAppointmentsByPatient(int patientId)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_GetByPatient", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@PatientId",
                    patientId);

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
    // Get Appointments By Doctor
    // =========================================
    public static DataTable GetAppointmentsByDoctor(int doctorId)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_GetByDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@DoctorId",
                    doctorId);

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
    // Get Appointments By Date Range
    // =========================================
    public static DataTable GetAppointmentsByDateRange(
        DateTime startDate,
        DateTime endDate)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Appointments_GetByDateRange", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@StartDate",
                    startDate);

                command.Parameters.AddWithValue(
                    "@EndDate",
                    endDate);

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