using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Brand : AbstractEntity
    {

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string image { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<Product> Products { get; set; }
    }
}
