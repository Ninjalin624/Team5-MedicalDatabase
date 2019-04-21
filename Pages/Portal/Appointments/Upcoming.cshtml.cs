using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ClinicWeb.Model;
using ClinicWeb.Security;
using ClinicWeb.Util;
using ClinicWeb.Services;

namespace ClinicWeb.Pages.Portal.Appointments
{
    public class UpcomingModel : PageModel
    {
        public IEnumerable<Appointment> Appointments { get; set; }

        public IActionResult OnGet()
        {
            if (!new AuthService().CheckRouteAccess(HttpContext))
                return Redirect("/Login");

            var account = new AuthService().GetSessionAccount(HttpContext);
            Appointments = new AppointmentService().FindUpcomingAppointmentsWithPerson(account.PersonId, 100);

            return Page();
        }
    }
}
