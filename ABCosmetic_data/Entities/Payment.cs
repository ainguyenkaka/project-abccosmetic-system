using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
    public class Payment : AbstractEntity
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string description { get; set; }

        [Required]
        public int OrderID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Order Order { get; set; }

        [Required]
        public int UserID { get; set; }

        [XmlIgnoreAttribute]
        public virtual User User { get; set; }

        public Payment()
        {
            this.name = "";
            this.date = DateTime.Now;

        }
    }
}
