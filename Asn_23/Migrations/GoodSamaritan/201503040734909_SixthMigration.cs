namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ages", "Range", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AssignedWorkers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BadDateReports", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.CityOfAssaults", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CityOfResidences", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Crises", "Type", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.DuplicateFiles", "YesOrNull", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Ethnicities", "Description", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FamilyViolenceFiles", "FileExists", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.FiscalYears", "Years", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Incidents", "Type", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Programs", "Type", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ReferralSources", "Source", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.RepeatClients", "YesOrNull", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.RiskLevels", "Level", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.RiskStatus", "Status", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Services", "Type", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.VictimOfIncidents", "PrimaryOrSecondary", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DrugFacilitatedAssaults", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.EvidenceStoreds", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.HIVMeds", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.HospitalAttendeds", "HospitalName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.MedicalOnlies", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.MultiplePerpetrators", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.PoliceAttendances", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.PoliceReporteds", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.ReferredToCBVS", "YesNoPVBSOnlyNA", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.ReferringHospitals", "HospitalName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SexWorkExploitations", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.SocialWorkAttendances", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.ThirdPartyReports", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.VictimServicesAttendances", "YesNoNA", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VictimServicesAttendances", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.ThirdPartyReports", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialWorkAttendances", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.SexWorkExploitations", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.ReferringHospitals", "HospitalName", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReferredToCBVS", "YesNoPVBSOnlyNA", c => c.String(maxLength: 10));
            AlterColumn("dbo.PoliceReporteds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.PoliceAttendances", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.MultiplePerpetrators", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.MedicalOnlies", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.HospitalAttendeds", "HospitalName", c => c.String(maxLength: 50));
            AlterColumn("dbo.HIVMeds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.EvidenceStoreds", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.DrugFacilitatedAssaults", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.VictimOfIncidents", "PrimaryOrSecondary", c => c.String(maxLength: 10));
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.Services", "Type", c => c.String(maxLength: 5));
            AlterColumn("dbo.RiskStatus", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.RiskLevels", "Level", c => c.String(maxLength: 10));
            AlterColumn("dbo.RepeatClients", "YesOrNull", c => c.String(maxLength: 3));
            AlterColumn("dbo.ReferralSources", "Source", c => c.String(maxLength: 20));
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String(maxLength: 20));
            AlterColumn("dbo.Programs", "Type", c => c.String(maxLength: 20));
            AlterColumn("dbo.Incidents", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.FiscalYears", "Years", c => c.String(maxLength: 5));
            AlterColumn("dbo.FamilyViolenceFiles", "FileExists", c => c.String(maxLength: 3));
            AlterColumn("dbo.Ethnicities", "Description", c => c.String(maxLength: 50));
            AlterColumn("dbo.DuplicateFiles", "YesOrNull", c => c.String(maxLength: 3));
            AlterColumn("dbo.Crises", "Type", c => c.String(maxLength: 50));
            AlterColumn("dbo.CityOfResidences", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.CityOfAssaults", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.BadDateReports", "YesNoNA", c => c.String(maxLength: 3));
            AlterColumn("dbo.AssignedWorkers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ages", "Range", c => c.String(maxLength: 20));
        }
    }
}
