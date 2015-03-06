using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    public partial class AbuserRelationship
    {
        public virtual int AbuserRelationshipId { get; set; }

        [MaxLength(50)]
        public virtual string Relationship { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}