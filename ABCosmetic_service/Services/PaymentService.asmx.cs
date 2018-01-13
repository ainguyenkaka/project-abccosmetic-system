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
    /// Summary description for PaymentService
    /// </summary>

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PaymentService : AbstractService<Payment>
    {
        public PaymentService() : base(new PaymentManager())
        {
        }
      
        [WebMethod]
        public Payment AddNew(string name, string des, int orderID, int staffID)
        {
            return manager.AddNew(new Payment { name = name, description = des, OrderID = orderID, UserID = staffID });
        }
    }
}
