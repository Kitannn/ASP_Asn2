using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class DuplicateFile
    {
        public virtual int DuplicateFileId { get; set; }

        [MaxLength(3)]
        public virtual string YesOrNull { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}