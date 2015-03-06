using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(ReferralContactMetaData))]
    public partial class ReferralContact { }

    public class ReferralContactMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int ReferralContactId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Referral Contact")]
        [MaxLength(20, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Contact { get; set; }
    }
}