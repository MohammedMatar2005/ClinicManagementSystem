using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsUsersData
{
    // =========================================================
    // Get All Users
    // =========================================================
    public static DataTable GetAllUsers()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_GetAll", connection))
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
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return dt;
    }

    // =========================================================
    // Get User By ID
    // =========================================================
    public static bool GetUserById(
        int userId,
        ref int personId,
        ref string FullName,
        ref string username,
        ref string passwordHash,
        ref int roleId,
        ref bool isActive,
        ref DateTime createdDate,
        ref DateTime? lastLoginDate)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            personId = (int)reader["PersonId"];
                            FullName = (string)reader["FullName"];
                            username = (string)reader["Username"];
                            passwordHash = (string)reader["PasswordHash"];
                            roleId = (int)reader["RoleId"];
                            isActive = (bool)reader["IsActive"];
                            createdDate = (DateTime)reader["CreatedDate"];

                            if (reader["LastLoginDate"] != DBNull.Value)
                                lastLoginDate = (DateTime)reader["LastLoginDate"];
                            else
                                lastLoginDate = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);

                    isFound = false;
                }
            }
        }

        return isFound;
    }

    // =========================================================
    // Insert User
    // =========================================================
    public static int AddNewUser(
        int personId,
        string username,
        string passwordHash,
        int roleId,
        bool isActive)
    {
        int newUserId = -1;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@RoleId", roleId);
                command.Parameters.AddWithValue("@IsActive", isActive);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null &&
                        int.TryParse(result.ToString(), out int insertedId))
                    {
                        newUserId = insertedId;
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newUserId;
    }

    // =========================================================
    // Update User
    // =========================================================
    public static bool UpdateUser(
        int userId,
        int personId,
        string username,
        string passwordHash,
        int roleId,
        bool isActive,
        DateTime? lastLoginDate)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PersonId", personId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@RoleId", roleId);
                command.Parameters.AddWithValue("@IsActive", isActive);

                if (lastLoginDate.HasValue)
                    command.Parameters.AddWithValue(
                        "@LastLoginDate",
                        lastLoginDate.Value);
                else
                    command.Parameters.AddWithValue(
                        "@LastLoginDate",
                        DBNull.Value);

                try
                {
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return (rowsAffected > 0);
    }

    // =========================================================
    // Soft Delete User
    // =========================================================
    public static bool DeleteUser(int userId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return (rowsAffected > 0);
    }

    // =========================================================
    // Check If Person Already Has User
    // =========================================================
    public static bool IsUserExistByPersonId(int personId)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_IsExist_ByPersonId", connection))
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
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);

                    isFound = false;
                }
            }
        }

        return isFound;
    }

    // =========================================================
    // Login
    // =========================================================
    public static bool Login(
        string username,
        string passwordHash,
        ref int userId,
        ref int personId,
        ref int roleId,
        ref bool isActive)
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_Users_Login", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            userId = (int)reader["UserId"];
                            personId = (int)reader["PersonId"];
                            roleId = (int)reader["RoleId"];
                            isActive = (bool)reader["IsActive"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(
                        ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);

                    isFound = false;
                }
            }
        }

        return isFound;
    }
}