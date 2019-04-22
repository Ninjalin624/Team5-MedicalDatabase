using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicWeb.Model;
using ClinicWeb.Services;
using ClinicWeb.Util;
using ClinicWeb.Security;

namespace ClinicWeb.Pages.Offices

{
    public class IndexModel : PageModel
    {
        public IEnumerable<Office> Offices { get; set; }

        public IActionResult OnGet()
        {
            var authService = new AuthService();
            var account = authService.GetSessionAccount(HttpContext);
            if (account == null || account.GetAccessLevel() < AccessLevel.Admin)
                return Unauthorized();

            using (var repo = new Repo(ConnectionStrings.Default))
            {
                Offices = repo.ReadOffices();
            }

            return Page();
        }
    }
}