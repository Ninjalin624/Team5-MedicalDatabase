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

        public Repo()
        {
            connection = new MySqlConnection("Database=clinicdb; Data Source=team5med-db.mysql.database.azure.com; User Id=Team5DBAdmin@team5med-db; Password=Clinic123");
            connection.Open();
        }

        public IEnumerable<Address> ReadAddresses()
        {
            // var cmd = connection.CreateCommand();
            // cmd.CommandText = @"SELECT * FROM `address`";
            // cmd.ExecuteNonQuery();
            

            var result = new List<Address>();

            var fakeAddr = new Address();
            fakeAddr.AddressId = 0;
            fakeAddr.City = "Houston";
            fakeAddr.PostalCode = 77573;
            fakeAddr.State = "Texas";
            fakeAddr.StreetAddress = "471 Looneyville Street";
            result.Add(fakeAddr);

            return result;
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
