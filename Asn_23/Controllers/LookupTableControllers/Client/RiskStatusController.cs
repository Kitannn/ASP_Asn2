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
    public class RiskStatusController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: RiskStatus
        public ActionResult Index()
        {
            return View(db.RiskStatus.ToList());
        }

        // GET: RiskStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // GET: RiskStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RiskStatusId,Status")] RiskStatus riskStatus)
        {
            if (ModelState.IsValid)
            {
                db.RiskStatus.Add(riskStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(riskStatus);
        }

        // GET: RiskStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // POST: RiskStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RiskStatusId,Status")] RiskStatus riskStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(riskStatus);
        }

        // GET: RiskStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            if (riskStatus == null)
            {
                return HttpNotFound();
            }
            return View(riskStatus);
        }

        // POST: RiskStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RiskStatus riskStatus = db.RiskStatus.Find(id);
            db.RiskStatus.Remove(riskStatus);
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
