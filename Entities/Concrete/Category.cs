using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public short category_id { get; set; }
        public string category_name { get; set; }
    }
}
