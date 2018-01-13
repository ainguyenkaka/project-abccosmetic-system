using ABCosmetic_app.BrandService;
using ABCosmetic_app.CategoryService;
using ABCosmetic_app.OrderService;
using ABCosmetic_app.ProductService;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ABCosmetic_app.OrderDetailService;
using ABCosmetic_app.PaymentService;
using ABCosmetic_app.StoreService;

namespace ABCosmetic_app.Models.Managers
{
    public class ServiceManager
    {
        private static readonly ServiceManager instance = new ServiceManager();
        private CategoryService.CategoryServiceSoapClient categoryService;
        private ProductService.ProductServiceSoapClient productService;
        private UserService.UserServiceSoapClient userService;
        private BrandService.BrandServiceSoapClient brandService;
        private OrderService.OrderServiceSoapClient orderService;
        private OrderDetailService.OrderDetailServiceSoapClient orderDetailService;
        private PaymentService.PaymentServiceSoapClient paymentService;
        private StoreService.StoreServiceSoapClient storeService;
        public static ServiceManager getInstance()
        {
            return instance;
        }


        private ServiceManager()
        {
            categoryService = new CategoryService.CategoryServiceSoapClient();
            productService = new ProductService.ProductServiceSoapClient();
            userService = new UserService.UserServiceSoapClient();
            brandService = new BrandService.BrandServiceSoapClient();
            orderService = new OrderService.OrderServiceSoapClient();
            orderDetailService = new OrderDetailServiceSoapClient();
            paymentService = new PaymentService.PaymentServiceSoapClient();
            storeService = new StoreService.StoreServiceSoapClient();
        }

        public List<Order> GetDailyOrders()
        {
            return orderService.GetDailyOrders();
        }

        public List<QuantityProduct> GetDailySoldProductsForStaff(string staffID)
        {
            int sId = Int16.Parse(staffID);
            var details = orderDetailService.GetDailyDetailsForAStaff(sId);
            return OrderDetailsToModel(details);
        }

        public List<QuantityProduct> GetWeeklySoldProductsForStaff(string staffID)
        {
            int sId = Int16.Parse(staffID);
            var details = orderDetailService.GetWeeklyDetailsForAStaff(sId);
            return OrderDetailsToModel(details);
        }

        public List<QuantityProduct> GetWeeklySoldProducts()
        {
            var details = orderDetailService.GetWeeklyDetails();
            return OrderDetailsToModel(details);
        }

        public List<QuantityProduct> GetDailySoldProducts()
        {
            var details = orderDetailService.GetDailyDetails();
            return OrderDetailsToModel(details);
        }

        public List<QuantityProduct> GetDailySoldProductsForStore(string storeID)
        {
            int sId = Int16.Parse(storeID);
            var details = orderDetailService.GetDailyDetailsForAStore(sId);
            return OrderDetailsToModel(details);
        }

        public List<Order> GetWeeklyOrdersForAStore(int sId)
        {
            return orderService.GetWeeklyOrdersForAStore(sId);
        }

        public List<Order> GetDailyOrdersForAStore(int sId)
        {
            return orderService.GetDailyOrdersForAStore(sId);
        }

        public List<QuantityProduct> GetWeeklySoldProductsForStore(string storeID)
        {
            int sId = Int16.Parse(storeID);
            var details = orderDetailService.GetWeeklyDetailsForAStore(sId);
            return OrderDetailsToModel(details);
        }

        private List<QuantityProduct> OrderDetailsToModel(List<OrderDetail> details)
        {
            List<QuantityProduct> products = new List<QuantityProduct>();
            foreach (var item in details)
            {
                Product pro = GetProduct(item.ProductID);
                products.Add(new QuantityProduct { name = pro.name, quantity = item.quantity, price = pro.price });
            }

            return products;
        }

        public List<Order> GetWeeklyOrders()
        {
            return orderService.GetWeeklyOrders();
        }

        public List<Order> GetWeeklyOrdersForAStaff(int sId)
        {
            return orderService.GetWeeklyOrdersForAStaff(sId);
        }

