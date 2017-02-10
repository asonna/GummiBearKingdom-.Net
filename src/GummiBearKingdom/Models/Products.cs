using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int cost { get; set; }
        public string OriginCountry { get; set; }
        //public virtual Product Product { get; set; }

    }
}
