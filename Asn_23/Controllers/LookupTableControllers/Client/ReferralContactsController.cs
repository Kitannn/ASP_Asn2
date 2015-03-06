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
    public class ReferralContactsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: ReferralContacts
        public ActionResult Index()
        {
            return View(db.ReferralContacts.ToList());
        }

        // GET: ReferralContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = db.ReferralContacts.Find(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // GET: ReferralContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReferralContactId,Contact")] ReferralContact referralContact)
        {
            if (ModelState.IsValid)
            {
                db.ReferralContacts.Add(referralContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referralContact);
        }

        // GET: ReferralContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = db.ReferralContacts.Find(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // POST: ReferralContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReferralContactId,Contact")] ReferralContact referralContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referralContact);
        }

        // GET: ReferralContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContact referralContact = db.ReferralContacts.Find(id);
            if (referralContact == null)
            {
                return HttpNotFound();
            }
            return View(referralContact);
        }

        // POST: ReferralContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferralContact referralContact = db.ReferralContacts.Find(id);
            db.ReferralContacts.Remove(referralContact);
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
