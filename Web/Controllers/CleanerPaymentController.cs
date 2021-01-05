using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Web.Helpers.CustomLogging;

namespace Web.Controllers
{
    public class CleanerPaymentController : BaseController
    {
        public ActionResult Index()
        {
            LogInfo("Test");

            return View();
        }

        // GET: CleanerPayment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CleanerPayment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CleanerPayment/Create
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

        // GET: CleanerPayment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CleanerPayment/Edit/5
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
    }
}
