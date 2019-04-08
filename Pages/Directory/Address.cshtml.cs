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
            var repo = new Repo();
            Addresses = repo.ReadAddresses();
        }
    }
}
