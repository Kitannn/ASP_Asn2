using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(FiscalYearMetaData))]
    public partial class FiscalYear { }
    
    public class FiscalYearMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int FiscalYearId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Fiscal Year")]
        [MaxLength(5, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Years { get; set; }
    }
}