namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        Relationship = c.String(),
                    })
                .PrimaryKey(t => t.AbuserRelationshipId);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Range = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkers",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.BadDateReports",
                c => new
                    {
                        BadDateReportId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.Smarts",
                c => new
                    {
                        SmartId = c.Int(nullable: false, identity: true),
                        ClientReferenceNumber = c.Int(nullable: false),
                        SexWorkExploitationId = c.Int(nullable: false),
                        MultiplePerpetratorsId = c.Int(nullable: false),
                        DrugFacilitatedAssaultId = c.Int(nullable: false),
                        CityOfAssaultId = c.Int(nullable: false),
                        CityOfResidenceId = c.Int(nullable: false),
                        AccompanimnetMinutes = c.Int(nullable: false),
                        ReferringHospitalId = c.Int(nullable: false),
                        HospitalAttendedId = c.Int(nullable: false),
                        SocialWorkAttendanceId = c.Int(nullable: false),
                        PoliceAttendanceId = c.Int(nullable: false),
                        VictimServiceAttendanceId = c.Int(nullable: false),
                        MedicalOnlyId = c.Int(nullable: false),
                        EvidenceStoredId = c.Int(nullable: false),
                        HIVMedsId = c.Int(nullable: false),
                        ReferredToCBVSId = c.Int(nullable: false),
                        PoliceReportedId = c.Int(nullable: false),
                        ThirdPartyReportId = c.Int(nullable: false),
                        BadDateReportId = c.Int(nullable: false),
                        ReferredToNursePractitioner = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SmartId)
                .ForeignKey("dbo.BadDateReports", t => t.BadDateReportId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfAssaults", t => t.CityOfAssaultId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfResidences", t => t.CityOfResidenceId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientReferenceNumber, cascadeDelete: true)
                .ForeignKey("dbo.DrugFacilitatedAssaults", t => t.DrugFacilitatedAssaultId, cascadeDelete: true)
                .ForeignKey("dbo.EvidenceStoreds", t => t.EvidenceStoredId, cascadeDelete: true)
                .ForeignKey("dbo.HIVMeds", t => t.HIVMedsId, cascadeDelete: true)
                .ForeignKey("dbo.HospitalAttendeds", t => t.HospitalAttendedId, cascadeDelete: true)
                .ForeignKey("dbo.MedicalOnlies", t => t.MedicalOnlyId, cascadeDelete: true)
                .ForeignKey("dbo.MultiplePerpetrators", t => t.MultiplePerpetratorsId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceAttendances", t => t.PoliceAttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceReporteds", t => t.PoliceReportedId, cascadeDelete: true)
                .ForeignKey("dbo.ReferredToCBVS", t => t.ReferredToCBVSId, cascadeDelete: true)
                .ForeignKey("dbo.ReferringHospitals", t => t.ReferringHospitalId, cascadeDelete: true)
                .ForeignKey("dbo.SexWorkExploitations", t => t.SexWorkExploitationId, cascadeDelete: true)
                .ForeignKey("dbo.SocialWorkAttendances", t => t.SocialWorkAttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdPartyReports", t => t.ThirdPartyReportId, cascadeDelete: true)
                .Index(t => t.ClientReferenceNumber)
                .Index(t => t.SexWorkExploitationId)
                .Index(t => t.MultiplePerpetratorsId)
                .Index(t => t.DrugFacilitatedAssaultId)
                .Index(t => t.CityOfAssaultId)
                .Index(t => t.CityOfResidenceId)
                .Index(t => t.ReferringHospitalId)
                .Index(t => t.HospitalAttendedId)
                .Index(t => t.SocialWorkAttendanceId)
                .Index(t => t.PoliceAttendanceId)
                .Index(t => t.MedicalOnlyId)
                .Index(t => t.EvidenceStoredId)
                .Index(t => t.HIVMedsId)
                .Index(t => t.ReferredToCBVSId)
                .Index(t => t.PoliceReportedId)
                .Index(t => t.ThirdPartyReportId)
                .Index(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.CityOfAssaults",
                c => new
                    {
                        CityOfAssaultId = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CityOfAssaultId);
            
            CreateTable(
                "dbo.CityOfResidences",
                c => new
                    {
                        CityOfResidenceId = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CityOfResidenceId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        FiscalYearId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        SWCFileNumber = c.Int(nullable: false),
                        RiskLevelId = c.Int(nullable: false),
                        CrisisId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        RiskAssessmentAssignedTo = c.String(),
                        RiskStatusId = c.Int(nullable: false),
                        AssignedWorkerId = c.Int(nullable: false),
                        ReferralSourceId = c.Int(nullable: false),
                        ReferralContactId = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                        AbuserSurnameFirstName = c.String(),
                        AbuserRelationshipId = c.Int(nullable: false),
                        VictimOfIncidentId = c.Int(nullable: false),
                        FamilyViolenceFileId = c.Int(nullable: false),
                        Gender = c.String(),
                        EthnicityId = c.Int(nullable: false),
                        AgeId = c.Int(nullable: false),
                        RepeatClientId = c.Int(nullable: false),
                        DuplicateFileId = c.Int(nullable: false),
                        NumberOfChildren0to6 = c.Int(nullable: false),
                        NumberOfChildren7to12 = c.Int(nullable: false),
                        NumberOfChildren13to18 = c.Int(nullable: false),
                        StatusOfFileId = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReOpened = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.Ages", t => t.AgeId, cascadeDelete: true)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorkerId, cascadeDelete: true)
                .ForeignKey("dbo.Crises", t => t.CrisisId, cascadeDelete: true)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFileId, cascadeDelete: true)
                .ForeignKey("dbo.Ethnicities", t => t.EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFileId, cascadeDelete: true)
                .ForeignKey("dbo.FiscalYears", t => t.FiscalYearId, cascadeDelete: true)
                .ForeignKey("dbo.Incidents", t => t.IncidentId, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralContacts", t => t.ReferralContactId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralSources", t => t.ReferralSourceId, cascadeDelete: true)
                .ForeignKey("dbo.RepeatClients", t => t.RepeatClientId, cascadeDelete: true)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevelId, cascadeDelete: true)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.StatusOfFiles", t => t.StatusOfFileId, cascadeDelete: true)
                .ForeignKey("dbo.VictimOfIncidents", t => t.VictimOfIncidentId, cascadeDelete: true)
                .Index(t => t.FiscalYearId)
                .Index(t => t.RiskLevelId)
                .Index(t => t.CrisisId)
                .Index(t => t.ServiceId)
                .Index(t => t.ProgramId)
                .Index(t => t.RiskStatusId)
                .Index(t => t.AssignedWorkerId)
                .Index(t => t.ReferralSourceId)
                .Index(t => t.ReferralContactId)
                .Index(t => t.IncidentId)
                .Index(t => t.AbuserRelationshipId)
                .Index(t => t.VictimOfIncidentId)
                .Index(t => t.FamilyViolenceFileId)
                .Index(t => t.EthnicityId)
                .Index(t => t.AgeId)
                .Index(t => t.RepeatClientId)
                .Index(t => t.DuplicateFileId)
                .Index(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFiles",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        YesOrNull = c.String(),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.FamilyViolenceFiles",
                c => new
                    {
                        FamilyViolenceFileId = c.Int(nullable: false, identity: true),
                        FileExists = c.String(),
                    })
                .PrimaryKey(t => t.FamilyViolenceFileId);
            
            CreateTable(
                "dbo.FiscalYears",
                c => new
                    {
                        FiscalYearId = c.Int(nullable: false, identity: true),
                        Years = c.String(),
                    })
                .PrimaryKey(t => t.FiscalYearId);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.ReferralContacts",
                c => new
                    {
                        ReferralContactId = c.Int(nullable: false, identity: true),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.ReferralContactId);
            
            CreateTable(
                "dbo.ReferralSources",
                c => new
                    {
                        ReferralSourceId = c.Int(nullable: false, identity: true),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClients",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        YesOrNull = c.String(),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
            CreateTable(
                "dbo.RiskLevels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatus",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        File = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.StatusOfFiles",
                c => new
                    {
                        StatusOfFileId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.VictimOfIncidents",
                c => new
                    {
                        VictimOfIncidentId = c.Int(nullable: false, identity: true),
                        PrimaryOrSecondary = c.String(),
                    })
                .PrimaryKey(t => t.VictimOfIncidentId);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaults",
                c => new
                    {
                        DrugFacilitatedAssaultId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssaultId);
            
            CreateTable(
                "dbo.EvidenceStoreds",
                c => new
                    {
                        EvidenceStoredId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.EvidenceStoredId);
            
            CreateTable(
                "dbo.HIVMeds",
                c => new
                    {
                        HIVMedsId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.HIVMedsId);
            
            CreateTable(
                "dbo.HospitalAttendeds",
                c => new
                    {
                        HospitalAttendedId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(),
                    })
                .PrimaryKey(t => t.HospitalAttendedId);
            
            CreateTable(
                "dbo.MedicalOnlies",
                c => new
                    {
                        MedicalOnlyId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.MedicalOnlyId);
            
            CreateTable(
                "dbo.MultiplePerpetrators",
                c => new
                    {
                        MultiplePerpetratorsId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.MultiplePerpetratorsId);
            
            CreateTable(
                "dbo.PoliceAttendances",
                c => new
                    {
                        PoliceAttendanceId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.PoliceAttendanceId);
            
            CreateTable(
                "dbo.PoliceReporteds",
                c => new
                    {
                        PoliceReportedId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.PoliceReportedId);
            
            CreateTable(
                "dbo.ReferredToCBVS",
                c => new
                    {
                        ReferredToCBVSId = c.Int(nullable: false, identity: true),
                        YesNoPVBSOnlyNA = c.String(),
                    })
                .PrimaryKey(t => t.ReferredToCBVSId);
            
            CreateTable(
                "dbo.ReferringHospitals",
                c => new
                    {
                        ReferringHospitalId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(),
                    })
                .PrimaryKey(t => t.ReferringHospitalId);
            
            CreateTable(
                "dbo.SexWorkExploitations",
                c => new
                    {
                        SexWorkExploitationId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.SexWorkExploitationId);
            
            CreateTable(
                "dbo.SocialWorkAttendances",
                c => new
                    {
                        SocialWorkAttendanceId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.SocialWorkAttendanceId);
            
            CreateTable(
                "dbo.ThirdPartyReports",
                c => new
                    {
                        ThirdPartyReportId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.ThirdPartyReportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "ThirdPartyReportId", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendanceId", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "SexWorkExploitationId", "dbo.SexWorkExploitations");
            DropForeignKey("dbo.Smarts", "ReferringHospitalId", "dbo.ReferringHospitals");
            DropForeignKey("dbo.Smarts", "ReferredToCBVSId", "dbo.ReferredToCBVS");
            DropForeignKey("dbo.Smarts", "PoliceReportedId", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendanceId", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiplePerpetratorsId", "dbo.MultiplePerpetrators");
            DropForeignKey("dbo.Smarts", "MedicalOnlyId", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttendedId", "dbo.HospitalAttendeds");
            DropForeignKey("dbo.Smarts", "HIVMedsId", "dbo.HIVMeds");
            DropForeignKey("dbo.Smarts", "EvidenceStoredId", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugFacilitatedAssaultId", "dbo.DrugFacilitatedAssaults");
            DropForeignKey("dbo.Smarts", "ClientReferenceNumber", "dbo.Clients");
            DropForeignKey("dbo.Clients", "VictimOfIncidentId", "dbo.VictimOfIncidents");
            DropForeignKey("dbo.Clients", "StatusOfFileId", "dbo.StatusOfFiles");
            DropForeignKey("dbo.Clients", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatusId", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevelId", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "RepeatClientId", "dbo.RepeatClients");
            DropForeignKey("dbo.Clients", "ReferralSourceId", "dbo.ReferralSources");
            DropForeignKey("dbo.Clients", "ReferralContactId", "dbo.ReferralContacts");
            DropForeignKey("dbo.Clients", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Clients", "IncidentId", "dbo.Incidents");
            DropForeignKey("dbo.Clients", "FiscalYearId", "dbo.FiscalYears");
            DropForeignKey("dbo.Clients", "FamilyViolenceFileId", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "DuplicateFileId", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "CrisisId", "dbo.Crises");
            DropForeignKey("dbo.Clients", "AssignedWorkerId", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "AgeId", "dbo.Ages");
            DropForeignKey("dbo.Clients", "AbuserRelationshipId", "dbo.AbuserRelationships");
            DropForeignKey("dbo.Smarts", "CityOfResidenceId", "dbo.CityOfResidences");
            DropForeignKey("dbo.Smarts", "CityOfAssaultId", "dbo.CityOfAssaults");
            DropForeignKey("dbo.Smarts", "BadDateReportId", "dbo.BadDateReports");
            DropIndex("dbo.Clients", new[] { "StatusOfFileId" });
            DropIndex("dbo.Clients", new[] { "DuplicateFileId" });
            DropIndex("dbo.Clients", new[] { "RepeatClientId" });
            DropIndex("dbo.Clients", new[] { "AgeId" });
            DropIndex("dbo.Clients", new[] { "EthnicityId" });
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFileId" });
            DropIndex("dbo.Clients", new[] { "VictimOfIncidentId" });
            DropIndex("dbo.Clients", new[] { "AbuserRelationshipId" });
            DropIndex("dbo.Clients", new[] { "IncidentId" });
            DropIndex("dbo.Clients", new[] { "ReferralContactId" });
            DropIndex("dbo.Clients", new[] { "ReferralSourceId" });
            DropIndex("dbo.Clients", new[] { "AssignedWorkerId" });
            DropIndex("dbo.Clients", new[] { "RiskStatusId" });
            DropIndex("dbo.Clients", new[] { "ProgramId" });
            DropIndex("dbo.Clients", new[] { "ServiceId" });
            DropIndex("dbo.Clients", new[] { "CrisisId" });
            DropIndex("dbo.Clients", new[] { "RiskLevelId" });
            DropIndex("dbo.Clients", new[] { "FiscalYearId" });
            DropIndex("dbo.Smarts", new[] { "BadDateReportId" });
            DropIndex("dbo.Smarts", new[] { "ThirdPartyReportId" });
            DropIndex("dbo.Smarts", new[] { "PoliceReportedId" });
            DropIndex("dbo.Smarts", new[] { "ReferredToCBVSId" });
            DropIndex("dbo.Smarts", new[] { "HIVMedsId" });
            DropIndex("dbo.Smarts", new[] { "EvidenceStoredId" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnlyId" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttendedId" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospitalId" });
            DropIndex("dbo.Smarts", new[] { "CityOfResidenceId" });
            DropIndex("dbo.Smarts", new[] { "CityOfAssaultId" });
            DropIndex("dbo.Smarts", new[] { "DrugFacilitatedAssaultId" });
            DropIndex("dbo.Smarts", new[] { "MultiplePerpetratorsId" });
            DropIndex("dbo.Smarts", new[] { "SexWorkExploitationId" });
            DropIndex("dbo.Smarts", new[] { "ClientReferenceNumber" });
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.SexWorkExploitations");
            DropTable("dbo.ReferringHospitals");
            DropTable("dbo.ReferredToCBVS");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerpetrators");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.HospitalAttendeds");
            DropTable("dbo.HIVMeds");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugFacilitatedAssaults");
            DropTable("dbo.VictimOfIncidents");
            DropTable("dbo.StatusOfFiles");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.RepeatClients");
            DropTable("dbo.ReferralSources");
            DropTable("dbo.ReferralContacts");
            DropTable("dbo.Programs");
            DropTable("dbo.Incidents");
            DropTable("dbo.FiscalYears");
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.Crises");
            DropTable("dbo.Clients");
            DropTable("dbo.CityOfResidences");
            DropTable("dbo.CityOfAssaults");
            DropTable("dbo.Smarts");
            DropTable("dbo.BadDateReports");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
