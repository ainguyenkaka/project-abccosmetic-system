using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class OrderDetail : AbstractEntity
    {
        [Range(1, 10)]
        [Required]
        public int quantity { get; set; }


        [Required]
        public int ProductID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Product Product { get; set; }

        [Required]
        public int OrderID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Order Order { get; set; }

        public OrderDetail()
        {
            this.name = "";
        }
    }
}
