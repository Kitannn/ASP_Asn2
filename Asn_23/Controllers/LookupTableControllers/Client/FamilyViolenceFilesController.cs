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
    public class FamilyViolenceFilesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: FamilyViolenceFiles
        public ActionResult Index()
        {
            return View(db.FamilyViolenceFiles.ToList());
        }

        // GET: FamilyViolenceFiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = db.FamilyViolenceFiles.Find(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyViolenceFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FamilyViolenceFileId,FileExists")] FamilyViolenceFile familyViolenceFile)
        {
            if (ModelState.IsValid)
            {
                db.FamilyViolenceFiles.Add(familyViolenceFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = db.FamilyViolenceFiles.Find(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // POST: FamilyViolenceFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FamilyViolenceFileId,FileExists")] FamilyViolenceFile familyViolenceFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familyViolenceFile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familyViolenceFile);
        }

        // GET: FamilyViolenceFiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceFile familyViolenceFile = db.FamilyViolenceFiles.Find(id);
            if (familyViolenceFile == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceFile);
        }

        // POST: FamilyViolenceFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FamilyViolenceFile familyViolenceFile = db.FamilyViolenceFiles.Find(id);
            db.FamilyViolenceFiles.Remove(familyViolenceFile);
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
