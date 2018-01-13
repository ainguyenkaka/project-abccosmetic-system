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
    public class BrandManagerTest
    {
        private BrandManager manager;
        private Brand brand1;
        private Brand brand2;

        [TestInitialize]
        public void Setup()
        {
            manager = new BrandManager();
            brand1 = new Brand { name = "Pantene HD", image = "br_pantene" };
            brand2 = new Brand { name = "Avon Predium", image = "br_avon" };
            manager.AddNew(brand1);
            manager.AddNew(brand2);
        }



        [TestMethod]
        public void GetBrands()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetBrand()
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
        public void deleteBrand()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }



        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(brand1.id);
            manager.Delete(brand2.id);
        }
    }
}
