using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // 商品列表
        public ActionResult ProductList(int id)
        {
            return View();
        }

        // 商品明細
        public ActionResult ProductDetail(int id)
        {
            return View();
        }
    }
}