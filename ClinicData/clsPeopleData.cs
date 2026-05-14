using ClinicDataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsPeopleData
{
    // ==============================
    // Get All
    // ==============================

    public static DataTable GetAllPeople()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_People_GetAll", connection))
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

    // ==============================
    // Get By ID
    // ==============================

    public static bool GetPersonById(
        int personId,
        ref string firstName,
        ref string secondName,
        ref string thirdName,
        ref string lastName,
        ref DateTime dateOfBirth,
        ref bool gender,
        ref string phone,
        ref string email,
        ref string address,
        ref string nationalNumber
        )
    {
        bool isFound = false;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_People_GetById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            firstName = (string)reader["FirstName"];

                            secondName =
                                reader["SecondName"] != DBNull.Value
                                ? (string)reader["SecondName"]
                                : string.Empty;

                            thirdName =
                                reader["ThirdName"] != DBNull.Value
                                ? (string)reader["ThirdName"]
                                : string.Empty;

                            lastName = (string)reader["LastName"];

                            dateOfBirth =
                                (DateTime)reader["DateOfBirth"];

                            gender =
                                Convert.ToBoolean(reader["Gender"]);

                            phone =
                                reader["Phone"] != DBNull.Value
                                ? (string)reader["Phone"]
                                : string.Empty;

                            email =
                                reader["Email"] != DBNull.Value
                                ? (string)reader["Email"]
                                : string.Empty;

                            address =
                                reader["Address"] != DBNull.Value
                                ? (string)reader["Address"]
                                : string.Empty;

                            nationalNumber = (string)reader["NationalNumber"];
                               

                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;

                    EventLogger.Log(ex.ToString(),
                        System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return isFound;
    }
    // ==============================
    // Insert
    // ==============================

    public static int AddNewPerson(
      string firstName, string secondName, string thirdName, string lastName,
      DateTime dateOfBirth, bool gender, string phone, string email,
      string address, string nationalNumber)
    {
        int newPersonId = -1;

        using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("Sp_People_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@SecondName", string.IsNullOrWhiteSpace(secondName) ? DBNull.Value : (object)secondName);
                command.Parameters.AddWithValue("@ThirdName", string.IsNullOrWhiteSpace(thirdName) ? DBNull.Value : (object)thirdName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : (object)email);
                command.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(address) ? DBNull.Value : (object)address);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        newPersonId = id;
                    }
                }
                catch (Exception ex)
                {
                    EventLogger.Log(ex.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
            }
        }

        return newPersonId;
    }

    // ==============================
    // Update
    // ==============================

    public static bool UpdatePerson(
        int personId,
        string firstName,
        string secondName,
        string thirdName,
        string lastName,
        DateTime dateOfBirth,
        bool gender,
        string phone,
        string email,
        string address,
        string nationalNumber)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_People_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);
                command.Parameters.AddWithValue("@FirstName", firstName);

                command.Parameters.AddWithValue("@SecondName",
                    string.IsNullOrWhiteSpace(secondName)
                    ? DBNull.Value
                    : (object)secondName);

                command.Parameters.AddWithValue("@ThirdName",
                    string.IsNullOrWhiteSpace(thirdName)
                    ? DBNull.Value
                    : (object)thirdName);

                command.Parameters.AddWithValue("@LastName", lastName);

                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                command.Parameters.AddWithValue("@Gender", gender);

                command.Parameters.AddWithValue("@Phone", phone);

                command.Parameters.AddWithValue("@NationalNumber", nationalNumber); 

                command.Parameters.AddWithValue("@Email",
                    string.IsNullOrWhiteSpace(email)
                    ? DBNull.Value
                    : (object)email);

                command.Parameters.AddWithValue("@Address",
                    string.IsNullOrWhiteSpace(address)
                    ? DBNull.Value
                    : (object)address);



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

        return rowsAffected > 0;
    }

    // ==============================
    // Delete
    // ==============================

    public static bool DeletePerson(int personId)
    {
        int rowsAffected = 0;

        using (SqlConnection connection =
               new SqlConnection(DataAccessSettings.ConnectionString))
        {
            using (SqlCommand command =
                   new SqlCommand("Sp_People_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonId", personId);

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

        return rowsAffected > 0;
    }
}