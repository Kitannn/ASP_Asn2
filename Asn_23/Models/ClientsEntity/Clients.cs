using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class Clients
    {
        [Key]
        public int ClientReferenceNumber { get; set; }
        public virtual int FiscalYearId { get; set; }
        public virtual int Month { get; set; }
        public virtual int Day { get; set; }

        [MaxLength(50)]
        public virtual string Surname { get; set; }

        [MaxLength(50)]
        public virtual string FirstName { get; set; }

        [MaxLength(8)]
        public virtual string PoliceFileNumber { get; set; }
        public virtual int CourtFileNumber { get; set; }
        public virtual int SWCFileNumber { get; set; }
        public virtual int RiskLevelId { get; set; }
        public virtual int CrisisId { get; set; }
        public virtual int ServiceId { get; set; }
        public virtual int ProgramId { get; set; }

        [MaxLength(50)]
        public virtual string RiskAssessmentAssignedTo {get; set;}
        public virtual int RiskStatusId { get; set; }
        public virtual int AssignedWorkerId { get; set; }
        public virtual int ReferralSourceId { get; set; }
        public virtual int ReferralContactId { get; set; }
        public virtual int IncidentId { get; set; }

        [MaxLength(100)]
        public virtual string AbuserSurnameFirstName { get; set; }
        public virtual int AbuserRelationshipId { get; set; }
        public virtual int VictimOfIncidentId { get; set; }
        public virtual int FamilyViolenceFileId {get; set;}

        [MaxLength(5)]
        public virtual string Gender { get; set; }
        public virtual int EthnicityId { get; set; }
        public virtual int AgeId {get; set;}
        public virtual int RepeatClientId { get; set; }
        public virtual int DuplicateFileId { get; set; }
        public virtual int NumberOfChildren0to6 { get; set; }
        public virtual int NumberOfChildren7to12 { get; set; }
        public virtual int NumberOfChildren13to18 { get; set; }
        public virtual int StatusOfFileId { get; set; }
        public virtual DateTime DateLastTransferred { get; set; }
        public virtual DateTime DateClosed { get; set; }
        public virtual DateTime DateReOpened { get; set; }

        public virtual IEnumerable<Smart> Smart { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual RiskLevel RiskLevel { get; set; }
        public virtual Crisis Crisis { get; set; }
        public virtual Service Service { get; set; }
        public virtual Program Program { get; set; }
        public virtual RiskStatus RiskStatus { get; set; }
        public virtual AssignedWorker AssignedWorker { get; set; }
        public virtual ReferralSource ReferralSource { get; set; }
        public virtual ReferralContact ReferralContact { get; set; }
        public virtual Incident Incident { get; set; }
        public virtual AbuserRelationship AbuserRelationship { get; set; }
        public virtual VictimOfIncident VictimOfIncident { get; set; }
        public virtual FamilyViolenceFile FamilyViolenceFile { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        public virtual Age Age { get; set; }
        public virtual RepeatClient RepeatClient { get; set; }
        public virtual DuplicateFile DuplicateFile { get; set; }
        public virtual StatusOfFile StatusOfFile { get; set; }
    }
}