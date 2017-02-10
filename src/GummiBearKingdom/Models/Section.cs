using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
    [Table("Sections")]
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}
