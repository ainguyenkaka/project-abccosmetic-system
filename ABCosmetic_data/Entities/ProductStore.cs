using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class ProductStore : AbstractEntity
    {
        [Required]
        public int quantity { get; set; }

        [Required]
        public int StoreID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Store Store { get; set; }

        [Required]
        public int ProductID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Product Product { get; set; }

        public ProductStore()
        {
            this.name = "";

        }
    }
}
