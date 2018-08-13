using NTier.Service.Service.Option;
using NTier.UI.Attributes;
using System.Web.Mvc;

namespace NTier.UI.Areas.Member.Controllers
{
    [Role("admin", "member")]
    public class CategoryController : Controller
    {
        CategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        public ActionResult Index()
        {
            return View(_categoryService.GetActive());
        }
    }
}