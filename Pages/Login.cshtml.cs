using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using ClinicWeb.Resources;
using ClinicWeb.Services;

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

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var account = new AuthService().GetUserByUsername(Username);
            if (account == null || account.Password != Password)
            {
                ModelState.AddModelError("Password", "Invalid username or password");
                return Page();
            }

            Response.Cookies.Append("username", Username);
            return Redirect("/");
        }
    }
}
