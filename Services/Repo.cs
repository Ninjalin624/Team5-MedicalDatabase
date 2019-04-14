using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

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
            cmd.CommandText = @"SELECT address_id, street_address, state, city, postal_code 
                                FROM `address`;";
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
                                addr.postal_code, per.phone, pat.primary_office_id FROM((person per JOIN patient pat) JOIN address addr)
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
                pat.PrimaryOfficeId = reader.GetInt32(11);

                per.Address = addr;
                pat.Person = per;
                result.Add(pat);

            }
            return result;
        }

        public Patient GetPatient(int patID)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT per.person_id, pat.patient_id, per.first_name, per.last_name, 
                                per.dob, per.gender, addr.street_address, addr.city, addr.state, 
                                addr.postal_code, per.phone, pat.primary_office_id, addr.address_id FROM((person per JOIN patient pat) JOIN address addr)
                                WHERE ((@patID = pat.patient_id) AND (per.person_id = pat.person_id) AND (per.address_id = addr.address_id))";
            cmd.Parameters.Add("@patID", MySqlDbType.Int32).Value = patID;
            cmd.ExecuteNonQuery();

            var result = new Patient();
            for (var reader = cmd.ExecuteReader(); reader.Read();)
            {

                var addr = new Address();
                var per = new Person();

                result.PersonId = reader.GetInt32(0);
                result.PatientId = reader.GetInt32(1);
                per.FirstName = reader.GetString(2);
                per.LastName = reader.GetString(3);
                per.Dob = reader.GetDateTime(4);
                per.Gender = reader.GetBoolean(5);
                addr.StreetAddress = reader.GetString(6);
                addr.City = reader.GetString(7);
                addr.State = reader.GetString(8);
                addr.PostalCode = reader.GetInt32(9);
                per.Phone = reader.GetString(10);
                result.PrimaryOfficeId = reader.GetInt32(11);
                addr.AddressId = reader.GetInt32(12);
                per.Address = addr;
                result.Person = per;

            }
            return result;
        }

        public IEnumerable<Person> ReadPersons()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM `person`;";
            cmd.ExecuteNonQuery();

            var result = new List<Person>();
            for (var reader = cmd.ExecuteReader(); reader.Read();)
            {
                result.Add(Populate<Person>(reader));
            }

            return result;
        }

        private T Populate<T>(MySqlDataReader reader) where T : new()
        {
            var obj = new T();
            var objType = obj.GetType();
            var props = objType.GetProperties()
                .Where(p => p.PropertyType.IsPrimitive || p.PropertyType == typeof(string));

            foreach (var property in props) {
                object value = reader[PascalCaseToSnakeCase(property.Name)];
                var actual = Convert.ChangeType(value, property.PropertyType);
                property.SetValue(obj, actual);
            } 

            return obj;
        }

        private string PascalCaseToSnakeCase(string str)
        {
            var underscoreConnected = string.Concat(str.Select((c, i) => (i != 0 && char.IsUpper(c)) ? "_" + c.ToString() : c.ToString()));
            return underscoreConnected.ToLower();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
