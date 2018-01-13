using ABCosmetic_app.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCosmetic_app.Models
{
    public class DailyWeeklyOrder
    {
        public List<Order> daily { get; set; }
        public List<Order> weekly { get; set; }

        public DailyWeeklyOrder()
        {
            daily = new List<Order>();
            weekly = new List<Order>();
        }
    }
}