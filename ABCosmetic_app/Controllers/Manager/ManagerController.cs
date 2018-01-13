using ABCosmetic_app.Filters;
using ABCosmetic_app.Models;
using ABCosmetic_app.Models.Managers;
using ABCosmetic_app.StoreService;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCosmetic_app.Controllers.Manager
{
    [ManagerAuth]
    public class ManagerController : Controller
    {
        private ServiceManager serviceManager;

        public ManagerController()
        {
            serviceManager = ServiceManager.getInstance();
        }

        // GET: Manager
        public ActionResult Index()
        {
            return RedirectToAction("Staffs");
        }

        public ActionResult Staffs()
        {
            List<User> model = serviceManager.GetStaffs();
            return View(model);
        }


        public ActionResult SearchStaffs()
        {
            var param = this.Request.Params["name"];
            string text = param != null ? param.Trim() : "";
            List<User> model = serviceManager.SearchStaffsByName(text);
            return View("Staffs", model);
        }

        public ActionResult OrderReportForStaff()
        {
            string staffID = this.Request.Params["sId"];
            if (staffID != null)
            {
                int sId = Int16.Parse(staffID);
                var dailyOrders = serviceManager.GetDailyOrdersForAStaff(sId);
                var WeeklyOrders = serviceManager.GetWeeklyOrdersForAStaff(sId);
                DailyWeeklyOrder model = new DailyWeeklyOrder { daily = dailyOrders, weekly = WeeklyOrders };
                string msg = this.Request.Params["msg"];
                ViewBag.Message = "Staff: " + msg;
                return View("OrderReport", model);
            }
            else
            return RedirectToAction("OrderReport");
        }

        public ActionResult ProductReportForStaff()
        {
            string staffID = this.Request.Params["sId"];
            if(staffID != null)
            {
                var dailySoldProduts = serviceManager.GetDailySoldProductsForStaff(staffID);
                var weeklySoldProduts = serviceManager.GetWeeklySoldProductsForStaff(staffID);
                DailyWeeklyProduct model = new DailyWeeklyProduct { daily = dailySoldProduts, weekly = weeklySoldProduts };

                string msg = this.Request.Params["msg"];
                ViewBag.Message = "Staff: " + msg;
                return View("ProductReport", model);
            }else
                return RedirectToAction("ProductReport");
        }

        public ActionResult OrderReport()
        {
            var dailyOrders = serviceManager.GetDailyOrders();
            var WeeklyOrders = serviceManager.GetWeeklyOrders();
            DailyWeeklyOrder model = new DailyWeeklyOrder { daily = dailyOrders, weekly = WeeklyOrders };
            return View(model);
        }

        public ActionResult OrderReportForStore()
        {
            string staffID = this.Request.Params["sId"];
            if (staffID != null)
            {
                int sId = Int16.Parse(staffID);
                var dailyOrders = serviceManager.GetDailyOrdersForAStore(sId);
                var WeeklyOrders = serviceManager.GetWeeklyOrdersForAStore(sId);
                DailyWeeklyOrder model = new DailyWeeklyOrder { daily = dailyOrders, weekly = WeeklyOrders };

                string msg = this.Request.Params["msg"];
                ViewBag.Message = "Store: " + msg;
                return View("OrderReport", model);
            }
            else
                return RedirectToAction("OrderReport");
        }

        public ActionResult ProductReportForStore()
        {
            string storeID = this.Request.Params["sId"];
            if (storeID != null)
            {
                var dailySoldProduts = serviceManager.GetDailySoldProductsForStore(storeID);
                var weeklySoldProduts = serviceManager.GetWeeklySoldProductsForStore(storeID);
                DailyWeeklyProduct model = new DailyWeeklyProduct { daily = dailySoldProduts, weekly = weeklySoldProduts };

                string msg = this.Request.Params["msg"];
                ViewBag.Message = "Staff: " + msg;
                return View("ProductReport", model);
            }
            else
                return RedirectToAction("ProductReport");
        }

        public ActionResult ProductReport()
        {
            var dailySoldProduts = serviceManager.GetDailySoldProducts();
            var weeklySoldProduts = serviceManager.GetWeeklySoldProducts();
            DailyWeeklyProduct model = new DailyWeeklyProduct { daily = dailySoldProduts, weekly = weeklySoldProduts };
            return View(model);
        }


        public ActionResult Stores()
        {
            List<Store> model = serviceManager.GetStores();
            return View(model);
        }


        public ActionResult SearchStores()
        {
            var param = this.Request.Params["name"];
            string text = param != null ? param.Trim() : "";
            List<Store> model = serviceManager.SearchStoresByName(text);
            return View("Stores", model);
        }
    }
}