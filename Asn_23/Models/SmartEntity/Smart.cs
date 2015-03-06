using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public class Smart
    {
        [Key]
        public virtual int SmartId { get; set; }
        public virtual int ClientReferenceNumber { get; set; }
        public virtual int SexWorkExploitationId { get; set; }
        public virtual int MultiplePerpetratorsId { get; set; }
        public virtual int DrugFacilitatedAssaultId { get; set; }
        public virtual int CityOfAssaultId { get; set; }
        public virtual int CityOfResidenceId { get; set; }
        public virtual int AccompanimnetMinutes { get; set; }
        public virtual int ReferringHospitalId { get; set; }
        public virtual int HospitalAttendedId { get; set; }
        public virtual int SocialWorkAttendanceId { get; set; }
        public virtual int PoliceAttendanceId { get; set; }
        public virtual int VictimServiceAttendanceId { get; set; }
        public virtual int MedicalOnlyId { get; set; }
        public virtual int EvidenceStoredId { get; set; }
        public virtual int HIVMedsId { get; set; }
        public virtual int ReferredToCBVSId { get; set; }
        public virtual int PoliceReportedId { get; set; }
        public virtual int ThirdPartyReportId { get; set; }
        public virtual int BadDateReportId { get; set; }
        public virtual bool ReferredToNursePractitioner { get; set; }


        public virtual Clients Clients { get; set; }
        public virtual SexWorkExploitation SexWorkExploitation { get; set; }
        public virtual MultiplePerpetrators MultiplePerpetrators { get; set; }
        public virtual DrugFacilitatedAssault DrugFacilitatedAssault { get; set; }
        public virtual CityOfAssault CityOfAssault { get; set; }
        public virtual CityOfResidence CityOfResidence { get; set; }
        public virtual ReferringHospital ReferringHospital { get; set; }
        public virtual HospitalAttended HospitalAttended { get; set; }
        public virtual SocialWorkAttendance SocialWorkAttendance { get; set; }
        public virtual PoliceAttendance PoliceAttendance { get; set; }
        public virtual VictimServicesAttendance VictimServicesAttendance { get; set; }
        public virtual MedicalOnly MedicalOnly { get; set; }
        public virtual EvidenceStored EvidenceStored { get; set; }
        public virtual HIVMeds HIVMeds { get; set; }
        public virtual ReferredToCBVS ReferredToCBVS { get; set; }
        public virtual PoliceReported PoliceReported { get; set; }
        public virtual ThirdPartyReport ThirdPartyReport { get; set; }
        public virtual BadDateReport BadDateReport { get; set; }
    }
}