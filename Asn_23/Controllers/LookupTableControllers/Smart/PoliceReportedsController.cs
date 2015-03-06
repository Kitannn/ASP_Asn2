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
    public class PoliceReportedsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: PoliceReporteds
        public ActionResult Index()
        {
            return View(db.PoliceReporteds.ToList());
        }

        // GET: PoliceReporteds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReporteds.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceReporteds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PoliceReportedId,YesNoNA")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.PoliceReporteds.Add(policeReported);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policeReported);
        }

        // GET: PoliceReporteds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReporteds.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PoliceReportedId,YesNoNA")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeReported).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReporteds.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PoliceReported policeReported = db.PoliceReporteds.Find(id);
            db.PoliceReporteds.Remove(policeReported);
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
