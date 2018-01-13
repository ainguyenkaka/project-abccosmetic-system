using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABCosmetic_data.Managers;
using ABCosmetic_data.Entities;

namespace ABCosmetic_data.Tests.Managers
{
    [TestClass]
    public class CategoryManagerTest
    {
        private CategoryManager manager;
        private Category category1;
        private Category category2;

        [TestInitialize]
        public void Setup()
        {
            manager = new CategoryManager();
            category1 = new Category { name = "Apple US", image = "ca_appleus" };
            category2 = new Category { name = "Amazon", image = "ca_amazon" };
            manager.AddNew(category1);
            manager.AddNew(category2);
        }



        [TestMethod]
        public void GetCategories()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCategory()
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
        public void deleteCategory()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void searchByName() {
            bool expected = true;
            bool result = manager.searchByName("a").Count > 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void updateCategory()
        {
            bool expected = true;
            category1.name = "New Apple";
            bool result = manager.Update(category1);
            Assert.AreEqual(expected, result);
            category2.name = "New Amazon";
            result = manager.Update(category2);
            Assert.AreEqual(expected, result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(category1.id);
            manager.Delete(category2.id);
        }
    }
}
