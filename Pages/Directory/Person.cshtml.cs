using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Model;
using ClinicWeb.Resources;
using ClinicWeb.Services;

namespace ClinicWeb.Pages.Directory
{
    public class PersonModel : PageModel
    {
        public IEnumerable<Person> Persons { get; set; }

        public void OnGet()
        {
            using (var repo = new Repo(ConnectionStrings.Default))
            {
                Persons = repo.ReadPersons();
            }
        }
    }
}
