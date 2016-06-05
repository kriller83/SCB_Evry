using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_SCB.Models
{
    public class Gender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenderId { get; set; }
        public string Name { get; set; }
    }
}