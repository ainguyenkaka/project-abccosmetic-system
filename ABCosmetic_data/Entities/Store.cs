using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Store : AbstractEntity
    {

        [XmlIgnoreAttribute]
        public virtual List<User> Users { get; set; }

        [Required]
        public int CountryID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Country Country { get; set; }

        [XmlIgnoreAttribute]
        public List<ProductStore> ProductStores { get; set; }

        public Store()
        {
            this.Users = new List<User>();
        }
    }
}
