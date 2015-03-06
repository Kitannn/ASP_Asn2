using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asn_23.Models;

namespace Asn_23.Controllers.LookupTableControllers.Smart
{
    [Authorize(Roles = "Administrator")]
    public class CityOfResidencesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: CityOfResidences
        public ActionResult Index()
        {
            return View(db.CityOfResidences.ToList());
        }

        // GET: CityOfResidences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidences.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfResidences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityOfResidenceId,City")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.CityOfResidences.Add(cityOfResidence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidences.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityOfResidenceId,City")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfResidence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidences.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CityOfResidence cityOfResidence = db.CityOfResidences.Find(id);
            db.CityOfResidences.Remove(cityOfResidence);
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
