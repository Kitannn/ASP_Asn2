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
    public class ReferredToCBVSController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferredToCBVS
        public ActionResult Index()
        {
            return View(db.ReferredToCBVS.ToList());
        }

        // GET: ReferredToCBVS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredToCBVS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferredToCBVSId,YesNoPVBSOnlyNA")] ReferredToCBVS referredToCBVS)
        {
            if (ModelState.IsValid)
            {
                db.ReferredToCBVS.Add(referredToCBVS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // POST: ReferredToCBVS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferredToCBVSId,YesNoPVBSOnlyNA")] ReferredToCBVS referredToCBVS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredToCBVS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // POST: ReferredToCBVS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            db.ReferredToCBVS.Remove(referredToCBVS);
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
