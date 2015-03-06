using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(CrisisMetaData))]
    public partial class Crisis { }

    public class CrisisMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int CrisisId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Crisis Type")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Type { get; set; }
    }
}