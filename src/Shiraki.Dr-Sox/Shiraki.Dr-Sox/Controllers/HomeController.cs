using Shiraki.Dr_Sox.Contexts;
using Shiraki.Dr_Sox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shiraki.Dr_Sox.Controllers
{
    public class HomeController : Controller
    {
        DrSoxDb db = new DrSoxDb();

        public ActionResult Index()
        {
            ShopViewModels model = new ShopViewModels()
            {
                Products = db.Products
                    .Where(e => e.Show)
                    .OrderByDescending(e => e.IsNew)
                    .ThenByDescending(e => e.IsHot)
                    .Select(e => new OrderItem()
                    {
                        Id = e.Id,
                        Code = e.Code,
                        Name = e.Name,
                        Picture = e.Picture,
                        Price = e.Price,
                        Amount = 0,
                        IsHot = e.IsHot,
                        IsNew = e.IsNew
                    })
                    .ToList()
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}