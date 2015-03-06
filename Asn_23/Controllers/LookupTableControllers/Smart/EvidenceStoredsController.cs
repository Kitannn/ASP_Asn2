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
    public class EvidenceStoredsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: EvidenceStoreds
        public ActionResult Index()
        {
            return View(db.EvidenceStoreds.ToList());
        }

        // GET: EvidenceStoreds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStoreds.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvidenceStoreds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvidenceStoredId,YesNoNA")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.EvidenceStoreds.Add(evidenceStored);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStoreds.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvidenceStoredId,YesNoNA")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evidenceStored).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStoreds.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EvidenceStored evidenceStored = db.EvidenceStoreds.Find(id);
            db.EvidenceStoreds.Remove(evidenceStored);
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
