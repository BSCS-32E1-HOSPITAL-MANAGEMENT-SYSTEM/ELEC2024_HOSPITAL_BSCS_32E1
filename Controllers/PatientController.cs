using Microsoft.AspNetCore.Mvc;

namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
