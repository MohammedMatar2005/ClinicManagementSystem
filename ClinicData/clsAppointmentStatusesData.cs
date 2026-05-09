

using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsAppointmentStatusesData
{
    // 1. Get All AppointmentStatuses using SP_AppointmentStatuses_GetAll
    public static DataTable GetAllAppointmentStatuses()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_AppointmentStatuses_GetAll", connection))
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

    // 2. Get Info By ID using SP_AppointmentStatuses_GetByID
    //public static bool GetAppointmentStatuseInfoByID(int AppointmentStatusId, ref string Title)
    //{
    //    bool isFound = false;
    //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand("SP_AppointmentStatuses_GetByID", connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("@AppointmentStatusId", AppointmentStatusId);

    //            try
    //            {
    //                connection.Open();
    //                using (SqlDataReader reader = command.ExecuteReader())
    //                {
    //                    if (reader.Read())
    //                    {
    //                        isFound = true;
    //                        Title = (string)reader["Title"];

    //                    }
    //                }
    //            }
    //            catch (Exception ex) { isFound = false; }
    //        }
    //    }
    //    return isFound;
    //}

    //// 3. Add New AppointmentStatuse using SP_AppointmentStatuses_Insert
    //public static int AddNewAppointmentStatuse(string Title)
    //{
    //    int newID = -1;
    //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand("SP_AppointmentStatuses_Insert", connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("@Title", Title);


    //            // نفترض أن الـ SP يحتوي على Parameter مخرجات لإعادة الـ ID الجديد
    //            SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int) { Direction = ParameterDirection.Output };
    //            command.Parameters.Add(outputIdParam);

    //            try
    //            {
    //                connection.Open();
    //                command.ExecuteNonQuery();
    //                newID = (int)command.Parameters["@NewID"].Value;
    //            }
    //            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
    //        }
    //    }
    //    return newID;
    //}

    //// 4. Update AppointmentStatuse using SP_AppointmentStatuses_Update
    //public static bool UpdateAppointmentStatuse(int AppointmentStatusId, string Title)
    //{
    //    int rowsAffected = 0;
    //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand("SP_AppointmentStatuses_Update", connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("@AppointmentStatusId", AppointmentStatusId);
    //            command.Parameters.AddWithValue("@Title", Title);


    //            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
    //            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
    //        }
    //    }
    //    return (rowsAffected > 0);
    //}

    //// 5. Delete AppointmentStatuse using SP_AppointmentStatuses_Delete
    //public static bool DeleteAppointmentStatuse(int AppointmentStatusId)
    //{
    //    int rowsAffected = 0;
    //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand("SP_AppointmentStatuses_Delete", connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("@AppointmentStatusId", AppointmentStatusId);

    //            try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
    //            catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
    //        }
    //    }
    //    return (rowsAffected > 0);
    //}

    //// 6. Check Existence using SP_AppointmentStatuses_IsExist
    //public static bool IsAppointmentStatuseExist(int AppointmentStatusId)
    //{
    //    bool isFound = false;
    //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand("SP_AppointmentStatuses_IsExist", connection))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("@AppointmentStatusId", AppointmentStatusId);

    //            try
    //            {
    //                connection.Open();
    //                object result = command.ExecuteScalar();
    //                isFound = (result != null);
    //            }
    //            catch { isFound = false; }
    //        }
    //    }
    //    return isFound;
    //}
}