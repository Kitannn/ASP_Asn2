using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Asn_23.Models
{
    [MetadataType(typeof(AbuserRelationshipMetaData))]
    public partial class AbuserRelationship {}

    public class AbuserRelationshipMetaData
    {
        [HiddenInput(DisplayValue=false)]
        public virtual int AbuserRelationshipId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Abuser Relationship")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Relationship { get; set; }
    }
}