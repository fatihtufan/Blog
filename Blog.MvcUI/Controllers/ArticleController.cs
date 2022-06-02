using Microsoft.AspNetCore.Mvc;

namespace Blog.MvcUI.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
