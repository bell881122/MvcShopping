using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [HpptPost]
        public ActionResult Complete(FormCollection form)
        {
            // TODO: 將訂單訊息與購物車訊息寫入資料庫

            // TODO: 訂單完成後，清空現有購物車

            // 訂單完成後回到網站首頁
            return RedirectToAction("Index", "Home");
        }
    }
}