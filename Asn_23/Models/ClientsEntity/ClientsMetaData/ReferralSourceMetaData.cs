using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(ReferralSourceMetaData))]
    public partial class ReferralSource { }
    
    public class ReferralSourceMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int ReferralSourceId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Referral Source")]
        [MaxLength(20, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Source { get; set; }
    }
}