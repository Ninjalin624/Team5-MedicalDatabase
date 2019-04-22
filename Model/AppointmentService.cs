using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using ClinicWeb.Util;

namespace ClinicWeb.Model
{
    public class AppointmentService
    {
        public IEnumerable<Appointment> FindAppointmentsWithPerson(int personId, int count)
        {
            using (var conn = new MySqlConnection(ConnectionStrings.Default))
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT *
                                    FROM `appointment`
                                    WHERE (
                                        EXISTS (
                                            SELECT doctor_id
                                            FROM `doctor`
                                            WHERE person_id = @personId
                                        )
                                        OR EXISTS (
                                            SELECT patient_id
                                            FROM `patient`
                                            WHERE person_id = @personId
                                        )
                                    )
                                    ORDER BY start_time DESC
                                    LIMIT @count;";
                cmd.Parameters.AddWithValue("@personId", personId);
                cmd.Parameters.AddWithValue("@count", count);

                using (var reader = cmd.ExecuteReader())
                {
                    var mapper = new EntityMapper();
                    return mapper.MapList<Appointment>(reader);
                }
            }
        }
    }
}
