using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(FamilyViolenceFileMetaData))]
    public partial class FamilyViolenceFile { }
    
    public class FamilyViolenceFileMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int FamilyViolenceFileId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Family Violence File Status")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string FileExists { get; set; }
    }
}