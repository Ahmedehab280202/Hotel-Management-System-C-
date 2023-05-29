using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class ReservationService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;
        public static List<Reservation> GetReservations()
{
    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
    {
        connection.Open();
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM reservation";
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            List<Reservation> dataRows = new List<Reservation>();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                DateTime startDate = reader.GetDateTime("startDate");
                DateTime endDate = reader.GetDateTime("endDate");
                double price = reader.GetDouble("price");
                string status = reader.GetString("status");

                Reservation reservation = new Reservation(id, startDate, endDate, price, status);
                
               
                dataRows.Add(reservation);
            }

            connection.Close();
            return dataRows;
        }
    }
}


        public static bool CreateReservation(Reservation reservation)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO reservation (startDate, endDate, price, customerId, roomId, paymentId, status) VALUES (@startDate, @endDate, @price, @customerId, @roomId, @paymentId, @status)";
                    command.Parameters.AddWithValue("@startDate", reservation.startDate);
                    command.Parameters.AddWithValue("@endDate", reservation.endDate);
                    command.Parameters.AddWithValue("@price", reservation.price);
                    command.Parameters.AddWithValue("@status", reservation.status);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating reservation: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateReservation(Reservation reservation)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE reservation SET startDate = @startDate, endDate = @endDate, price = @price, customerId = @customerId, roomId = @roomId, paymentId = @paymentId, status = @status WHERE id = @id";
                    command.Parameters.AddWithValue("@startDate", reservation.startDate);
                    command.Parameters.AddWithValue("@endDate", reservation.endDate);
                    command.Parameters.AddWithValue("@price", reservation.price);
                    command.Parameters.AddWithValue("@status", reservation.status);
                    command.Parameters.AddWithValue("@id", reservation.id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating reservation: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteReservation(int reservationId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM reservation WHERE id = @reservationId";
                    command.Parameters.AddWithValue("@reservationId", reservationId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting reservation: " + ex.Message);
                return false;
            }
        }
    }
}
