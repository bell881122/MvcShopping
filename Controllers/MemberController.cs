using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class MemberController : Controller
    {
        // 會員註頁面
        public ActionResult Register()
        {
            return View();
        }

        // 寫入會員訊息
        public ActionResult Register(Member member)
        {
            return View();
        }

        // 顯示會員登錄頁面
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        // 運行會員登錄
        public ActionResult Login(string email, string passwaord, string returnUrl)
        {
            if (ValidateUser(email, passwaord))
            {
                FormdAuthentication.SetauthCookie(email, false);

                if (String.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Redirect(returnUrl);
                }
            }

            ModelState.AddModelError("", "您輸入的帳號或密碼錯誤");
            return View();
        }

        private bool ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        // 運行會員Logout
        public ActionResult Logout()
        {
            // 清除驗證的cookies
            FormAuthentication.SighOut();

            // 清除曾經寫入過的Session信息
            Session.Clear();

            return RedirectToAction("Index", "Home");

        }


    }
}