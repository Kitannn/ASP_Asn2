using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(AssignedWorkerMetaData))]
    public partial class AssignedWorker { }
    
    public class AssignedWorkerMetaData
    {
        [HiddenInput(DisplayValue=false)]
        public virtual int AssignedWorkerId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name="Assigned Worker Name")]
        [MaxLength(50, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Name { get; set; }
    }
}