using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(EvidenceStoredMetaData))]
    public partial class EvidenceStored { }
    
    public class EvidenceStoredMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int EvidenceStoredId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Evidence Stored Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}