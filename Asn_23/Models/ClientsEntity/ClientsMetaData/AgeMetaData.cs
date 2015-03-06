using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(AgeMetaData))]
    public partial class Age { }
    
    public class AgeMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int AgeId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Age Range")]
        [MaxLength(20, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Range { get; set; }
    }
}