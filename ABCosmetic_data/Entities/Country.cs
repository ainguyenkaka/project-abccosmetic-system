using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Country : AbstractEntity
    {
        [Required]
        public String code { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<Store> Stores { get; set; }

        public Country()
        {
            this.Stores = new List<Store>();
        }
    }
}
