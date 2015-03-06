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
    public class DuplicateFilesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: DuplicateFiles
        public ActionResult Index()
        {
            return View(db.DuplicateFiles.ToList());
        }

        // GET: DuplicateFiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = db.DuplicateFiles.Find(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DuplicateFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DuplicateFileId,YesOrNull")] DuplicateFile duplicateFile)
        {
            if (ModelState.IsValid)
            {
                db.DuplicateFiles.Add(duplicateFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = db.DuplicateFiles.Find(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // POST: DuplicateFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DuplicateFileId,YesOrNull")] DuplicateFile duplicateFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duplicateFile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duplicateFile);
        }

        // GET: DuplicateFiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuplicateFile duplicateFile = db.DuplicateFiles.Find(id);
            if (duplicateFile == null)
            {
                return HttpNotFound();
            }
            return View(duplicateFile);
        }

        // POST: DuplicateFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DuplicateFile duplicateFile = db.DuplicateFiles.Find(id);
            db.DuplicateFiles.Remove(duplicateFile);
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
