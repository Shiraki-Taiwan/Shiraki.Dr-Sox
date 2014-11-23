using Shiraki.Dr_Sox.Contexts;
using Shiraki.Dr_Sox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shiraki.Dr_Sox.Controllers
{
    public class ShopController : Controller
    {
        DrSoxDb db = new DrSoxDb();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(ShopViewModels model)
        {
            if (model.Products != null && model.Products.Count() > 0)
            {
                model.Products = model.Products.Join(db.Products, m => m.Id, p => p.Id, (m, p) => new OrderItem()
                {
                    Id = p.Id,
                    Code = p.Code,
                    Name = p.Name,
                    Picture = p.Picture,
                    Price = p.Price,
                    Amount = m.Amount,
                    IsHot = p.IsHot,
                    IsNew = p.IsNew
                }).ToList();
            }

            if (ModelState.IsValid)
            {
                return View("Create", model);
            }

            return View(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
