namespace Asn_23.Migrations.GoodSamaritan
{
    using Asn_23.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<Asn_23.Models.GoodSamaritanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\GoodSamaritan";
        }

        protected override void Seed(Asn_23.Models.GoodSamaritanContext context)
        {
            context.Incidents.AddOrUpdate(
                p => p.Type,
                new Incident { Type="Abduction" },
                new Incident { Type="Adult Historical Sex Assault" },
                new Incident { Type="Adult Sexual Assault" },
                new Incident { Type="Partner Assault" },
                new Incident { Type="Attempted Murder" },
                new Incident { Type="Child Physical Assault" },
                new Incident { Type="Child Sexual Abuse/Exploitation" },
                new Incident { Type="Criminal Harassment/Stalking" },
                new Incident { Type="Elder Abuse" },
                new Incident { Type="Human Trafficking" },
                new Incident { Type="Murder" },
                new Incident { Type="N/A" },
                new Incident { Type="Other" },
                new Incident { Type="Other Assault" },
                new Incident { Type="Other Crime - DV" },
                new Incident { Type="Other Familial Assault" },
                new Incident { Type="Threatening" },
                new Incident { Type="Youth Sexual Assault/Exploitation" }
            );

            context.RiskLevels.AddOrUpdate(
                p => p.Level,
                new RiskLevel {  Level = "High" },
                new RiskLevel {  Level = "DVU" }
            );

            context.Crises.AddOrUpdate(
                p => p.Type,
                new Crisis {  Type = "Call" },
                new Crisis {  Type = "Accompaniment" },
                new Crisis {  Type = "Drop-In" }
            );

            context.Services.AddOrUpdate(
                p => p.Type,
                new Service { Type="N/A"},
                new Service { Type="File"}
            );

            context.Programs.AddOrUpdate(
                p => p.Type,
                new Program { Type="Crisis"},
                new Program { Type="Court"},
                new Program { Type="SMART"},
                new Program { Type="DVU"},
                new Program { Type="MCFD"}
            );

            context.RiskStatus.AddOrUpdate(
                p => p.Status,
                new RiskStatus { Status="Pending" },
                new RiskStatus { Status="Complete" }
            );

            context.AssignedWorkers.AddOrUpdate(
                p => p.Name,
                new AssignedWorker { Name="Michelle" },
                new AssignedWorker { Name="Tyra" },
                new AssignedWorker { Name="Louise" },
                new AssignedWorker { Name="Angela" },
                new AssignedWorker { Name="Dave" },
                new AssignedWorker { Name="Troy" },
                new AssignedWorker { Name="Michael" },
                new AssignedWorker { Name="Manpreet" },
                new AssignedWorker { Name="Patrick" },
                new AssignedWorker { Name="None" }
            );

            context.FiscalYears.AddOrUpdate(
                p => p.Years,
                new FiscalYear { Years = "10-11" },
                new FiscalYear { Years = "11-12" },
                new FiscalYear { Years = "12-13" },
                new FiscalYear { Years = "13-14" },
                new FiscalYear { Years = "14-15" },
                new FiscalYear { Years = "15-16" },
                new FiscalYear { Years = "16-17" }
            );

            context.ReferralSources.AddOrUpdate(
                p => p.Source,
                new ReferralSource { Source="Community Agency" },
                new ReferralSource { Source="Family/Friend" },
                new ReferralSource { Source="Government" },
                new ReferralSource { Source="CVAP" },
                new ReferralSource { Source="CBVS" }
            );

            context.AbuserRelationships.AddOrUpdate(
                p => p.Relationship,
                new AbuserRelationship { Relationship="Acquaintance" },
                new AbuserRelationship { Relationship="Bad Date" },
                new AbuserRelationship { Relationship="DNA" },
                new AbuserRelationship { Relationship="Ex-Partner" },
                new AbuserRelationship { Relationship="Friend" },
                new AbuserRelationship { Relationship="Multiple Perps" },
                new AbuserRelationship { Relationship="N/A" },
                new AbuserRelationship { Relationship="Other" },
                new AbuserRelationship { Relationship="Other Familial" },
                new AbuserRelationship { Relationship="Parent" },
                new AbuserRelationship { Relationship="Partner" },
                new AbuserRelationship { Relationship="Sibling" },
                new AbuserRelationship { Relationship="Stranger" }
            );

            context.VictimOfIncidents.AddOrUpdate(
                p => p.PrimaryOrSecondary,
                new VictimOfIncident { PrimaryOrSecondary="Primary" },
                new VictimOfIncident { PrimaryOrSecondary="Secondary" }
            );

            context.FamilyViolenceFiles.AddOrUpdate(
                p => p.FileExists,
                new FamilyViolenceFile { FileExists="Yes" },
                new FamilyViolenceFile { FileExists="No" },
                new FamilyViolenceFile { FileExists="N/A" }
            );

            context.Ethnicities.AddOrUpdate(
                p => p.Description,
                new Ethnicity { Description="Indigenous" },
                new Ethnicity { Description="Asian" },
                new Ethnicity { Description="Black" },
                new Ethnicity { Description="Caucasian" },
                new Ethnicity { Description="Declined" },
                new Ethnicity { Description="Latin" },
                new Ethnicity { Description="Middle Eastern" },
                new Ethnicity { Description="Other" },
                new Ethnicity { Description="South Asian" },
                new Ethnicity { Description="South East Asian" }
            );

            context.Ages.AddOrUpdate(
                p => p.Range,
                new Age { Range="Adult >24<65" },
                new Age { Range="Youth >12<19" },
                new Age { Range="Youth >18<25" },
                new Age { Range="Child <13" },
                new Age { Range="Senior >64" }
            );

            context.ReferralContacts.AddOrUpdate(
                p => p.Contact,
                new ReferralContact { Contact="PBVS" },
                new ReferralContact { Contact="MCFD" },
                new ReferralContact { Contact="VictimLINK" },
                new ReferralContact { Contact="TH" },
                new ReferralContact { Contact="Self" },
                new ReferralContact { Contact="FNS" },
                new ReferralContact { Contact="Other" },
                new ReferralContact { Contact="Medical" }
            );

            context.StatusOfFiles.AddOrUpdate(
                p => p.StatusOfFileId,
                new StatusOfFile { Status = "Reopened" },
                new StatusOfFile { Status = "Closed" },
                new StatusOfFile { Status = "Open" }
            );

            context.RepeatClients.AddOrUpdate(
                p => p.YesOrNull,
                new RepeatClient { YesOrNull="Yes" }
            );

            context.DuplicateFiles.AddOrUpdate(
                p => p.YesOrNull,
                new DuplicateFile { YesOrNull = "Yes" }
            );

            context.MultiplePerpetrators.AddOrUpdate(
                p => p.YesNoNA,
                new MultiplePerpetrators { YesNoNA = "Yes" },
                new MultiplePerpetrators { YesNoNA = "No" },
                new MultiplePerpetrators { YesNoNA = "N/A" }
            );

            context.DrugFacilitatedAssaults.AddOrUpdate(
                p => p.YesNoNA,
                new DrugFacilitatedAssault { YesNoNA = "Yes" },
                new DrugFacilitatedAssault { YesNoNA = "No" },
                new DrugFacilitatedAssault { YesNoNA = "N/A" }
            );

            context.CityOfAssaults.AddOrUpdate(
                p => p.City,
                new CityOfAssault { City="Surrey" },
                new CityOfAssault { City="Abbotsford" },
                new CityOfAssault { City="Agassiz" },
                new CityOfAssault { City="Boston Bar" },
                new CityOfAssault { City="Burnaby" },
                new CityOfAssault { City="Chilliwack" },
                new CityOfAssault { City="Conquitlam" },
                new CityOfAssault { City="Delta" },
                new CityOfAssault { City="Harrison Hot Springs" },
                new CityOfAssault { City="Hope" },
                new CityOfAssault { City="Langley" },
                new CityOfAssault { City="Maple Ridge" },
                new CityOfAssault { City="Mission" },
                new CityOfAssault { City="New Westminster" },
                new CityOfAssault { City="Pitt Meadows" },
                new CityOfAssault { City="Port Coquitlam" },
                new CityOfAssault { City="Port Moody" },
                new CityOfAssault { City="Vancouver" },
                new CityOfAssault { City="White Rock" },
                new CityOfAssault { City="Yale" },
                new CityOfAssault { City="Other - BC" },
                new CityOfAssault { City="Out-of-Province" },
                new CityOfAssault { City="International" }
            );

            context.SexWorkExploitations.AddOrUpdate(
                p => p.YesNoNA,
                new SexWorkExploitation { YesNoNA="Yes" },
                new SexWorkExploitation { YesNoNA="No" },
                new SexWorkExploitation { YesNoNA="N/A" }
            );

            context.CityOfResidences.AddOrUpdate(
                p => p.City,
                new CityOfResidence { City = "Surrey" },
                new CityOfResidence { City = "Abbotsford" },
                new CityOfResidence { City = "Agassiz" },
                new CityOfResidence { City = "Boston Bar" },
                new CityOfResidence { City = "Burnaby" },
                new CityOfResidence { City = "Chilliwack" },
                new CityOfResidence { City = "Conquitlam" },
                new CityOfResidence { City = "Delta" },
                new CityOfResidence { City = "Harrison Hot Springs" },
                new CityOfResidence { City = "Hope" },
                new CityOfResidence { City = "Langley" },
                new CityOfResidence { City = "Maple Ridge" },
                new CityOfResidence { City = "Mission" },
                new CityOfResidence { City = "New Westminster" },
                new CityOfResidence { City = "Pitt Meadows" },
                new CityOfResidence { City = "Port Coquitlam" },
                new CityOfResidence { City = "Port Moody" },
                new CityOfResidence { City = "Vancouver" },
                new CityOfResidence { City = "White Rock" },
                new CityOfResidence { City = "Yale" },
                new CityOfResidence { City = "Other - BC" },
                new CityOfResidence { City = "Out-of-Province" },
                new CityOfResidence { City = "International" }
            );

            context.ReferringHospitals.AddOrUpdate(
                p => p.HospitalName,
                new ReferringHospital { HospitalName="Abbotsford Regional Hospital" },
                new ReferringHospital { HospitalName="Surrey Memorial Hospital" },
                new ReferringHospital { HospitalName="Buranby Hospital" },
                new ReferringHospital { HospitalName="Chilliwack General Hospital" },
                new ReferringHospital { HospitalName="Delta Hospital" },
                new ReferringHospital { HospitalName="Eagle Ridge Hospital" },
                new ReferringHospital { HospitalName="Fraser Canyon Hospital" },
                new ReferringHospital { HospitalName="Langley Hospital" },
                new ReferringHospital { HospitalName="Mission Hospital" },
                new ReferringHospital { HospitalName="Peace Arch Hospital" },
                new ReferringHospital { HospitalName="Ridge Meadow Hospital" },
                new ReferringHospital { HospitalName="Royal Columbia Hospital" }
            );

            context.HospitalAttendeds.AddOrUpdate(
                p => p.HospitalName,
                new HospitalAttended { HospitalName = "Abbotsford Regional Hospital" },
                new HospitalAttended { HospitalName = "Surrey Memorial Hospital" },
                new HospitalAttended { HospitalName = "Buranby Hospital" },
                new HospitalAttended { HospitalName = "Chilliwack General Hospital" },
                new HospitalAttended { HospitalName = "Delta Hospital" },
                new HospitalAttended { HospitalName = "Eagle Ridge Hospital" },
                new HospitalAttended { HospitalName = "Fraser Canyon Hospital" },
                new HospitalAttended { HospitalName = "Langley Hospital" },
                new HospitalAttended { HospitalName = "Mission Hospital" },
                new HospitalAttended { HospitalName = "Peace Arch Hospital" },
                new HospitalAttended { HospitalName = "Ridge Meadow Hospital" },
                new HospitalAttended { HospitalName = "Royal Columbia Hospital" }
            );

            context.SocialWorkAttendances.AddOrUpdate(
                p => p.YesNoNA,
                new SocialWorkAttendance { YesNoNA="Yes" },
                new SocialWorkAttendance { YesNoNA="No" },
                new SocialWorkAttendance { YesNoNA="N/A" }
            );

            context.PoliceAttendances.AddOrUpdate(
                p => p.YesNoNA,
                new PoliceAttendance { YesNoNA = "Yes" },
                new PoliceAttendance { YesNoNA = "No" },
                new PoliceAttendance { YesNoNA = "N/A" }
            );

            context.VictimServicesAttendances.AddOrUpdate(
                p => p.YesNoNA,
                new VictimServicesAttendance { YesNoNA = "Yes" },
                new VictimServicesAttendance { YesNoNA = "No" },
                new VictimServicesAttendance { YesNoNA = "N/A" }
            );

            context.MedicalOnlies.AddOrUpdate(
                p => p.YesNoNA,
                new MedicalOnly { YesNoNA = "Yes" },
                new MedicalOnly { YesNoNA = "No" },
                new MedicalOnly { YesNoNA = "N/A" }
            );

            context.EvidenceStoreds.AddOrUpdate(
                p => p.YesNoNA,
                new EvidenceStored { YesNoNA = "Yes" },
                new EvidenceStored { YesNoNA = "No" },
                new EvidenceStored { YesNoNA = "N/A" }
            );

            context.HIVMeds.AddOrUpdate(
                p => p.YesNoNA,
                new HIVMeds { YesNoNA = "Yes" },
                new HIVMeds { YesNoNA = "No" },
                new HIVMeds { YesNoNA = "N/A" }
            );

            context.BadDateReports.AddOrUpdate(
                p => p.YesNoNA,
                new BadDateReport { YesNoNA = "Yes" },
                new BadDateReport { YesNoNA = "No" },
                new BadDateReport { YesNoNA = "N/A" }
            );

            context.ReferredToCBVS.AddOrUpdate(
                p => p.YesNoPVBSOnlyNA,
                new ReferredToCBVS { YesNoPVBSOnlyNA = "Yes" },
                new ReferredToCBVS { YesNoPVBSOnlyNA = "No" },
                new ReferredToCBVS { YesNoPVBSOnlyNA = "PVBS Only"},
                new ReferredToCBVS { YesNoPVBSOnlyNA = "N/A" }
            );

            context.PoliceReporteds.AddOrUpdate(
                p => p.YesNoNA,
                new PoliceReported { YesNoNA = "Yes" },
                new PoliceReported { YesNoNA = "No" },
                new PoliceReported { YesNoNA = "N/A" }
            );

            context.ThirdPartyReports.AddOrUpdate(
                p => p.YesNoNA,
                new ThirdPartyReport { YesNoNA = "Yes" },
                new ThirdPartyReport { YesNoNA = "No" },
                new ThirdPartyReport { YesNoNA = "N/A" }
            );

            
        }
    }
}
