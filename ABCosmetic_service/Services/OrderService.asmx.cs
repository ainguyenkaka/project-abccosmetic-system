using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ABCosmetic_data.Managers;

namespace ABCosmetic_service.Services
{
    /// <summary>
    /// Summary description for OrderService
    /// </summary>
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrderService : AbstractService<Order>
    {
        private OrderManager om;
        public OrderService() : base(new OrderManager())
        {
            om = manager as OrderManager;
        }

        [WebMethod]
        public Order AddNew(string title, string content, int cId, int staffID, decimal total)
        {
            return manager.AddNew(new Order { name = title, description = content, CustomerID = cId, StaffID = staffID, total = total });
        }
        [WebMethod]
        public List<Order> GetOrdersByCustomerID(int id)
        {
            return om.GetOrdersByCustomerID(id);
        }

        [WebMethod]
        public bool ChangeOrderToPaied(int id)
        {
            return om.ChangeOrderToPaied(id);
        }

        [WebMethod]
        public List<Order> GetDailyOrders()
        {
            return om.GetDailyOrders();
        }

        [WebMethod]
        public List<Order> GetWeeklyOrders()
        {
            return om.GetWeeklyOrders();
        }

        [WebMethod]
        public List<Order> GetDailyOrdersForAStaff( int staffID)
        {
            return om.GetDailyOrdersForAStaff(staffID);
        }

        [WebMethod]
        public List<Order> GetWeeklyOrdersForAStaff(int staffID)
        {
            return om.GetWeekyOrdersForAStaff(staffID);
        }

        [WebMethod]
        public List<Order> GetDailyOrdersForAStore(int storeID)
        {
            return om.GetDailyOrdersForAStore(storeID);
        }

        [WebMethod]
        public bool UpdateTotalPrice(int id, decimal total)
        {
            var order = GetByID(id);
            order.total = total;
            return manager.Update(order);
        }

        [WebMethod]
        public List<Order> GetWeeklyOrdersForAStore(int storeID)
        {
            return om.GetWeeklyOrdersForAStore(storeID);
        }

    }
}
