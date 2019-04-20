using MySql.Data.MySqlClient;
using ClinicWeb.Model;
using ClinicWeb.Resources;
using ClinicWeb.Util;

namespace ClinicWeb.Services
{
    public class AuthService
    {
        public Account GetUserByUsername(string username)
        {
            using (var conn = new MySqlConnection(ConnectionStrings.Default)) {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT *
                                    FROM `account`
                                    WHERE username=@username;";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader()) {
                    if (!reader.Read()) {
                        return null;
                    }

                    return new EntityMapper().Map<Account>(reader);
                }
            }
        }
    }
}