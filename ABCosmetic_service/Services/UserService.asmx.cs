using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ABCosmetic_data.Managers;

namespace ABCosmetic_service.Services
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
   
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : AbstractService<User>
    {
        private UserManager userManager;

        public UserService() : base(new UserManager())
        {
            userManager = manager as UserManager;
        }

        [WebMethod]
        public User Login(string email, string password)
        {
            return userManager.Login(email, password);
        }

        [WebMethod]
        public bool IsAdmin(String email)
        {
            return userManager.IsAdmin(email);
        }

        [WebMethod]
        public bool IsStaff(String email)
        {
            return userManager.IsStaff(email);
        }

        [WebMethod]
        public bool IsManager(String email)
        {
            return userManager.IsManager(email);
        }

        [WebMethod]
        public String GetUserEmail(int id)
        {
            return manager.GetByID(id).email;
        }

        [WebMethod]
        public List<User> GetCustomers()
        {
            return userManager.GetCustomers();
        }

        [WebMethod]
        public List<User> SearchCustomersByName(String text)
        {
            return userManager.SearchCustomersByName(text);
        }

      

        [WebMethod]
        public List<User> GetStaffs()
        {
            return userManager.GetStaffs();
        }

        [WebMethod]
        public List<User> SearchStaffsByName(String text)
        {
            return userManager.SearchStaffsByName(text);
        }
    }
}
