using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HappyPaws.Models;

namespace HappyPaws.Controllers
{
    public class ToysController : Controller
    {

        //private ShoppingCartModel cart = new ShoppingCartModel();

        // GET: Toys
        public ActionResult Index()
        {
            using (HPContext context = new HPContext())
            {
                var list = context.Toys.OrderBy(x => x.Id).ToList();
                return View(list);
            }
        }

        // GET: Toys/Details/5
        public ActionResult Details(int id)
        {
            using (HPContext context = new HPContext())
            {
                Toys t = context.Toys.Find(id);
                return View(t);
            }
        }

        // GET: Toys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Toys/Create
        [HttpPost]
        public ActionResult Create(Toys obj)
        {
            try
            {
                using(HPContext context = new HPContext())
                {
                    context.Toys.Add(obj);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Toys/Edit/5
        public ActionResult Edit(int id)
        {
            Toys result = null;
            using(HPContext context = new HPContext())
            {
                result = context.Toys.Find(id);
                return View(result);
            }
        }

        // POST: Toys/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                using (HPContext context = new HPContext())
                {
                    var t = context.Toys.Find(id);
                    TryUpdateModel(t);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Toys/Delete/5
        public ActionResult Delete(int id)
        {
            Toys result = null;
            using (HPContext context = new HPContext())
            {
                result = context.Toys.Find(id);
                return View(result);
            }
        }

        // POST: Toys/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (HPContext context = new HPContext())
                {
                    var t = context.Toys.Find(id);
                    context.Toys.Remove(t);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        } 
    }
}
