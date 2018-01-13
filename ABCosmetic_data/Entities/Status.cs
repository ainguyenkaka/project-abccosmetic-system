using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Status : AbstractEntity
    {
        [XmlIgnoreAttribute]
        public virtual List<Order> Orders { get; set; }
    }
}
