using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Model;

namespace ClinicWeb.Pages.Directory
{
    public class AddressModel : PageModel
    {
        public List<Address> Addresses { get; set; }

        public void OnGet()
        {
            var fakeAddr = new Address();
            fakeAddr.AddressId = 0;
            fakeAddr.City = "Houston";
            fakeAddr.PostalCode = 77573;
            fakeAddr.State = "Texas";
            fakeAddr.StreetAddress = "471 Looneyville Street";

            Addresses = new List<Address>();
            Addresses.Add(fakeAddr);
        }
    }
}
