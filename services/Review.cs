using System;
using System.Collections.Generic;
using Hotel_Management_System.models;
using MySql.Data.MySqlClient;

using WindowsFormsApp1;

namespace Hotel_Management_System.services
{
    public class Review
    {
        private static readonly string ConnectionString = SqlService.ConnectionString;

        public static List<Review> GetReviews()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM review";
                using (MySqlDataReader reader = command.ExecuteReader());
                {
                    List<Role> dataRows = new List<Role>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string roleTitle = reader.GetString("Reviewtitle");
                        Review review = new Review(id, Customer, roleTitle, description);
                        dataRows.Add(review);
                    }
                    connection.Close();
                    return dataRows;
                }
            }
        }
        
        public static bool CreateReview(Review review)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO Review (ReviewTitle) VALUES (@ReviewTitle)";
                        command.Parameters.AddWithValue("@ReviewTitle", role.roleTitle);
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("Error creating role: " + ex.Message);
                return false;
            }
        }
        
        public static bool UpdateRole(Review review)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE role SET ReviewTitle = @ReviewTitle WHERE id = @id";
                    command.Parameters.AddWithValue("@ReviewTitle", Review.ReviewTitle);
                    command.Parameters.AddWithValue("@id", Review.id);
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
        
        public static bool DeleteRole(int ReviewID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "DELETE FROM Review WHERE id = @ReviewID";
                    command.Parameters.AddWithValue("@ReviewID", ReviewID);
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

        
    
        