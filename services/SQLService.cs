using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public static class SqlService
    {
        private static readonly string Server = "localhost";
        private static readonly string Port = "3306";
        private static readonly string Db = "hotel-system-c#";
        private static readonly string Pass = "admin";
        
        public static readonly string ConnectionString = $"Server={Server};Port={Port};Database={Db};Uid=root;Pwd={Pass};";
    }
}