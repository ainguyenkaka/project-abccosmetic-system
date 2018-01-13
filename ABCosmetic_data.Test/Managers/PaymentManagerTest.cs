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
    public class PaymentManagerTest
    {
        private PaymentManager manager;
        private Payment payment1;
        private Payment payment2;

        [TestInitialize]
        public void Setup()
        {
            manager = new PaymentManager();
            payment1 = new Payment { name = "Pantene HD", description = " Pay three costmetic products", UserID = 6, OrderID = 3 };
            payment2 = new Payment { name = "Avon Predium",description = "Pay many best products", UserID = 6, OrderID = 3 };
            manager.AddNew(payment1);
            manager.AddNew(payment2);
        }



        [TestMethod]
        public void GetBrands()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetPayment()
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
        public void deletePayment()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }



        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(payment1.id);
            manager.Delete(payment2.id);
        }
    }
}
