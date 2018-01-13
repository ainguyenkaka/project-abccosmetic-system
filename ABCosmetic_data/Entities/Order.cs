using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABCosmetic_data.Entities
{
   public  class Order : AbstractEntity
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }
        
        [Required]
        public decimal total { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string description { get; set; }

        [XmlIgnoreAttribute]
        public virtual List<OrderDetail> OrderDetails { get; set; }

        [Required]
        public int StatusID { get; set; }

        [XmlIgnoreAttribute]
        public virtual Status Status { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [XmlIgnoreAttribute]
        public virtual User Customer { get; set; }

        [Required]
        public int StaffID { get; set; }

        [XmlIgnoreAttribute]
        public virtual User Staff { get; set; }


        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
            this.date = DateTime.Now;
            this.StatusID = 1;
            this.total = 0;
        }
    }
}
