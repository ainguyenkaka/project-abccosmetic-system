using ABCosmetic_app.Models;
using ABCosmetic_app.Models.Managers;
using ABCosmetic_app.ProductService;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ABCosmetic_app.Controllers
{
    public class AccountController : Controller
    {

        public static readonly string SUCESS_KEY = "success_key";
        public static readonly string ERROR_KEY = "error_key";
        public static readonly string EMAIL_KEY = "email_key";
        private readonly string STAFF_KEY = "staff_key";
        private readonly string MANAGER_KEY = "manager_key";

        private ServiceManager serviceManager;
        private BrandsProducts viewModel;
       

        public AccountController()
        {
            serviceManager = ServiceManager.getInstance();
            viewModel = serviceManager.GetViewModel();
        }

        // GET: Login
        public ActionResult Index()
        {
            List<Product> model = viewModel.products;
            ViewBag.Email = TempData[EMAIL_KEY];
            ViewBag.ErrorMessage = TempData[ERROR_KEY];
            ViewBag.SuccessMessage = TempData[SUCESS_KEY];
            return View("Login",model);
        }

        public ActionResult Login()
        {
            String email = this.Request.Params.Get("email");
            String password = this.Request.Params.Get("password");
            TempData[EMAIL_KEY] = email;
            string check = LoginOrSignup(email, password);
            if ( check== null)
                TempData[ERROR_KEY] = "Invalid password!";
            else if(check.Equals(STAFF_KEY))
                return RedirectToAction("Index", "Staff");
            else if (check.Equals(MANAGER_KEY))
                return RedirectToAction("Index", "Manager");

                return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session.Remove("user");
            return RedirectToAction("Index");
        }

        private string LoginOrSignup(String email, String password)
        {
            if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(password))
            {
                User user = serviceManager.Login(email, password);
                if (user != null)
                {
                    Session["user"] = user;
                    if (serviceManager.IsStaff(user.email))
                      return STAFF_KEY;
                    else if (serviceManager.IsManager(user.email))
                      return MANAGER_KEY;
                }
            }
            return null;
        }

    }
}