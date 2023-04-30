using Microsoft.AspNetCore.Mvc;

namespace WholeSale_Web.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
