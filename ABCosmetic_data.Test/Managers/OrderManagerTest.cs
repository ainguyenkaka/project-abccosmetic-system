using ABCosmetic_data.Entities;
using ABCosmetic_data.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Test.Managers
{
    [TestClass]
    public class OrderManagerTest
    {
        private OrderManager manager;
        private Order order1;
        private Order order2;

        [TestInitialize]
        public void Setup()
        {
            manager = new OrderManager();
            order1 =  manager.AddNew(new Order { name = "Mordern masacra", description = "Want the mordern masacras that has new features.", StatusID = 2, CustomerID = 4, StaffID = 6, total = 5000 });
            order2 = manager.AddNew(new Order { name = "Top cosmetic products", description = "I want the top cosmetic products.", StatusID = 3, CustomerID = 5, StaffID = 6 , total = 6000});
        }



        [TestMethod]
        public void GetOrders()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetOrder()
        {
            bool expected = true;
            bool result = manager.GetByID(order1.id) != null;
            Assert.AreEqual(expected, result);
            result = manager.GetByID(order2.id) != null;
            Assert.AreEqual(expected, result);

            expected = false;
            result = manager.GetByID(0) != null;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void deleteOrder()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetDailyOrders()
        {
            bool expected = true;
            bool result = manager.GetDailyOrders().Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetWeeklyOrders()
        {
            bool expected = true;
            bool result = manager.GetWeeklyOrders().Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetDailyOrdersForAStaff()
        {
            bool expected = true;
            bool result = manager.GetDailyOrdersForAStaff(6).Count > 0;
            Assert.AreEqual(expected, result);
        }

      

        [TestMethod]
        public void GetWeeklyOrdersForAStore()
        {
            bool expected = true;
            bool result = manager.GetWeeklyOrdersForAStore(3).Count > 0;
            Assert.AreEqual(expected, result);
        }


        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(order1.id);
            manager.Delete(order2.id);
        }
    }
}
