using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Role : AbstractEntity
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        [XmlIgnoreAttribute]
        public virtual List<User> Users { get; set; }
    }
}
