using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Resources;
using ClinicWeb.Services;
using ServiceStack.Text;

namespace ClinicWeb.Pages.Portal
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ReportsModel : PageModel
    {
        public IActionResult OnPost(string dataset, int count)
        {
            using (var repo = new Repo(ConnectionStrings.Default))
            {
                if (dataset == "address")
                {
                    var addresses = repo.ReadAddresses();
                    string result = CsvSerializer.SerializeToCsv(addresses);

                    return File(Encoding.UTF8.GetBytes(result), "text/CSV", "report.csv");
                }
            }

            return null;
        }
    }
}
