using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Product : AbstractEntity
    {
        [Required]
        [Range(100, 5000)]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        [Range(1, 100)]
        [Required]
        public int quantity { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string description { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string image { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Category Category { get; set; }

        [Required]
        public int BrandID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Brand Brand { get; set; }

        [XmlIgnoreAttribute]
        public List<OrderDetail> OrderDetails { get; set; }

        [XmlIgnoreAttribute]
        public List<ProductStore> ProductStores { get; set; }

        public Product()
        {

        }

        
    }
}
