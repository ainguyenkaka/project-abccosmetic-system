using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCosmetic_app.Models
{
    public class DailyWeeklyProduct
    {
        public List<QuantityProduct> daily { get; set; }
        public List<QuantityProduct> weekly { get; set; }

        public DailyWeeklyProduct()
        {
            this.daily = new List<QuantityProduct>();
            this.weekly = new List<QuantityProduct>();
        }
    }
}