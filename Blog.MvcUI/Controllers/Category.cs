using Blog.BusinessLayer.Concrete;
using Blog.DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.MvcUI.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
