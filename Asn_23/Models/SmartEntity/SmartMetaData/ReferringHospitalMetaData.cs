using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(ReferringHospitalMetaData))]
    public partial class ReferringHospital { }

    public class ReferringHospitalMetaData
    {
        [HiddenInput(DisplayValue=false)]
        public virtual int ReferringHospitalId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Referring Hospital Name")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string HospitalName { get; set; }
    }
}