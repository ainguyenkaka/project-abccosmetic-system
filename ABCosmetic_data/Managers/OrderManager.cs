using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
   public class OrderManager : AbstractManager<Order>
    {
      

        public OrderManager() : base( Manager.GetDB().Orders)
        {

        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public override bool Update(Order item)
        {
            return false;
        }

        public List<Order> GetOrdersByCustomerID(int id)
        {
            var orders = table.Where(s => s.CustomerID == id).ToList();
            return orders;
        }

        public bool ChangeOrderToPaied(int id)
        {
            Order order = GetByID(id);
            if(order != null)
            {
                order.StatusID = 3;
            }
            return SaveChanges();
        }

       
        public List<Order> GetDailyOrdersForAStaff(int staffID)
        {
            int year = DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var oders = GetOrdersForAStaff(staffID).Where(s=> s.date.Year == year && s.date.DayOfYear == days).ToList();
            return oders;
        }

        public List<Order> GetWeekyOrdersForAStaff(int staffID)
        {
            int year = DateTime.Now.Year;
            int week = ConverterManager.GetWeek(DateTime.Now);
            var oders = GetOrdersForAStaff(staffID).Where(s=> s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return oders;
        }

        public List<Order> GetOrdersForAStaff(int staffID)
        {
            var oders = table.Where(s => s.StaffID == staffID ).ToList();
            return oders;
        }

        public List<Order> GetDailyOrders()
        {
            int year = DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var oders = table.ToList().Where(s =>s.date.Year == year && s.date.DayOfYear == days).ToList();
            return oders;
        }

        public List<Order> GetWeeklyOrders()
        {
            int year = DateTime.Now.Year;
            var week = ConverterManager.GetWeek(DateTime.Now);
            var oders = table.ToList().Where(s => s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return oders;
        }

        public List<Order> GetDailyOrdersForAStore(int storeID)
        {
            int year =DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var orders = GetOrdersByStoreID(storeID).Where(s => s.date.Year == year && s.date.DayOfYear == days).ToList();
            return orders;
        }

        public List<Order> GetWeeklyOrdersForAStore(int storeID)
        {
            int year = DateTime.Now.Year;
            int week = ConverterManager.GetWeek(DateTime.Now);
            var orders = GetOrdersByStoreID(storeID).Where(s => s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return orders;
        }


        private List<Order> GetOrdersByStoreID(int storeID)
        {
            var orders = table.ToList().Where(s => InStore(s.id, storeID)).ToList();
            return orders;
        }

        private bool InStore(int orderID, int storeID)
        {
            var staffs = new UserManager().GetStaffsByStoreID(storeID);
            var order = GetByID(orderID);
            foreach(var item in staffs)
            {
                if (item.id == order.StaffID)
                    return true;
            }
            return false;
        }
      
        public bool IsPaied(int id)
        {
           var order =  GetByID(id);
           if(order != null)
            {
                return order.StatusID == 3;
            }
            return false;
        }
    }
}
