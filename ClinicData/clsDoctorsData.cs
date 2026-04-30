
using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;


public class clsDoctorsData
{
    // 1. Get All Doctors using SP_Doctors_GetAll
    public static DataTable GetAllDoctors()
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_GetAll", connection))
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

    // 2. Get Info By ID using SP_Doctors_GetByID
    public static bool GetDoctorInfoByID(int DoctorId, ref int UserId, ref string Specialization, ref string LicenseNumber, ref decimal Salary, ref string OfficeLocation, ref int ExperienceYears, ref bool IsActive, ref DateTime CreatedDate)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorId", DoctorId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            UserId = (int)reader["UserId"];
                            Specialization = (string)reader["Specialization"];
                            LicenseNumber = (string)reader["LicenseNumber"];
                            Salary = (decimal)reader["Salary"];
                            OfficeLocation = (string)reader["OfficeLocation"];
                            ExperienceYears = (int)reader["ExperienceYears"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedDate = (DateTime)reader["CreatedDate"];

                        }
                    }
                }
                catch (Exception ex) { isFound = false; }
            }
        }
        return isFound;
    }

    // 3. Add New Doctor using SP_Doctors_Insert
    public static int AddNewDoctor(int UserId, string Specialization, string LicenseNumber, decimal Salary, string OfficeLocation, int ExperienceYears, bool IsActive, DateTime CreatedDate)
    {
        int newID = -1;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@Specialization", Specialization);
                command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@OfficeLocation", OfficeLocation);
                command.Parameters.AddWithValue("@ExperienceYears", ExperienceYears);
                command.Parameters.AddWithValue("@IsActive", IsActive);
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

    // 4. Update Doctor using SP_Doctors_Update
    public static bool UpdateDoctor(int DoctorId, int UserId, string Specialization, string LicenseNumber, decimal Salary, string OfficeLocation, int ExperienceYears, bool IsActive, DateTime CreatedDate)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorId", DoctorId);
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@Specialization", Specialization);
                command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                command.Parameters.AddWithValue("@Salary", Salary);
                command.Parameters.AddWithValue("@OfficeLocation", OfficeLocation);
                command.Parameters.AddWithValue("@ExperienceYears", ExperienceYears);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 5. Delete Doctor using SP_Doctors_Delete
    public static bool DeleteDoctor(int DoctorId)
    {
        int rowsAffected = 0;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorId", DoctorId);

                try { connection.Open(); rowsAffected = command.ExecuteNonQuery(); }
                catch (Exception ex) { EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error); }
            }
        }
        return (rowsAffected > 0);
    }

    // 6. Check Existence using SP_Doctors_IsExist
    public static bool IsDoctorExist(int DoctorId)
    {
        bool isFound = false;
        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_Doctors_IsExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorId", DoctorId);

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