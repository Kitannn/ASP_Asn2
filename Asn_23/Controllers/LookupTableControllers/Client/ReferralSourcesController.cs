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
    public class ReferralSourcesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferralSources
        public ActionResult Index()
        {
            return View(db.ReferralSources.ToList());
        }

        // GET: ReferralSources/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = db.ReferralSources.Find(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // GET: ReferralSources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralSources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferralSourceId,Source")] ReferralSource referralSource)
        {
            if (ModelState.IsValid)
            {
                db.ReferralSources.Add(referralSource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referralSource);
        }

        // GET: ReferralSources/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = db.ReferralSources.Find(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // POST: ReferralSources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferralSourceId,Source")] ReferralSource referralSource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralSource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referralSource);
        }

        // GET: ReferralSources/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSource referralSource = db.ReferralSources.Find(id);
            if (referralSource == null)
            {
                return HttpNotFound();
            }
            return View(referralSource);
        }

        // POST: ReferralSources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferralSource referralSource = db.ReferralSources.Find(id);
            db.ReferralSources.Remove(referralSource);
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
