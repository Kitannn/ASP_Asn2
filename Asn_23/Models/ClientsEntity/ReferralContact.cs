using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class ReferralContact
    {
        public virtual int ReferralContactId { get; set; }

        [MaxLength(20)]
        public virtual string Contact { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}