using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(DrugFacilitatedAssaultMetaData))]
    public partial class DrugFacilitatedAssault { }

    public class DrugFacilitatedAssaultMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int DrugFacilitatedAssaultId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Drug Facilitated Assault Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}