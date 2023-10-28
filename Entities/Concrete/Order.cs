using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public short order_id { get; set; }
        public string customer_id { get; set; }
        public short employee_id { get; set; }
        public DateTime order_date { get; set; }
        public string ship_city { get; set; }
    }
}
