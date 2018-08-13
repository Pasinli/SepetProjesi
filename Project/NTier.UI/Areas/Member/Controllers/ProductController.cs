using NTier.Service.Service.Option;
using NTier.UI.Attributes;
using PagedList;
using System;
using System.Web.Mvc;

namespace NTier.UI.Areas.Member.Controllers
{
    [Role("admin","member")]
    public class ProductController : Controller
    {
        ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        public ActionResult List(Guid? id,int page=1)
        {
            if (id != null)
            {
                return View(_productService.GetDefault(x => x.CategoryID == id).ToPagedList(page,5));
            }
            return RedirectToAction("Index", "Category", new { area = "Member" });
        }

        public ActionResult Detail(Guid id)
        {
            if (id != null)
            {
                return View(_productService.GetById(id));
            }
            return RedirectToAction("Index", "Category", new { area = "" });
        }
    }
}