using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class CityOfResidence
    {
        public virtual int CityOfResidenceId { get; set; }

        [MaxLength(50)]
        public virtual string City { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}