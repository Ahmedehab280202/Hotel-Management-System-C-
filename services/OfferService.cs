using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class OfferService
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Offer> GetOffers()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM offer";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Offer> dataRows = new List<Offer>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        int discountPercentage = reader.GetInt32("discountPercentage");
                        DateTime expirationDate = reader.GetDateTime("expirationDate");
                        Offer offerData = new Offer(id, discountPercentage, expirationDate);
                        dataRows.Add(offerData);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }

        public static bool CreateOffer(Offer offerData)
        {
            try
             {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO offer (discountPercentage, expirationDate) VALUES (@discountPercentage, @expirationDate)";
                    command.Parameters.AddWithValue("@discountPercentage", offerData.discountPercentage);
                    command.Parameters.AddWithValue("@expirationDate", offerData.expirationDate);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating offer: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateOffer(Offer offerData)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE offer SET discountPercentage = @discountPercentage, expirationDate = @expirationDate WHERE id = @id";
                    command.Parameters.AddWithValue("@discountPercentage", offerData.discountPercentage);
                    command.Parameters.AddWithValue("@expirationDate", offerData.expirationDate);
                    command.Parameters.AddWithValue("@id", offerData.id);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error updating offer: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteOffer(int offerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM offer WHERE id = @offerId";
                    command.Parameters.AddWithValue("@offerId", offerId);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error deleting offer: " + ex.Message);
                return false;
            }
        }
    }
}