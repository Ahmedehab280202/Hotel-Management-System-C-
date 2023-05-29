using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class RoleService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Role> GetRoles()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM role";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Role> dataRows = new List<Role>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string roleTitle = reader.GetString("roleTitle");
                        Role role = new Role(id, roleTitle);
                        dataRows.Add(role);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }
        public static bool CreateRole(Role role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO role (roleTitle) VALUES (@roleTitle)";
                    command.Parameters.AddWithValue("@roleTitle", role.roleTitle);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating role: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateRole(Role role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE role SET roleTitle = @roleTitle WHERE id = @id";
                    command.Parameters.AddWithValue("@roleTitle", role.roleTitle);
                    command.Parameters.AddWithValue("@id", role.id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating role: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteRole(int roleId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM role WHERE id = @roleId";
                    command.Parameters.AddWithValue("@roleId", roleId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting role: " + ex.Message);
                return false;
            }
        }
    }
}