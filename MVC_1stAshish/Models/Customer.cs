using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1stAshish.Models
{
    public class customer
    {                  [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE{ get; set; }
        public Location location{ get; set; }
       
    }
}
