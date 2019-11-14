﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new List<ProductCategory>()
            {
                new ProductCategory(){ Id=1,Name="文具"},
                new ProductCategory(){ Id=2,Name="禮品"},
                new ProductCategory(){ Id=3,Name="書籍"},
                new ProductCategory(){ Id=4,Name="美勞用具"}
            };

            return View(data);
        }

        // 商品列表
        public ActionResult ProductList(int id)
        {
            var productCategory = new ProductCategory() { Id = id, Name = "類別" + id };
            var data = new List<Product>() {
                new Product(){Id = 1, ProductCategory = productCategory, Name = "原子筆", Description = "N/A", Price = 30, PublishOn = DateTime.Now, Color = Color.Black.ToString() },
                // 範例中兩個 Id 都是 1
                new Product(){Id = 1, ProductCategory = productCategory, Name = "鉛筆", Description = "N/A", Price = 5, PublishOn = DateTime.Now, Color = Color.Black.ToString() }
            };
            return View(data);
        }

        // 商品明細
        public ActionResult ProductDetail(int id)
        {
            var productCategory = new ProductCategory() { Id = 1, Name = "文具" };
            var data = new Product() { Id = id, ProductCategory = productCategory, Name = "商品" + id, Description = "N/A", Price = 30, PublishOn = DateTime.Now, Color = Color.Black.ToString() };
            return View(data);
        }
    }
}