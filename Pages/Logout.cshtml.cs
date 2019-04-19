using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClinicWeb.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet() {
            Response.Cookies.Delete("username");
            return Redirect("/");
        }
    }
}