using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Model;
using ClinicWeb.Services;
using ClinicWeb.Util;

namespace ClinicWeb.Pages.Directory
{
    public class AddressModel : PageModel
    {
        public IEnumerable<Address> Addresses { get; set; }

        public void OnGet()
        {
            using (var repo = new Repo(ConnectionStrings.Default))
            {
                Addresses = repo.ReadAddresses();
            }
        }
    }
}
