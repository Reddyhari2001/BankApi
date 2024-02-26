using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
