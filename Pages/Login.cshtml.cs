using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using ClinicWeb.Resources;

namespace ClinicWeb.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            using (var conn = new MySqlConnection(ConnectionStrings.Default)) {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT *
                                    FROM `account`
                                    WHERE username=@username AND password=@password;";
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader()) {
                    if (!reader.Read()) {
                        ModelState.AddModelError("Password", "Invalid username or password");
                        return Page();
                    }

                    Response.Cookies.Append("username", Username);

                    return Redirect("/");
                }
            }
        }
    }
}