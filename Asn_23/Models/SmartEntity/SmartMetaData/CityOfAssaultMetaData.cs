using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(CityOfAssaultMetaData))]
    public partial class CityOfAssault { }

    public class CityOfAssaultMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int CityOfAssaultId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "City Of Assault")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string City { get; set; }
    }
}