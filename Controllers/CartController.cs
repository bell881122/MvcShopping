using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class CartController : Controller
    {
        // 新增商品到購物車，如果沒有 Amout 參數默認數量為 1
        [HttpPost]
        public ActionResult AddToCart(int ProductId, int Amount = 1)
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        // 移除購物車項目
        [HttpPost]
        public ActionResult Remove(int ProductId)
        {
            return View();
        }

        // 更新購物車中特定商品的數量
        [HttpPost]
        public ActionResult UpdateAmount(int ProductId, int NewAmount)
        {
            return View();
        }

    }
}