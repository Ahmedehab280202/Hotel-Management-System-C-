using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class PaymentService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Payment> GetPayments()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
             {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM payment";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Payment> dataRows = new List<Payment>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        string description = reader.GetString("description");
                        Payment payment = new Payment(id, name, description);
                        dataRows.Add(payment);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }

        public static bool CreatePayment(Payment payment)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO payment (name, description) VALUES (@name, @description)";
                    command.Parameters.AddWithValue("@name", payment.name);
                    command.Parameters.AddWithValue("@description", payment.description);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating payment: " + ex.Message);
                return false;
            }
        }

        public static bool UpdatePayment(Payment payment)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE payment SET name = @name, description = @description WHERE id = @id";
                    command.Parameters.AddWithValue("@name", payment.name);
                    command.Parameters.AddWithValue("@description", payment.description);
                    command.Parameters.AddWithValue("@id", payment.id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating payment: " + ex.Message);
                return false;
            }
        }

        public static bool DeletePayment(int paymentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM payment WHERE id = @paymentId";
                    command.Parameters.AddWithValue("@paymentId", paymentId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting payment: " + ex.Message);
                return false;
            }
        }
    }
}