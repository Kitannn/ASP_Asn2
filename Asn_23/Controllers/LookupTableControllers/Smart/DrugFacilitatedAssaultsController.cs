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
    public class DrugFacilitatedAssaultsController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: DrugFacilitatedAssaults
        public ActionResult Index()
        {
            return View(db.DrugFacilitatedAssaults.ToList());
        }

        // GET: DrugFacilitatedAssaults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssault drugFacilitatedAssault = db.DrugFacilitatedAssaults.Find(id);
            if (drugFacilitatedAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssault);
        }

        // GET: DrugFacilitatedAssaults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugFacilitatedAssaults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrugFacilitatedAssaultId,YesNoNA")] DrugFacilitatedAssault drugFacilitatedAssault)
        {
            if (ModelState.IsValid)
            {
                db.DrugFacilitatedAssaults.Add(drugFacilitatedAssault);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drugFacilitatedAssault);
        }

        // GET: DrugFacilitatedAssaults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssault drugFacilitatedAssault = db.DrugFacilitatedAssaults.Find(id);
            if (drugFacilitatedAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssault);
        }

        // POST: DrugFacilitatedAssaults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrugFacilitatedAssaultId,YesNoNA")] DrugFacilitatedAssault drugFacilitatedAssault)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugFacilitatedAssault).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drugFacilitatedAssault);
        }

        // GET: DrugFacilitatedAssaults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssault drugFacilitatedAssault = db.DrugFacilitatedAssaults.Find(id);
            if (drugFacilitatedAssault == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssault);
        }

        // POST: DrugFacilitatedAssaults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DrugFacilitatedAssault drugFacilitatedAssault = db.DrugFacilitatedAssaults.Find(id);
            db.DrugFacilitatedAssaults.Remove(drugFacilitatedAssault);
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
