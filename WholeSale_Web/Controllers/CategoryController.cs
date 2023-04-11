using Microsoft.AspNetCore.Mvc;

namespace WholeSale_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
