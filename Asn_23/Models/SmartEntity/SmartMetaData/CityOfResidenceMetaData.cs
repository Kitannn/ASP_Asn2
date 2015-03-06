using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(CityOfResidenceMetaData))]
    public partial class CityOfResidence { }

    public class CityOfResidenceMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int CityOfResidenceId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "City Of Residence")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string City { get; set; }
    }
}