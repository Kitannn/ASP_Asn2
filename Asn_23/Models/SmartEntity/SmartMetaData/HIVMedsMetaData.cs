using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(HIVMedsMetaData))]
    public partial class HIVMeds { }

    public class HIVMedsMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int HIVMedsId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "HIV Meds Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}