        public List<Order> GetDailyOrdersForAStaff(int sId)
        {
            return orderService.GetDailyOrdersForAStaff(sId);
        }

        public bool SaveRecord(string title, string content, string total, string cId, int staffID,string[] pIDs, string[] pQuans)
        {
            Order order = AddOrder(title, content, Int16.Parse(cId),staffID, Decimal.Parse(total) );
            if (order != null)
            {
                for (int i = 0; i < pIDs.Length; i++)
                {
                    int pId = Int16.Parse(pIDs[i]);
                    int pQuan = Int16.Parse(pQuans[i]);
                    AddOrderDetail(order.id, pId, pQuan );
                }
                return true;
            }
            else
                return false;
        }

        public BrandsProducts GetViewModel()
        {
            List<Product> products = productService.All();
            List<Brand> brands = brandService.All();
            BrandsProducts viewModel = new BrandsProducts { products = products, brands = brands };
            return viewModel;
        }

        public CustomersProducts GetCPViewModel()
        {
            List<Product> products = productService.All();
            List<User> customers = userService.GetCustomers();
            CustomersProducts viewModel = new CustomersProducts { products = products, customers = customers };
            return viewModel;
        }

        public Order AddOrder(string name, string des, int customerID, int staffID, decimal total)
        {
            return orderService.AddNew(name, des, customerID, staffID, total);
        }

        public OrderDetail AddOrderDetail(int orderID, int productID, int quan)
        {
            return orderDetailService.AddNew(orderID, productID, quan);
        }

        public List<Product> SearchProductsByName(string text)
        {
            return productService.SearchByName(text);
        }

        public Product GetProduct(int id)
        {
            return productService.GetByID(id);
        }

        public User Login(string email, string password)
        {
            return userService.Login(email, password);
        }

        public bool IsAdmin(string email)
        {
            return userService.IsAdmin(email);
        }

        public List<User> SearchCustomersByName(string text)
        {
            return userService.SearchCustomersByName(text);
        }

        public List<Order> GetOrders()
        {
            return orderService.All();
        }

        public List<Order> GetOrdersByCustomerID(int id)
        {
            return orderService.GetOrdersByCustomerID(id);
        }

        public List<Order> SearchOrdersByName(string text)
        {
            return orderService.SearchByName(text);
        }

        public List<Product> SearchProductsByPriceRange(int low, int high)
        {
            return productService.SearchProductsByPriceRange(low, high);
        }

        public List<Product> SearchProductsByPRC(int low, int high, int cId)
        {
            return productService.SearchProductsByPRC(low, high, cId);
        }

        public bool IsStaff(string email)
        {
            return userService.IsStaff(email);
        }

        public bool IsManager(string email)
        {
            return userService.IsManager(email);
        }


        public List<User> GetCustomers()
        {
            return userService.GetCustomers();
        }

        public void PayOrder(string title, string content, string oId, int staffID)
        {
            int orderId = Int16.Parse(oId);
            AddPayment(title,content, orderId, staffID);
            orderService.ChangeOrderToPaied(orderId);
        }

        private List<OrderDetail> GetDetailsByOrderID(int oId)
        {
            return orderDetailService.GetDetailsByOrderID(oId);
        }

        public Payment AddPayment(string name, string des, int orderID, int staffID)
        {
            return paymentService.AddNew(name, des, orderID, staffID);
        }

        public List<QuantityProduct> GetPaymentViewModel(int orderId)
        {
            var details = GetDetailsByOrderID(orderId);
            return OrderDetailsToModel(details);
        }

        public List<User> GetStaffs()
        {
            return userService.GetStaffs();
        }


        public List<User> SearchStaffsByName(string text)
        {
            return userService.SearchStaffsByName(text);
        }


        public List<Store> GetStores()
        {
            return storeService.All();
        }

        public List<Store> SearchStoresByName(String text)
        {
            return storeService.SearchByName(text);
        }

    }
}