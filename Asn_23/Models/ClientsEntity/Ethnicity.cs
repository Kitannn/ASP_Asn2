using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class Ethnicity
    {
        public virtual int EthnicityId { get; set; }

        [MaxLength(50)]
        public virtual string Description { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}