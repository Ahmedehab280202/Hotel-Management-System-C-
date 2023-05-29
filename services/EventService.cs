using System;
using System.Collections.Generic;
using Hotel_Management_System.models;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class EventService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Event> GetEvents()
         {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM event";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Event> dataRows = new List<Event>();
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        DateTime date = reader.GetDateTime("date");
                        int durationHrs = reader.GetInt32("durationHrs");
                        string hostname = reader.GetString("hostname");
                        Event eventData = new Event(name, date, durationHrs, hostname);
                        dataRows.Add(eventData);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }

        public static bool CreateEvent(Event eventData)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO event (name, date, durationHrs, host) VALUES (@name, @date, @durationHrs, @host)";
                    command.Parameters.AddWithValue("@name", eventData.name);
                    command.Parameters.AddWithValue("@date", eventData.date);
                    command.Parameters.AddWithValue("@durationHrs", eventData.durationHrs);
                    command.Parameters.AddWithValue("@hostname", eventData.hostname);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating event: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateEvent(Event eventData)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE event SET name = @name, date = @date, durationHrs = @durationHrs, hostname = @hostname WHERE id = @id";
                    command.Parameters.AddWithValue("@name", eventData.name);
                    command.Parameters.AddWithValue("@date", eventData.date);
                    command.Parameters.AddWithValue("@durationHrs", eventData.durationHrs);
                    command.Parameters.AddWithValue("@hostname", eventData.hostname);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating event: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteEvent(int eventId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM event WHERE id = @eventId";
                    command.Parameters.AddWithValue("@eventId", eventId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting event: " + ex.Message);
                return false;
            }
        }
    }
}