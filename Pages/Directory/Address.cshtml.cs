using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Model;
using ClinicWeb.Services;

namespace ClinicWeb.Pages.Directory
{
    public class AddressModel : PageModel
    {
        public IEnumerable<Address> Addresses { get; set; }

        public void OnGet()
        {
            var connStr = "Database=clinicdb; Data Source=team5med-db.mysql.database.azure.com; User Id=Team5DBAdmin@team5med-db; Password=Clinic123";
            using (var repo = new Repo(connStr))
            {
                Addresses = repo.ReadAddresses();
            }
        }
    }
}
