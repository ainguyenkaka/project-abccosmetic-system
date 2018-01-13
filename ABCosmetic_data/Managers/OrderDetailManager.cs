using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
    public class OrderDetailManager : AbstractManager<OrderDetail>
    {
       

        public OrderDetailManager() : base( Manager.GetDB().OrderDetails)
        {

        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public override bool Update(OrderDetail item)
        {
            return false;
        }

        public List<OrderDetail> GetDetailsByOrderID(int id)
        {
            var details = table.Where(s => s.OrderID == id).ToList();
            return details;
        }

        private List<OrderDetail> GetDetailsFromPayments(List<Payment> payments)
        {
            var details = new List<OrderDetail>();
            foreach (var pay in payments)
            {
                GetDetailsByOrderID(pay.OrderID).ForEach(s => details.Add(s));
            }
            return details;
        }

        public List<OrderDetail> GetDailyDetails()
        {
            var payments = new PaymentManager().GetDailyPayments();
            return GetDetailsFromPayments(payments);
        }

        public List<OrderDetail> GetWeeklyDetails()
        {
            var payments = new PaymentManager().GetWeeklyPayments();
            return GetDetailsFromPayments(payments);
        }

        public List<OrderDetail> GetDailyDetailsForAStaff(int staffID)
        { 
            var payments = new PaymentManager().GetDailyPaymentsForAStaff(staffID);
            return GetDetailsFromPayments(payments);
        }

        public List<OrderDetail> GetWeeklyDetailsForAStaff(int staffID)
        {
            var payments = new PaymentManager().GetWeeklyPaymentsForAStaff(staffID);
            return GetDetailsFromPayments(payments);
        }

        public List<OrderDetail> GetDailyDetailsForAStore(int storeID)
        {
            var payments = new PaymentManager().GetDailyPaymentsForAStore(storeID);
            return GetDetailsFromPayments(payments);
        }

        public List<OrderDetail> GetWeeklyDetailsForAStore(int storeID)
        {
            var payments = new PaymentManager().GetWeeklyPaymentsForAStore(storeID);
            return GetDetailsFromPayments(payments);
        }

    }
}
