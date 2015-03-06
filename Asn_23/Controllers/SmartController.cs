using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asn_23.Models;

namespace Asn_23.Controllers
{
    public class SmartController : Controller
    {
        private GoodSamaritanContext db = new GoodSamaritanContext();

        // GET: Smart
        public async Task<ActionResult> Index()
        {
            var smarts = db.Smarts.Include(s => s.BadDateReport).Include(s => s.CityOfAssault).Include(s => s.CityOfResidence).Include(s => s.Clients).Include(s => s.DrugFacilitatedAssault).Include(s => s.EvidenceStored).Include(s => s.HIVMeds).Include(s => s.HospitalAttended).Include(s => s.MedicalOnly).Include(s => s.MultiplePerpetrators).Include(s => s.PoliceAttendance).Include(s => s.PoliceReported).Include(s => s.ReferredToCBVS).Include(s => s.ReferringHospital).Include(s => s.SexWorkExploitation).Include(s => s.SocialWorkAttendance).Include(s => s.ThirdPartyReport).Include(s => s.VictimServicesAttendance);
            return View(await smarts.ToListAsync());
        }

        // GET: Smart/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // GET: Smart/Create
        public ActionResult Create()
        {
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "YesNoNA");
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaults, "CityOfAssaultId", "City");
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidences, "CityOfResidenceId", "City");
            ViewBag.ClientReferenceNumber = new SelectList(db.Clients, "ClientReferenceNumber", "Surname");
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaults, "DrugFacilitatedAssaultId", "YesNoNA");
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoreds, "EvidenceStoredId", "YesNoNA");
            ViewBag.HIVMedsId = new SelectList(db.HIVMeds, "HIVMedsId", "YesNoNA");
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendeds, "HospitalAttendedId", "HospitalName");
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlies, "MedicalOnlyId", "YesNoNA");
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetrators, "MultiplePerpetratorsId", "YesNoNA");
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "YesNoNA");
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReporteds, "PoliceReportedId", "YesNoNA");
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVS, "ReferredToCBVSId", "YesNoPVBSOnlyNA");
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "HospitalName");
            ViewBag.SexWorkExploitationId = new SelectList(db.SexWorkExploitations, "SexWorkExploitationId", "YesNoNA");
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "YesNoNA");
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "YesNoNA");
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendances, "VictimServicesAttendanceId", "YesNoNA");
            return View();
        }

        // POST: Smart/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SmartId,ClientReferenceNumber,SexWorkExploitationId,MultiplePerpetratorsId,DrugFacilitatedAssaultId,CityOfAssaultId,CityOfResidenceId,AccompanimnetMinutes,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServiceAttendanceId,MedicalOnlyId,EvidenceStoredId,HIVMedsId,ReferredToCBVSId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,ReferredToNursePractitioner")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Smarts.Add(smart);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "YesNoNA", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaults, "CityOfAssaultId", "City", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidences, "CityOfResidenceId", "City", smart.CityOfResidenceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.Clients, "ClientReferenceNumber", "Surname", smart.ClientReferenceNumber);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaults, "DrugFacilitatedAssaultId", "YesNoNA", smart.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoreds, "EvidenceStoredId", "YesNoNA", smart.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMeds, "HIVMedsId", "YesNoNA", smart.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendeds, "HospitalAttendedId", "HospitalName", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlies, "MedicalOnlyId", "YesNoNA", smart.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetrators, "MultiplePerpetratorsId", "YesNoNA", smart.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "YesNoNA", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReporteds, "PoliceReportedId", "YesNoNA", smart.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVS, "ReferredToCBVSId", "YesNoPVBSOnlyNA", smart.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "HospitalName", smart.ReferringHospitalId);
            ViewBag.SexWorkExploitationId = new SelectList(db.SexWorkExploitations, "SexWorkExploitationId", "YesNoNA", smart.SexWorkExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "YesNoNA", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "YesNoNA", smart.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendances, "VictimServicesAttendanceId", "YesNoNA");
            return View(smart);
        }

        // GET: Smart/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "YesNoNA", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaults, "CityOfAssaultId", "City", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidences, "CityOfResidenceId", "City", smart.CityOfResidenceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.Clients, "ClientReferenceNumber", "Surname", smart.ClientReferenceNumber);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaults, "DrugFacilitatedAssaultId", "YesNoNA", smart.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoreds, "EvidenceStoredId", "YesNoNA", smart.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMeds, "HIVMedsId", "YesNoNA", smart.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendeds, "HospitalAttendedId", "HospitalName", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlies, "MedicalOnlyId", "YesNoNA", smart.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetrators, "MultiplePerpetratorsId", "YesNoNA", smart.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "YesNoNA", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReporteds, "PoliceReportedId", "YesNoNA", smart.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVS, "ReferredToCBVSId", "YesNoPVBSOnlyNA", smart.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "HospitalName", smart.ReferringHospitalId);
            ViewBag.SexWorkExploitationId = new SelectList(db.SexWorkExploitations, "SexWorkExploitationId", "YesNoNA", smart.SexWorkExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "YesNoNA", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "YesNoNA", smart.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendances, "VictimServicesAttendanceId", "YesNoNA");
            return View(smart);
        }

        // POST: Smart/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SmartId,ClientReferenceNumber,SexWorkExploitationId,MultiplePerpetratorsId,DrugFacilitatedAssaultId,CityOfAssaultId,CityOfResidenceId,AccompanimnetMinutes,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServiceAttendanceId,MedicalOnlyId,EvidenceStoredId,HIVMedsId,ReferredToCBVSId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,ReferredToNursePractitioner")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smart).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "YesNoNA", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaults, "CityOfAssaultId", "City", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidences, "CityOfResidenceId", "City", smart.CityOfResidenceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.Clients, "ClientReferenceNumber", "Surname", smart.ClientReferenceNumber);
            ViewBag.DrugFacilitatedAssaultId = new SelectList(db.DrugFacilitatedAssaults, "DrugFacilitatedAssaultId", "YesNoNA", smart.DrugFacilitatedAssaultId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoreds, "EvidenceStoredId", "YesNoNA", smart.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMeds, "HIVMedsId", "YesNoNA", smart.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendeds, "HospitalAttendedId", "HospitalName", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlies, "MedicalOnlyId", "YesNoNA", smart.MedicalOnlyId);
            ViewBag.MultiplePerpetratorsId = new SelectList(db.MultiplePerpetrators, "MultiplePerpetratorsId", "YesNoNA", smart.MultiplePerpetratorsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "YesNoNA", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReporteds, "PoliceReportedId", "YesNoNA", smart.PoliceReportedId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredToCBVS, "ReferredToCBVSId", "YesNoPVBSOnlyNA", smart.ReferredToCBVSId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "HospitalName", smart.ReferringHospitalId);
            ViewBag.SexWorkExploitationId = new SelectList(db.SexWorkExploitations, "SexWorkExploitationId", "YesNoNA", smart.SexWorkExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "YesNoNA", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "YesNoNA", smart.ThirdPartyReportId);
            ViewBag.VictimServicesAttendanceId = new SelectList(db.VictimServicesAttendances, "VictimServicesAttendanceId", "YesNoNA");
            return View(smart);
        }

        // GET: Smart/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // POST: Smart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Smart smart = await db.Smarts.FindAsync(id);
            db.Smarts.Remove(smart);
            await db.SaveChangesAsync();
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
