using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class User : AbstractEntity
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8)]
        public string password { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string avatar { get; set; }

        [Required]
        public int RoleID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Role Role { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<Order> Orders { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<Payment> Payments { get; set; }

        public int? StoreID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Store Store { get; set; }

        public User()
        {

        }
    }
}
