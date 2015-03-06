using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(IncidentMetaData))]
    public partial class Incident { }

    public class IncidentMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int IncidentId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Incident Type")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Type { get; set; }
    }
}