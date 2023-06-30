using Microsoft.AspNetCore.Mvc;

namespace MVCClassCustomer.Controllers
{
    public class Class : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
