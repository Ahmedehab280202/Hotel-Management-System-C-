using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class RoomService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Room> GetRooms()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM room";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Room> dataRows = new List<Room>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        int roomNum = reader.GetInt32("roomNum");
                        int floor = reader.GetInt32("floor");
                        double price = reader.GetDouble("price");
                        string status = reader.GetString("status");

                        Room room = new Room(id, roomNum, floor, price, status);
                        dataRows.Add(room);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }

        public static bool CreateRoom(Room room)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO room (roomNum, floor, price, status) VALUES (@roomNum, @floor, @price, @status)";
                    command.Parameters.AddWithValue("@roomNum", room.roomNum);
                    command.Parameters.AddWithValue("@floor", room.floor);
                    command.Parameters.AddWithValue("@price", room.price);
                    command.Parameters.AddWithValue("@status", room.status);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating room: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateRoom(Room room)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE room SET roomNum = @roomNum, floor = @floor, price = @price, status = @status WHERE id = @id";
                    command.Parameters.AddWithValue("@roomNum", room.roomNum);
                    command.Parameters.AddWithValue("@floor", room.floor);
                    command.Parameters.AddWithValue("@price", room.price);
                    command.Parameters.AddWithValue("@status", room.status);
                    command.Parameters.AddWithValue("@id", room.id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating room: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteRoom(int roomId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM room WHERE id = @roomId";
                    command.Parameters.AddWithValue("@roomId", roomId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting room: " + ex.Message);
                return false;
            }
        }
    }
}

