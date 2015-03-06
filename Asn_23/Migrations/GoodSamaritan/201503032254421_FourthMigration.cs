namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbuserRelationships", "Relationship", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ages", "Range", c => c.String(maxLength: 20));
            AlterColumn("dbo.AssignedWorkers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.BadDateReports", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.CityOfAssaults", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.CityOfResidences", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "Surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "PoliceFileNumber", c => c.String(maxLength: 8));
            AlterColumn("dbo.Clients", "RiskAssessmentAssignedTo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "AbuserSurnameFirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clients", "Gender", c => c.String(maxLength: 5));
            AlterColumn("dbo.Crises", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.DuplicateFiles", "YesOrNull", c => c.String(maxLength: 3));
            AlterColumn("dbo.Ethnicities", "Description", c => c.String(maxLength: 50));
            AlterColumn("dbo.FamilyViolenceFiles", "FileExists", c => c.String(maxLength: 3));
            AlterColumn("dbo.FiscalYears", "Years", c => c.String(maxLength: 5));
            AlterColumn("dbo.Incidents", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.Programs", "Type", c => c.String(maxLength: 20));
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String(maxLength: 20));
            AlterColumn("dbo.ReferralSources", "Source", c => c.String(maxLength: 20));
            AlterColumn("dbo.RepeatClients", "YesOrNull", c => c.String(maxLength: 3));
            AlterColumn("dbo.RiskLevels", "Level", c => c.String(maxLength: 10));
            AlterColumn("dbo.RiskStatus", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.Services", "Type", c => c.String(maxLength: 5));
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.VictimOfIncidents", "PrimaryOrSecondary", c => c.String(maxLength: 10));
            AlterColumn("dbo.DrugFacilitatedAssaults", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.EvidenceStoreds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.HIVMeds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.HospitalAttendeds", "HospitalName", c => c.String(maxLength: 50));
            AlterColumn("dbo.MedicalOnlies", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.MultiplePerpetrators", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.PoliceAttendances", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.PoliceReporteds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.ReferredToCBVS", "YesNoPVBSOnlyNA", c => c.String(maxLength: 10));
            AlterColumn("dbo.ReferringHospitals", "HospitalName", c => c.String(maxLength: 50));
            AlterColumn("dbo.SexWorkExploitations", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialWorkAttendances", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.ThirdPartyReports", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.VictimServicesAttendances", "YesNoNA", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VictimServicesAttendances", "YesNoNA", c => c.String());
            AlterColumn("dbo.ThirdPartyReports", "YesNoNA", c => c.String());
            AlterColumn("dbo.SocialWorkAttendances", "YesNoNA", c => c.String());
            AlterColumn("dbo.SexWorkExploitations", "YesNoNA", c => c.String());
            AlterColumn("dbo.ReferringHospitals", "HospitalName", c => c.String());
            AlterColumn("dbo.ReferredToCBVS", "YesNoPVBSOnlyNA", c => c.String());
            AlterColumn("dbo.PoliceReporteds", "YesNoNA", c => c.String());
            AlterColumn("dbo.PoliceAttendances", "YesNoNA", c => c.String());
            AlterColumn("dbo.MultiplePerpetrators", "YesNoNA", c => c.String());
            AlterColumn("dbo.MedicalOnlies", "YesNoNA", c => c.String());
            AlterColumn("dbo.HospitalAttendeds", "HospitalName", c => c.String());
            AlterColumn("dbo.HIVMeds", "YesNoNA", c => c.String());
            AlterColumn("dbo.EvidenceStoreds", "YesNoNA", c => c.String());
            AlterColumn("dbo.DrugFacilitatedAssaults", "YesNoNA", c => c.String());
            AlterColumn("dbo.VictimOfIncidents", "PrimaryOrSecondary", c => c.String());
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String());
            AlterColumn("dbo.Services", "Type", c => c.String());
            AlterColumn("dbo.RiskStatus", "Status", c => c.String());
            AlterColumn("dbo.RiskLevels", "Level", c => c.String());
            AlterColumn("dbo.RepeatClients", "YesOrNull", c => c.String());
            AlterColumn("dbo.ReferralSources", "Source", c => c.String());
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String());
            AlterColumn("dbo.Programs", "Type", c => c.String());
            AlterColumn("dbo.Incidents", "Type", c => c.String());
            AlterColumn("dbo.FiscalYears", "Years", c => c.String());
            AlterColumn("dbo.FamilyViolenceFiles", "FileExists", c => c.String());
            AlterColumn("dbo.Ethnicities", "Description", c => c.String());
            AlterColumn("dbo.DuplicateFiles", "YesOrNull", c => c.String());
            AlterColumn("dbo.Crises", "Type", c => c.String());
            AlterColumn("dbo.Clients", "Gender", c => c.String());
            AlterColumn("dbo.Clients", "AbuserSurnameFirstName", c => c.String());
            AlterColumn("dbo.Clients", "RiskAssessmentAssignedTo", c => c.String());
            AlterColumn("dbo.Clients", "PoliceFileNumber", c => c.String());
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
            AlterColumn("dbo.Clients", "Surname", c => c.String());
            AlterColumn("dbo.CityOfResidences", "City", c => c.String());
            AlterColumn("dbo.CityOfAssaults", "City", c => c.String());
            AlterColumn("dbo.BadDateReports", "YesNoNA", c => c.String());
            AlterColumn("dbo.AssignedWorkers", "Name", c => c.String());
            AlterColumn("dbo.Ages", "Range", c => c.String());
            AlterColumn("dbo.AbuserRelationships", "Relationship", c => c.String());
        }
    }
}
