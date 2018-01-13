using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.Managers
{
    public class UserManager : AbstractManager<User>
    {



        public UserManager() : base(Manager.GetDB().Users)
        {
        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public bool CheckEmail(String email)
        {
            return GetByEmail(email) != null;
        }

        public User GetByEmail(String email)
        {
            return this.table.FirstOrDefault(item => item.email.Equals(email));
        }

        public User Login(String email, String password)
        {
            User user = this.table.SingleOrDefault(item => item.email.Equals(email) && item.password.Equals(password));
            if (user == null)
            {
                user = new User { name = email.Substring(0, 3), email = email, password = password, avatar = "avatar", RoleID = 2 };
                if (!AddNew(user))
                    user = null;
            }

            return user;
        }



        public new bool AddNew(User item)
        {
            if (CheckEmail(item.email))
                return false;
            else
                return base.AddNew(item) != null;
        }
        public override bool Update(User item)
        {
            return false;
        }

        public List<User> GetCustomers()
        {
            return GetUsersByRole("customer");
        }

        public List<User> SearchCustomersByName(string text)
        {
            var customers = GetCustomers().Where(s => s.name.ToLower().Contains(text.ToLower()));
            return customers.ToList();
        }

       
        public List<User> GetStaffs()
        {
            return GetUsersByRole("staff");
        }

        public List<User> SearchStaffsByName(string text)
        {
            var staffs = GetStaffs().Where(s => s.name.ToLower().Contains(text.ToLower()));
            return staffs.ToList();
        }

        private bool CheckRole(String email, String role)
        {
            return GetUsersByEmailAndRole(email, role).Count > 0;
        }

        private List<User> GetUsersByEmailAndRole(String email, String role)
        {
            var db = Manager.GetDB();
            var users = from u in db.Users
                        join r in db.Roles on u.RoleID equals r.id
                        where u.email.Equals(email) && r.name.Equals(role)
                        select u;

            return users.ToList();
        }

        private List<User> GetUsersByRole(String role)
        {
            var db = Manager.GetDB();
            var users = from u in db.Users
                        join r in db.Roles on u.RoleID equals r.id
                        where r.name.Equals(role)
                        select u;
            return users.ToList();
        }

        public bool IsAdmin(String email)
        {
            return CheckRole(email, "admin");
        }

        public bool IsStaff(string email)
        {
            return CheckRole(email, "staff");
        }

        public bool IsManager(string email)
        {
            return CheckRole(email, "manager");
        }


        public List<User> GetStaffsByStoreID(int id)
        {
            var staffs = table.Where(s => s.StoreID == id).ToList();
            return staffs;
        }

    }
}