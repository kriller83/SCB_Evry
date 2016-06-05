using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace MVC_SCB.Models
{
    public class Multiplicity
    {
        public int MultiplicityId { get; set; }
        public int MultiplicityCode { get; set; }

        public virtual List<BirthRate> BirthRates { get; set; } = new List<BirthRate>();
        public virtual MultiplicityName MultiplicityName { get; set; }
        public int MultiplicityNameId { get; set; }
    }
}

// Födda per år och kommun.