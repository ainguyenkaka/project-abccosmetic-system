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
    public class StoreManagerTest
    {
        private StoreManager manager;
        private Store store1;
        private Store store2;

        [TestInitialize]
        public void Setup()
        {
            manager = new StoreManager();
            store1 = new Store { name = "Pantene HD", CountryID = 2};
            store2 = new Store { name = "Avon Predium", CountryID = 3 };
            manager.AddNew(store1);
            manager.AddNew(store2);
        }



        [TestMethod]
        public void GetStores()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetStore()
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
        public void deleteStore()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }



        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(store1.id);
            manager.Delete(store2.id);
        }
    }
}
