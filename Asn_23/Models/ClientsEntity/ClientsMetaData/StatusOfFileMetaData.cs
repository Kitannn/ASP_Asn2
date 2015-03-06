using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(StatusOfFileMetaData))]
    public partial class StatusOfFile { }

    public class StatusOfFileMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int StatusOfFileId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "File Status")]
        [MaxLength(10, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Status { get; set; }
    }
}