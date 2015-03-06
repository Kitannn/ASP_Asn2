using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(EthnicityMetaData))]
    public partial class Ethnicity { }
    
    public class EthnicityMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int EthnicityId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Ethnicity Description")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Description { get; set; }
    }
}