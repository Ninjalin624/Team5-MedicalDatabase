using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using MySql.Data.MySqlClient;
using ClinicWeb.Model;

namespace ClinicWeb.Services
{
    public class Repo : IDisposable
    {
        private MySqlConnection connection;

        public Repo(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public IEnumerable<Address> ReadAddresses()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT address_id, street_address, state, city, postal_code FROM `address`";
            cmd.ExecuteNonQuery();

            var result = new List<Address>();
            for (var reader = cmd.ExecuteReader(); reader.Read();)
            {
                var addr = new Address();
                addr.AddressId = reader.GetInt32(0);
                addr.StreetAddress = reader.GetString(1);
                addr.State = reader.GetString(2);
                addr.City = reader.GetString(3);
                addr.PostalCode = reader.GetInt32(4);
                result.Add(addr);
            }

            return result;
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
