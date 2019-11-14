using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    [Authorize]  // 必須登錄會員才能使用結帳功能
    public class OrderController : Controller
    {
        // 顯示完成訂單後的頁面
        public ActionResult Complete()
        {
            return View();
        }

        // 將訂單訊息與購物車訊息儲存至資料庫
        [HttpPost]
        public ActionResult Complete(FormCollection form)
        {
            // TODO: 將訂單訊息與購物車訊息寫入資料庫

            // TODO: 訂單完成後，清空現有購物車

            // 訂單完成後回到網站首頁
            return RedirectToAction("Index", "Home");
        }
    }
}