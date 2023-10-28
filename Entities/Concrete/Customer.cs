using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public string customer_id { get; set; }
        public string contact_name { get; set; }
        public string company_name { get; set; }
        public string city { get; set; }
    }
}
