using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Category : AbstractEntity
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string image { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<Product> Products { get; set; }
    }
}