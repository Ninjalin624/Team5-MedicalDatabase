using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Util;
using ClinicWeb.Security;
using ClinicWeb.Services;
using ServiceStack.Text;

namespace ClinicWeb.Pages.Portal
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ReportsModel : PageModel
    {
        public IActionResult OnGet()
        {
            var authService = new AuthService();
            var account = authService.GetSessionAccount(HttpContext);
            if (account == null || account.GetAccessLevel() < AccessLevel.Admin)
                return Redirect("/Login");

            return Page();
        }

        public IActionResult OnPost(string dataset, int count)
        {
            if (dataset == "address")
            {
                using (var repo = new Repo(ConnectionStrings.Default))
                {
                    var addresses = repo.ReadAddresses();
                    string result = CsvSerializer.SerializeToCsv(addresses);

                    return File(Encoding.UTF8.GetBytes(result), "text/CSV", "report.csv");
                }
            }
            else if (dataset == "patient")
            {
                using (var repo = new Repo(ConnectionStrings.Default))
                {
                    return File(Encoding.UTF8.GetBytes(repo.ReadPatientsCSV(5)), "text/CSV", "report.csv");
                }
            }

            return null;
        }
    }
}
