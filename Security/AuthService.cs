using System;
using System.Security.Authentication;

using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using ClinicWeb.Model;
using ClinicWeb.Util;

namespace ClinicWeb.Security
{
    public class AuthService
    {
        public bool CheckRouteAccess(HttpContext context)
        {
            var account = GetSessionAccount(context);
            if (account == null)
            {
                return CheckRouteAccessForAnonymous(context);
            }

            if (account.Admin == 1)
            {
                return true;
            }

            return CheckRouteAccessForPatient(context);
        }

        private bool CheckRouteAccessForAnonymous(HttpContext context)
        {
            var path = context.Request.Path;
            if (path.StartsWithSegments(new PathString("/Portal")))
            {
                return false;
            }

            return true;
        }

        private bool CheckRouteAccessForPatient(HttpContext context)
        {
            return true;
        }

        public void Login(HttpContext context, string username, string password)
        {
            var account = GetAccountByUsername(username);
            if (account == null)
                throw new ArgumentException("Invalid username");

            if (account.Password != password)
                throw new AuthenticationException("Invalid password");

            context.Response.Cookies.Append("username", account.Username);
        }

        public void Logout(HttpContext context)
        {
            context.Response.Cookies.Delete("username");
        }

        public Account GetSessionAccount(HttpContext context)
        {
            var username = GetSessionUsername(context);
            if (username == null)
                return null;

            return GetAccountByUsername(username);
        }

        public string GetSessionUsername(HttpContext context)
        {
            return context.Request.Cookies["username"];
        }

        private Account GetAccountByUsername(string username)
        {
            using (var conn = new MySqlConnection(ConnectionStrings.Default))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT *
                                    FROM `account`
                                    WHERE username=@username;";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new EntityMapper().Map<Account>(reader);
                }
            }
        }
    }
}