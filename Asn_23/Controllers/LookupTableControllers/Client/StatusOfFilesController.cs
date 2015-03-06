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
    public class StatusOfFilesController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: StatusOfFiles
        public ActionResult Index()
        {
            return View(db.StatusOfFiles.ToList());
        }

        // GET: StatusOfFiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusOfFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.StatusOfFiles.Add(statusOfFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            db.StatusOfFiles.Remove(statusOfFile);
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
