﻿using NTier.Model.Model.Entities;
using NTier.Service.Service.Option;
using NTier.UI.Attributes;
using NTier.UI.Cart;
using System.Web.Mvc;

namespace NTier.UI.Areas.Member.Controllers
{
    [Role("admin", "member")]
    public class OrderController : Controller
    {
        AppUserService _appUserService;
        ProductService _productService;
        OrderService _orderService;

        public OrderController()
        {
            _appUserService = new AppUserService();
            _productService = new ProductService();
            _orderService = new OrderService();
        }



        public RedirectToRouteResult Checkout()
        {
            if (Session["sepet"] == null)
            {
                return RedirectToAction("Index", "Category", new { area = "Member" });
            }
            ProductCart cart = Session["sepet"] as ProductCart;

            Order o = new Order();

            o.AppUserID = _appUserService.FindByUserName(HttpContext.User.Identity.Name).ID;
            

            foreach (var item in cart.CartProductList)
            {
                o.OrderDetails.Add(new OrderDetail
                {
                    ProductID=item.Id,
                    Quantity=item.Quantity,
                    UnitPrice=item.UnitPrice
                });
            }

            o.isConfirmed = false;

            _orderService.Add(o);

            return RedirectToAction("Index", "Category", new { area = "Member" });
        }
    }
}