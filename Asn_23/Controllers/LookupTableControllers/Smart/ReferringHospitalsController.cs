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
    public class ReferringHospitalsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferringHospitals
        public ActionResult Index()
        {
            return View(db.ReferringHospitals.ToList());
        }

        // GET: ReferringHospitals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospitals.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferringHospitals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferringHospitalId,HospitalName")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.ReferringHospitals.Add(referringHospital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referringHospital);
        }

        // GET: ReferringHospitals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospitals.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferringHospitalId,HospitalName")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referringHospital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospitals.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferringHospital referringHospital = db.ReferringHospitals.Find(id);
            db.ReferringHospitals.Remove(referringHospital);
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
