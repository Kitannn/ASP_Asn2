using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class RiskLevel
    {
        public virtual int RiskLevelId { get; set; }

        [MaxLength(10)]
        public virtual string Level { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}