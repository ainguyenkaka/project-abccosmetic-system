using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
    public class PaymentManager : AbstractManager<Payment>
    {
       

        public PaymentManager() : base(Manager.GetDB().Payments)
        {

        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }


        public override bool Update(Payment item)
        {
            return false;
        }


        public List<Payment> GetPaymentsByStaffID(int id)
        {
            var payments = table.Where(s => s.UserID == id).ToList();
            return payments;
        }

        public List<Payment> GetWeeklyPayments()
        {
            int year = DateTime.Now.Year;
            int week = ConverterManager.GetWeek(DateTime.Now);
            var payments = table.ToList().Where(s => s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return payments;
        }

        public List<Payment> GetDailyPayments()
        {
            int year = DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var payments = table.ToList().Where(s => s.date.Year == year && s.date.DayOfYear == days).ToList();
            return payments;
        }


        public List<Payment> GetDailyPaymentsForAStaff( int staffID)
        {
            int year = DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var payments = GetPaymentsForAStaff(staffID).Where(s => s.date.Year == year && s.date.DayOfYear == days).ToList();
            return payments;
        }

        public List<Payment> GetWeeklyPaymentsForAStaff(int staffID)
        {
            int year = DateTime.Now.Year;
            int week = ConverterManager.GetWeek(DateTime.Now);
            var payments = GetPaymentsForAStaff(staffID).Where(s => s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return payments;
        }

        

        private List<Payment>  GetPaymentsForAStaff(int staffID)
        {
            var payments = table.Where(s => s.UserID == staffID).ToList();
            return payments;
        }

        public List<Payment> GetDailyPaymentsForAStore(int storeID)
        {
            int year = DateTime.Now.Year;
            int days = DateTime.Now.DayOfYear;
            var payments = GetPaymentsForAStore(storeID).Where(s =>s.date.Year == year && s.date.DayOfYear == days).ToList();
            return payments;
        }

        public List<Payment> GetWeeklyPaymentsForAStore(int storeID)
        {
            int year = DateTime.Now.Year;
            int week = ConverterManager.GetWeek(DateTime.Now);
            var payments = GetPaymentsForAStore(storeID).Where(s => s.date.Year == year && ConverterManager.GetWeek(s.date) == week).ToList();
            return payments;
        }

        private List<Payment> GetPaymentsForAStore(int storeID)
        {
            var payments = table.ToList().Where(s => InStore(s.UserID, storeID)).ToList();
            return payments;
        }

        private bool InStore(int staffID, int storeID)
        {
            var staff = new UserManager().GetByID(staffID);
            if(staff != null)
            {
                return staff.StoreID == storeID;
            }
            return false;
        }
    }
}
