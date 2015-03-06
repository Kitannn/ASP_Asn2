using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asn_23.Models;

namespace Asn_23.Controllers.LookupTableControllers.Client
{
    [Authorize(Roles = "Administrator")]
    public class CityOfAssaultsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: CityOfAssaults
        public ActionResult Index()
        {
            return View(db.CityOfAssaults.ToList());
        }

        // GET: CityOfAssaults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = db.CityOfAssaults.Find(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfAssaults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityOfAssaultId,City")] CityOfAssault cityOfAssault)
        {
            if (ModelState.IsValid)
            {
                db.CityOfAssaults.Add(cityOfAssault);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = db.CityOfAssaults.Find(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // POST: CityOfAssaults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityOfAssaultId,City")] CityOfAssault cityOfAssault)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfAssault).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityOfAssault);
        }

        // GET: CityOfAssaults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssault cityOfAssault = db.CityOfAssaults.Find(id);
            if (cityOfAssault == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssault);
        }

        // POST: CityOfAssaults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CityOfAssault cityOfAssault = db.CityOfAssaults.Find(id);
            db.CityOfAssaults.Remove(cityOfAssault);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
