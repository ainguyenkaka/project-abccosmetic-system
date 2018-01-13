using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABCosmetic_data.Managers;
using ABCosmetic_data.Entities;

namespace ABCosmetic_data.Tests.Managers
{
    [TestClass]
    public class UserManagerTest
    {
        private UserManager manager;
        private User user1;
        private User user2;

        [TestInitialize]
        public void Setup()
        {
            manager = new UserManager();
            user1 = new User { name = "Tom Kenvine", email = "tomkevine@gmail.com", password = "12345678", avatar = "avatar", RoleID = 2 };
            user2 = new User { name = "Tom Johnson", email = "johnson@gmail.com", password = "12345678", avatar = "avatar", RoleID = 2 };
            manager.AddNew(user1);
            manager.AddNew(user2);
        }

        [TestMethod]
        public void Login()
        {
            bool expected = true;
            bool result = manager.Login("tom@gmail.com", "12345678") != null;
            Assert.AreEqual(expected, result);
           
            expected = false;
            result = manager.Login("kaka@gmail.com", "1238") != null;
            Assert.AreEqual(expected, result);
            result = manager.Login("tom@gmail.com", "21") != null;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckEmail()
        {
            bool expected = true;
            bool result = manager.CheckEmail("tomkevine@gmail.com");
            Assert.AreEqual(expected, result);

            expected = false;
            result = manager.CheckEmail("katom@gmail.com");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetUsers()
        {
            bool expected = true;
            bool result = manager.All().Count >= 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetUser()
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
        public void deleteUser()
        {
            bool expected = false;
            bool result = manager.Delete(100);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void searchByName()
        {
            bool expected = true;
            bool result = manager.searchByName("o").Count > 1;
            Assert.AreEqual(expected, result);
        }


        [TestCleanup]
        public void Cleanup()
        {
            manager.Delete(user1.id);
            manager.Delete(user2.id);
        }
    }
}
