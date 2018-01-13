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
    public class OrderDetailDetailManagerTest
    {
        private OrderDetailManager manager;
        private OrderDetail orderDetail1;
        private OrderDetail orderDetail2;

        [TestInitialize]
        public void Setup()
        {
            manager = new OrderDetailManager();
            orderDetail1 = new OrderDetail { name = "", quantity = 2, ProductID = 13, OrderID = 5 };
            orderDetail2 = new OrderDetail { name = "", quantity = 3, ProductID = 10, OrderID = 3 };
            manager.AddNew(orderDetail1);
            manager.AddNew(orderDetail2);
        }



        [TestMethod]
        public void GetOrderDetails()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetOrderDetail()
        {
            bool expected = true;
            bool result = manager.GetByID(1) != null;
            Assert.AreEqual(expected, result);
            result = manager.GetByID(2) != null;
            Assert.AreEqual(expected, result);

            expected = false;
            result = manager.GetByID(0) != null;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void deleteOrderDetail()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetWeeklyDetails()
        {
            bool expected = true;
            bool result = manager.GetWeeklyDetails().Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetDailyDetailsForAStaff()
        {
            bool expected = true;
            bool result = manager.GetDailyDetailsForAStaff(6).Count > 0;
            Assert.AreEqual(expected, result);
        }

       
     
        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(orderDetail1.id);
            manager.Delete(orderDetail2.id);
        }
    }
}
