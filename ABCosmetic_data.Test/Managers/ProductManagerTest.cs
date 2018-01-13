using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABCosmetic_data.Managers;
using ABCosmetic_data.Entities;

namespace ABCosmetic_data.Tests.Managers
{
    [TestClass]
    public class ProductManagerTest
    {
        private ProductManager manager;
        private Product product1;
        private Product product2;

        [TestInitialize]
        public void Setup()
        {
            manager = new ProductManager();
            product1 = new Product { name = "IPhone 7S", price=3000, quantity=5, description="This one is special", image="ca_appleus", CategoryID = 1};
            product2 = new Product { name = "IPhone 6S", price = 2000, quantity = 3, description = "This one is special", image = "ca_appleus", CategoryID = 1 };
            manager.AddNew(product1);
            manager.AddNew(product2);
        }

      

        [TestMethod]
        public void GetProducts()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetProduct()
        {
            bool expected = true;
            bool result = manager.GetByID(2) != null;
            Assert.AreEqual(expected, result);
            result = manager.GetByID(3) != null;
            Assert.AreEqual(expected, result);

            expected = false;
            result = manager.GetByID(0) != null;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void deleteProduct()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }

     

        [TestMethod]
        public void searchByName()
        {
            bool expected = true;
            bool result = manager.searchByName("o").Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void searchByPriceRange()
        {

            bool expected = true;
            bool result = manager.searchByPriceRange(2000, 3000).Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void searchByPRC()
        {

            bool expected = true;
            bool result = manager.searchByPRC(1000, 3000,1).Count > 0;
            Assert.AreEqual(expected, result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(product1.id);
            manager.Delete(product2.id);
        }
    }
}
