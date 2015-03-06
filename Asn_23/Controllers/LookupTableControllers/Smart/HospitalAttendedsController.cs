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
    public class HospitalAttendedsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: HospitalAttendeds
        public ActionResult Index()
        {
            return View(db.HospitalAttendeds.ToList());
        }

        // GET: HospitalAttendeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttendeds.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalAttendeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HospitalAttendedId,HospitalName")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.HospitalAttendeds.Add(hospitalAttended);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttendeds.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HospitalAttendedId,HospitalName")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalAttended).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttendeds.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HospitalAttended hospitalAttended = db.HospitalAttendeds.Find(id);
            db.HospitalAttendeds.Remove(hospitalAttended);
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
