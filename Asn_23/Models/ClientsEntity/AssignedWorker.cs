using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    public partial class AssignedWorker
    {
        public virtual int AssignedWorkerId { get; set; }

        [MaxLength(50)]
        public virtual string Name {get; set;}

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}