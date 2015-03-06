using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public class GoodSamaritanContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public GoodSamaritanContext()
            : base("name=GoodSamaritanConnection")
        {
        }

        public System.Data.Entity.DbSet<Asn_23.Models.Clients> Clients { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.AbuserRelationship> AbuserRelationships { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Age> Ages { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.AssignedWorker> AssignedWorkers { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Crisis> Crises { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.DuplicateFile> DuplicateFiles { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Ethnicity> Ethnicities { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.FamilyViolenceFile> FamilyViolenceFiles { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.FiscalYear> FiscalYears { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Incident> Incidents { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Program> Programs { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.ReferralContact> ReferralContacts { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.ReferralSource> ReferralSources { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.RepeatClient> RepeatClients { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.RiskLevel> RiskLevels { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.RiskStatus> RiskStatus { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Service> Services { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.StatusOfFile> StatusOfFiles { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.VictimOfIncident> VictimOfIncidents { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.Smart> Smarts { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.BadDateReport> BadDateReports { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.CityOfAssault> CityOfAssaults { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.CityOfResidence> CityOfResidences { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.DrugFacilitatedAssault> DrugFacilitatedAssaults { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.EvidenceStored> EvidenceStoreds { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.HIVMeds> HIVMeds { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.HospitalAttended> HospitalAttendeds { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.MedicalOnly> MedicalOnlies { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.MultiplePerpetrators> MultiplePerpetrators { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.PoliceAttendance> PoliceAttendances { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.PoliceReported> PoliceReporteds { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.ReferredToCBVS> ReferredToCBVS { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.ReferringHospital> ReferringHospitals { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.SexWorkExploitation> SexWorkExploitations { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.SocialWorkAttendance> SocialWorkAttendances { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.ThirdPartyReport> ThirdPartyReports { get; set; }

        public System.Data.Entity.DbSet<Asn_23.Models.VictimServicesAttendance> VictimServicesAttendances { get; set; }
    
    }
}
