using ABCosmetic_app.Filters;
using ABCosmetic_app.Models;
using ABCosmetic_app.Models.Managers;
using ABCosmetic_app.OrderDetailService;
using ABCosmetic_app.OrderService;
using ABCosmetic_app.PaymentService;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCosmetic_app.Controllers.Staff
{
    [StaffAuth]
    public class StaffController : Controller
    {
        private ServiceManager serviceManager;

        private readonly string SAVE_SUCCESS_KEY = "save_success";
        private readonly string SAVE_FAILED_KEY = "save_failed";

        public StaffController()
        {
            serviceManager = ServiceManager.getInstance();
        }
        // GET: Staff
        public ActionResult Index()
        {
            return RedirectToAction("Recording");
        }

        public ActionResult Recording()
        {
            CustomersProducts model = serviceManager.GetCPViewModel();
            ViewBag.MessageSuccess = TempData[SAVE_SUCCESS_KEY];
            ViewBag.MessageFail = TempData[SAVE_FAILED_KEY];
            return View(model);
        }


        [HttpPost]
        public ActionResult SaveRecord()
        {
            var title = this.Request.Params["title"];
            var content = this.Request.Params["content"];
            var cId = this.Request.Params["cId"];
            var total = this.Request.Params["total"];
            string[] pIDs = this.Request.Form.GetValues("pId");
            string[] pQuans = this.Request.Form.GetValues("pQuan");
            int staffID = (this.Session["user"] as User).id;
            if (serviceManager.SaveRecord(title, content, total, cId, staffID, pIDs, pQuans))
                TempData[SAVE_SUCCESS_KEY] = " Save order record successfully!";
            else
                TempData[SAVE_FAILED_KEY] = " Unable to save order record!";

            return RedirectToAction("Recording");
        }

        // GET: Staff
        public ActionResult Customers()
        {
            List<User> model = serviceManager.GetCustomers();
            return View(model);
        }

        public ActionResult SearchCustomers()
        {
            var param = this.Request.Params["name"];
            string text = param != null ? param.Trim() : "";
            List<User> model = serviceManager.SearchCustomersByName(text);
            return View("Customers", model);
        }


        // GET: Staff
        public ActionResult Orders()
        {

            List<Order> model = null;
            var cId = this.Request.Params["cId"];
            if (cId != null)
            {
                model = serviceManager.GetOrdersByCustomerID(Int16.Parse(cId));
            }
            else
                model = serviceManager.GetOrders();
            return View(model);
        }

        public ActionResult SearchOrders()
        {
            var param = this.Request.Params["name"];
            string text = param != null ? param.Trim() : "";
            List<Order> model = serviceManager.SearchOrdersByName(text);
            return View("Orders", model);
        }

        public ActionResult Payment()
        {
            List<QuantityProduct> model = null;
            var oId = this.Request.Params["oId"];
            var oName = this.Request.Params["oName"];
            if (oId != null)
            {
                model = serviceManager.GetPaymentViewModel(Int16.Parse(oId));
            }
            else
            {
                model = new List<QuantityProduct>();
            }
            ViewBag.oId = oId;
            ViewBag.oName = oName;
            return View(model);
        }

        public ActionResult Pay()
        {
            var title = this.Request.Params["title"];
            var content = this.Request.Params["content"];
            var oId = this.Request.Params["oId"];
             var staffID = (this.Session["user"] as User).id;
            serviceManager.PayOrder(title, content, oId, staffID);
            return RedirectToAction("Orders");
        }

    }
}