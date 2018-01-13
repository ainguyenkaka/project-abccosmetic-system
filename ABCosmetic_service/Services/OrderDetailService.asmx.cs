using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ABCosmetic_data.Managers;
using ABCosmetic_data.Entities;

namespace ABCosmetic_service.Services
{
    /// <summary>
    /// Summary description for OrderDetailService
    /// </summary>
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrderDetailService : AbstractService<OrderDetail>
    {
        private OrderDetailManager odm;
        public OrderDetailService() : base(new OrderDetailManager())
        {
            odm = manager as OrderDetailManager; 
        }


        [WebMethod]
        public OrderDetail AddNew(int orderID, int productID, int quantity)
        {
            return manager.AddNew(new OrderDetail { OrderID = orderID, ProductID = productID, quantity = quantity });
        }

        [WebMethod]
        public List<OrderDetail> GetDetailsByOrderID(int id)
        {
            
            return odm.GetDetailsByOrderID(id);
        }

        [WebMethod]
        public List<OrderDetail> GetDailyDetails()
        {
            return odm.GetDailyDetails();
        }

        [WebMethod]
        public List<OrderDetail> GetWeeklyDetails()
        {
            return odm.GetWeeklyDetails();
        }

        [WebMethod]
        public List<OrderDetail> GetDailyDetailsForAStaff(int staffID)
        {
            return odm.GetDailyDetailsForAStaff(staffID);
        }

        [WebMethod]
        public List<OrderDetail> GetWeeklyDetailsForAStaff(int staffID)
        {
            return odm.GetWeeklyDetailsForAStaff(staffID);
        }

        [WebMethod]
        public List<OrderDetail> GetDailyDetailsForAStore(int storeID)
        {
            return odm.GetDailyDetailsForAStore(storeID);
        }

        [WebMethod]
        public List<OrderDetail> GetWeeklyDetailsForAStore(int storeID)
        {
            return odm.GetWeeklyDetailsForAStore(storeID);
        }

    }
}
