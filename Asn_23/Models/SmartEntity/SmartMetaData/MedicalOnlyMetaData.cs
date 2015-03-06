using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(MedicalOnlyMetaData))]
    public partial class MedicalOnly { }
    
    public class MedicalOnlyMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int MedicalOnlyId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Medical Only Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}