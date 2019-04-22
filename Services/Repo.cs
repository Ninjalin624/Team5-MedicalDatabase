using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(Populate<Address>(reader));
                }
            }

            return result;
        }

        public Diagnosis GetDiagnosis(int id)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM (diagnosis d JOIN condition_t c)
                                WHERE ((@DiagnosisID = d.diagnosis_id) AND (d.condition_id = c.condition_id))";
            cmd.Parameters.Add("@DiagnosisID", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
            var result = new Diagnosis();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var condition = Populate<Condition>(reader);
                    var diagnosis = Populate<Diagnosis>(reader);
                    diagnosis.Condition = condition;
                    result = diagnosis;
                }
            }
            return result;
        }

        public string ReadPatientsCSV(int count = 5)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT per.person_id, pat.patient_id, per.first_name, per.last_name, 
                                per.dob, per.gender, addr.street_address, addr.city, addr.state, 
                                addr.postal_code, per.phone, pat.primary_office_id FROM((person per JOIN patient pat) JOIN address addr)
                                WHERE ((per.person_id = pat.person_id) AND (per.address_id = addr.address_id))";
            cmd.ExecuteNonQuery();

            var sb = new StringBuilder();
            using (var reader = cmd.ExecuteReader())
            {
                var columnNames = Enumerable.Range(0, reader.FieldCount)
                        .Select(reader.GetName)
                        .ToList();
                sb.Append(string.Join(",", columnNames));
                sb.AppendLine();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string value = reader[i].ToString();
                        if (value.Contains(","))
                            value = "\"" + value + "\"";

                        sb.Append(value.Replace(Environment.NewLine, " ") + ",");
                    }
                    sb.Length--; // Remove the last comma
                    sb.AppendLine();
                }
            }

            return sb.ToString();
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
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var per = Populate<Person>(reader);
                    per.Address = Populate<Address>(reader);
                    var pat = Populate<Patient>(reader);
                    pat.Person = per;

                    result.Add(pat);
                }
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
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
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
            }

            return result;
        }

        public IEnumerable<Person> ReadPersons()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM `person`;";
            cmd.ExecuteNonQuery();

            var result = new List<Person>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(Populate<Person>(reader));
                }
            }

            return result;
        }

        public IEnumerable<Office> ReadOffices()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM (address a JOIN office o)
                                WHERE (a.address_id = o.address_id)";
            cmd.ExecuteNonQuery();

            var result = new List<Office>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var office = Populate<Office>(reader);
                    office.Address = Populate<Address>(reader);
                    result.Add(office);
                }
            }

            return result;
        }

        public IEnumerable<Doctor> ReadDoctors()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT per.person_id, doc.doctor_id, doc.specialization_id, per.first_name, per.last_name, 
                                per.dob, per.gender, addr.street_address, addr.city, addr.state, 
                                addr.postal_code, per.phone FROM((person per JOIN doctor doc) JOIN address addr)
                                WHERE ((per.person_id = doc.person_id) AND (per.address_id = addr.address_id))";
            cmd.ExecuteNonQuery();

            var result = new List<Doctor>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var per = Populate<Person>(reader);
                    per.Address = Populate<Address>(reader);
                    var doc = Populate<Doctor>(reader);
                    doc.Person = per;

                    result.Add(doc);
                }
            }

            return result;
        }

        public Doctor GetDoctor(int docID)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT per.person_id, doc.doctor_id, per.first_name, per.last_name, 
                                per.dob, per.gender, addr.street_address, addr.city, addr.state, 
                                addr.postal_code, per.phone, doc.specialization_id, addr.address_id FROM((person per JOIN doctor doc) JOIN address addr)
                                WHERE ((@docID = doc.doctor_id) AND (per.person_id = doc.person_id) AND (per.address_id = addr.address_id))";
            cmd.Parameters.Add("@docID", MySqlDbType.Int32).Value = docID;
            cmd.ExecuteNonQuery();

            var result = new Doctor();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var addr = new Address();
                    var per = new Person();

                    result.PersonId = reader.GetInt32(0);
                    result.DoctorId = reader.GetInt32(1);
                    per.FirstName = reader.GetString(2);
                    per.LastName = reader.GetString(3);
                    per.Dob = reader.GetDateTime(4);
                    per.Gender = reader.GetBoolean(5);
                    addr.StreetAddress = reader.GetString(6);
                    addr.City = reader.GetString(7);
                    addr.State = reader.GetString(8);
                    addr.PostalCode = reader.GetInt32(9);
                    per.Phone = reader.GetString(10);
                    result.SpecializationId = reader.GetInt32(11);
                    addr.AddressId = reader.GetInt32(12);
                    per.Address = addr;
                    result.Person = per;
                }
            }

            return result;
        }

        public Office GetOffice(int officeID)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM (address a JOIN office o)
                                WHERE ((@OfficeID = o.office_id) AND (a.address_id = o.address_id))";
            cmd.Parameters.Add("@OfficeID", MySqlDbType.Int32).Value = officeID;
            cmd.ExecuteNonQuery();
            var result = new Office();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var office = Populate<Office>(reader);
                    office.Address = Populate<Address>(reader);
                    result = office;
                }
            }
            return result;
        }

        /*public IEnumerable<Appointment> ReadAppointments()
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM (appointment a JOIN (patient p JOIN person per) JOIN (doctor doc JOIN person pers) JOIN (office o JOIN address addr))
                                WHERE (a.patient_id = p.patient_id) AND (p.person_id = per.person_id) AND (a.doctor_id = doc.doctor_id)
                                        AND (doc.person_id = pers.person_id) AND (a.office_id = o.office_id) AND (o.address_id = addr.address_id)";
            cmd.ExecuteNonQuery();
            var result = new List<Appointment>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                   var patient = Populate<Patient>(reader);
                    var doc = Populate<Doctor>(reader);
                    var office = Populate<Office>(reader);
                    var app = Populate<Appointment>(reader);
                    app.Doctor = doc;
                   app.Patient = patient;
                    app.Office = office;

                    result.Add(app);
                }
            }
            return result;


        }*/
        public IEnumerable<Diagnosis> ReadDiagnosis(int id)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM (diagnosis d JOIN condition_t c) WHERE ((@PatientID = d.patient_id) AND (d.condition_id = c.condition_id))";
            cmd.Parameters.Add("@PatientID", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();

            var result = new List<Diagnosis>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var condition = Populate<Condition>(reader);
                    var diagnosis = Populate<Diagnosis>(reader);
                    diagnosis.Condition = condition;
                    result.Add(diagnosis);
                }
            }

            return result;
        }

        private T Populate<T>(MySqlDataReader reader) where T : new()
        {
            var obj = new T();
            var objType = obj.GetType();
            var colNames = Enumerable.Range(0, reader.FieldCount)
                .Select(i => reader.GetName(i));

            foreach (var property in objType.GetProperties())
            {
                var colName = PascalCaseToSnakeCase(property.Name);
                if (!colNames.Contains(colName)) continue;

                var value = reader[colName];
                var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                var actual = (value == null) ? null : Convert.ChangeType(value, type);
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
