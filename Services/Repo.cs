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

        public IEnumerable<Patient> ReadPatients()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT per.person_id, pat.patient_id, per.first_name, per.last_name, 
                                per.dob, per.gender, addr.street_address, addr.city, addr.state, 
                                addr.postal_code, per.phone FROM((person per JOIN patient pat) JOIN address addr)
                                WHERE ((per.person_id = pat.person_id) AND (per.address_id = addr.address_id))";
            cmd.ExecuteNonQuery();

            var result = new List<Patient>();
            for (var reader = cmd.ExecuteReader(); reader.Read();)
            {
                var addr = new Address();
                var per = new Person();
                var pat = new Patient();

                per.PersonId = reader.GetInt32(0);
                pat.PatientId = reader.GetInt32(1);
                per.FirstName = reader.GetString(2);
                per.LastName = reader.GetString(3);
                per.Dob = reader.GetDateTime(4);
                per.Gender = reader.GetBoolean(5);
                //addr.AddressId = reader.GetInt32(0);
                addr.StreetAddress = reader.GetString(6);
                addr.City = reader.GetString(7);
                addr.State = reader.GetString(8);
                addr.PostalCode = reader.GetInt32(9);
                per.Phone = reader.GetString(10);

                per.Address = addr;
                pat.Person = per;
                result.Add(pat);

            }
            return result;
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
