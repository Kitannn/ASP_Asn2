using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(RiskLevelMetaData))]
    public partial class RiskLevel { }

    public class RiskLevelMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int RiskLevelId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Risk Level")]
        [MaxLength(10, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Level { get; set; }
    }
}