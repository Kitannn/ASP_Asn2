using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(RiskStatusMetaData))]
    public partial class RiskStatus { }

    public class RiskStatusMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int RiskStatusId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Risk Status")]
        [MaxLength(10, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Status { get; set; }
    }
}