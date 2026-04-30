
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsAppointmentsData
{
    // 1. Get All Appointments using SP_Appointments_GetAll
    public static DataTable GetAllAppointments()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_Appointments_GetAll", connection))
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

    // 2. Get Info By ID using SP_Appointments_GetByID
    public static bool GetAppointmentInfoByID(int AppointmentId, ref int PatientId, ref int DoctorId, ref DateTime AppointmentDate, ref string ReasonForVisit, ref int StatusId, ref string Notes, ref DateTime CreatedDate, ref DateTime UpdatedDate, ref bool IsActive)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Appointments_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PatientId = (int)reader["PatientId"];
                            DoctorId = (int)reader["DoctorId"];
                            AppointmentDate = (DateTime)reader["AppointmentDate"];
                            ReasonForVisit = (string)reader["ReasonForVisit"];
                            StatusId = (int)reader["StatusId"];
                            Notes = (string)reader["Notes"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            UpdatedDate = (DateTime)reader["UpdatedDate"];
                            IsActive = (bool)reader["IsActive"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New Appointment using SP_Appointments_Insert
    public static int AddNewAppointment(int PatientId, int DoctorId, DateTime AppointmentDate, string ReasonForVisit, int StatusId, string Notes, DateTime CreatedDate, DateTime UpdatedDate, bool IsActive)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Appointments_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@DoctorId", DoctorId);
                command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                command.Parameters.AddWithValue("@ReasonForVisit", ReasonForVisit);
                command.Parameters.AddWithValue("@StatusId", StatusId);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", UpdatedDate);
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

    // 4. Update Appointment using SP_Appointments_Update
    public static bool UpdateAppointment(int AppointmentId, int PatientId, int DoctorId, DateTime AppointmentDate, string ReasonForVisit, int StatusId, string Notes, DateTime CreatedDate, DateTime UpdatedDate, bool IsActive)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Appointments_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@DoctorId", DoctorId);
                command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                command.Parameters.AddWithValue("@ReasonForVisit", ReasonForVisit);
                command.Parameters.AddWithValue("@StatusId", StatusId);
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", UpdatedDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Appointment using SP_Appointments_Delete
    public static bool DeleteAppointment(int AppointmentId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Appointments_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Appointments_IsExist
    public static bool IsAppointmentExist(int AppointmentId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Appointments_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentId", AppointmentId);

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