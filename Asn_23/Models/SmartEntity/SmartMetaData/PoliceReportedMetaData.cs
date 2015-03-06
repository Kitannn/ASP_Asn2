using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(PoliceReportedMetaData))]
    public partial class PoliceReported { }

    public class PoliceReportedMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int PoliceReportedId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Police Reported Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}