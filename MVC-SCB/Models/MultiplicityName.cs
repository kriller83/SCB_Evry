using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

// http://stackoverflow.com/questions/23005451/how-to-manually-set-entity-primary-key-in-entity-framework-code-first-database
namespace MVC_SCB.Models
{
    public class MultiplicityName
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MultiplicityNameId { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Multiplicity> Multiplicities { get; set; }
        public int MultiplicityCode => MultiplicityNameId;

        public MultiplicityName()
        {

        }

        public MultiplicityName(int multiplicityCode, string name)
        {
            MultiplicityNameId = multiplicityCode;
            Name = name;
        }
    }
}
