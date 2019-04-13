using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicWeb.Model;
using ClinicWeb.Services;

namespace ClinicWeb.Pages.PatientList
{
    public class PatientInfoModel : PageModel
    {
        public IEnumerable<Patient> Patients { get; set; }
        public void OnGet()
        {
            var connStr = "Database=clinicdb; Data Source=team5med-db.mysql.database.azure.com; User Id=Team5DBAdmin@team5med-db; Password=Clinic123";
            using (var repo = new Repo(connStr))
            {
                Patients = repo.ReadPatients();
            }

        }
    }
}