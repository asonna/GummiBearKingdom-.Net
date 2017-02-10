using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}
