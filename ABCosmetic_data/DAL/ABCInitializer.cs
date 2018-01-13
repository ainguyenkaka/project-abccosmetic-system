using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.DAL
{
    public class ABCInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ABCContext>
    {

        protected override void Seed(ABCContext context)
        {
            var countries = new List<Country>
            {
                new Country {name = "Vietnam", code = "VN" },
                new Country {name = "United State", code = "US" },
                new Country {name = "United Kingdom", code = "UK" },
                new Country {name = "Canada", code = "CA" },
                new Country {name = "France", code = "FR" },
            };
            countries.ForEach(s => context.Countries.Add(s));
            context.SaveChanges();

            var stores = new List<Store>
            {
                new Store { name="New Morning", CountryID=2 },
                new Store { name="Sunshine", CountryID=2 },
                new Store { name="Beauty No1", CountryID=3 },
                 new Store { name="Beautiful Woman", CountryID=1 },
                  new Store { name="Newsman", CountryID=4 },
                   new Store { name="Facelet", CountryID=5 },
            };

            stores.ForEach(s => context.Stores.Add(s));
            context.SaveChanges();

            var categories = new List<Category>
            {
            new Category { name="Apple", image="ca_apple" },
            new Category { name="Samsung", image="ca_samsung" },
            new Category { name="Google", image="ca_google" },
               new Category { name="Microsoft", image="ca_microsoft" },
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var brands = new List<Brand>
            {
                new Brand {name="Pantene", image="br_pantene" },
                 new Brand {name="Nivea", image="br_nivea" },
                  new Brand {name="Avon" , image="br_avon"},
                   new Brand {name="Olay", image="br_olay" },
                    new Brand {name="Chanel", image="br_chanel" },
            };

            brands.ForEach(s => context.Brands.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
           new Product { name= "FUltra HD", price = 2000, quantity = 20, description = "When make up for ever launched its HD Foundation in 2008, the groundbreaking product put the beauty brand on the map.", image = "pr_ultrahd", CategoryID = 2 , BrandID = 1},
new Product {name="Anastasia",price = 2000, quantity = 16, description = "The matte formula is richer, longer-wearing",image = "pr_liquidlipstick", CategoryID = 3,  BrandID = 5},
new Product {name="Cushion Liquid",price = 1500, quantity = 22, description = "Foundation in a cushion sounds as gimmicky as soap on a rope, but trust us when we say this unique product is the real deal. ", image = "pr_cushion", CategoryID = 2,BrandID = 2},
new Product {name="Mini Eye Wand",price = 2000, quantity = 30,description  = "On one end you've got a lightweight gel-cream hybrid that leaves the skin around your eyes looking fresh", image = "pr_eyewand", CategoryID = 1, BrandID = 3},
new Product {name="Tom Ford",price = 2000, quantity = 26, description = "Makeup artists became instantly obsessed with the buildable creams, one a sheer matte tan shade for contouring.",image = "pr_tomford", CategoryID = 1,  BrandID = 2},
new Product {name="Becca X Hill",price = 3000, quantity = 30, description = "When you look at the color peach, it's a mix of pink and yellow.",image = "pr_hillskin",CategoryID = 1,  BrandID = 2},
new Product {name="Brow Mascara",price = 2000, quantity = 32, description = "The tinted formula is a gel-mousse hybrid that both tints and thickens brow hairs. ",image = "pr_bowmasacra", CategoryID = 3,  BrandID = 3},
new Product {name="Kat Von Liner",price = 1000, quantity = 29, description = "Its fine, tapered tip helps create razor-sharp wings and pin-straight lines.",image = "pr_tatooliner", CategoryID = 4,  BrandID = 4},
new Product {name="Roller Lash",price = 2000, quantity = 50,description  = "The reason is its combination of a genius wand and an exceptional formula. The wand has tiny hooks ", image = "pr_lashmasacra", CategoryID = 1,  BrandID = 5},
new Product {name="Eyeko Mascara",price = 2000, quantity = 20, description = "This is the waterproof mascara for people who hate waterproof mascara",image = "pr_waterproofmasacra", CategoryID = 1,  BrandID = 4},
new Product {name="Urban palette",price = 3000, quantity = 26, description = "The range of neutrals, darks, mattes, and metallics lets you create any smoky-eye iteration you can dream up",image = "pr_smokypallete",CategoryID = 1,  BrandID = 5},
new Product {name="Temptu Air",price = 1500, quantity = 33, description = "This time they did way better. The Air, the first-ever handheld airbrush-makeup device on the market, is cordless, rechargeable, and superquiet.", image = "pr_airbrush", CategoryID = 2, BrandID = 1},     
new Product {name="New York ColorBlur",price = 1000, quantity = 32, description = "Most of the time it involves a makeup artist carefully and painstakingly pressing and blotting lipstick onto the center of the lips",image = "pr_creamlip", CategoryID = 4, BrandID = 4},
new Product {name="New Lash Mascara",price = 2000, quantity = 39,description  = "The reason is its combination of a genius wand and an exceptional formula. The wand has tiny hooks ", image = "pr_lashmasacra", CategoryID = 1,BrandID = 5},
new Product {name="Mordern Mascara",price = 2000, quantity = 40, description = "This is the waterproof mascara for people who hate waterproof mascara",image = "pr_waterproofmasacra", CategoryID = 1, BrandID = 4},
new Product {name="Colorful palette",price = 3000, quantity = 42, description = "The range of neutrals, darks, mattes, and metallics lets you create any smoky-eye iteration you can dream up",image = "pr_smokypallete",CategoryID = 1,  BrandID = 5},
new Product {name="Blue Lipstick",price = 2000, quantity = 36, description = "The matte formula is richer, longer-wearing",image = "pr_liquidlipstick", CategoryID = 3,  BrandID = 5},
new Product {name="Cool ColorBlur",price = 1000, quantity = 38, description = "Most of the time it involves a makeup artist carefully and painstakingly pressing and blotting lipstick onto the center of the lips",image = "pr_creamlip", CategoryID = 4, BrandID = 4}
    };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var productstores = new List<ProductStore> {
                new ProductStore { quantity = 6, ProductID = 1, StoreID = 1 },
                new ProductStore { quantity = 8, ProductID = 3, StoreID = 1 },
                new ProductStore { quantity = 10, ProductID = 5, StoreID = 1 },
                new ProductStore { quantity = 9, ProductID = 6, StoreID = 1 },
                new ProductStore { quantity = 7, ProductID = 13, StoreID = 1 },
                new ProductStore { quantity = 11, ProductID = 10, StoreID = 1 },

                new ProductStore { quantity = 6, ProductID = 1, StoreID = 2 },
                new ProductStore { quantity = 8, ProductID = 3, StoreID = 2 },
                new ProductStore { quantity = 10, ProductID = 7, StoreID = 2 },
                new ProductStore { quantity = 9, ProductID = 8, StoreID = 2 },
                new ProductStore { quantity = 7, ProductID = 12, StoreID = 2 },
                new ProductStore { quantity = 11, ProductID = 11, StoreID = 2 },

                new ProductStore { quantity = 6, ProductID = 9, StoreID = 3 },
                new ProductStore { quantity = 8, ProductID = 10, StoreID =  3},
                new ProductStore { quantity = 10, ProductID = 11, StoreID = 3 },
                new ProductStore { quantity = 9, ProductID = 12, StoreID = 3 },
                new ProductStore { quantity = 7, ProductID = 13, StoreID = 3 },
                new ProductStore { quantity = 11, ProductID = 14, StoreID = 3 },

                new ProductStore { quantity = 6, ProductID = 9, StoreID = 4 },
                new ProductStore { quantity = 8, ProductID = 10, StoreID =  4},
                new ProductStore { quantity = 10, ProductID = 1, StoreID = 4 },
                new ProductStore { quantity = 9, ProductID = 3, StoreID = 4 },
                new ProductStore { quantity = 7, ProductID = 7, StoreID = 4 },
                new ProductStore { quantity = 11, ProductID = 14, StoreID = 4 },

                new ProductStore { quantity = 6, ProductID = 9, StoreID = 5 },
                new ProductStore { quantity = 8, ProductID = 10, StoreID =  5},
                new ProductStore { quantity = 10, ProductID = 1, StoreID = 5 },
                new ProductStore { quantity = 9, ProductID = 3, StoreID = 5 },
                new ProductStore { quantity = 7, ProductID = 7, StoreID = 5 },
                new ProductStore { quantity = 11, ProductID = 14, StoreID = 5 },

                new ProductStore { quantity = 6, ProductID = 2, StoreID = 6 },
                new ProductStore { quantity = 8, ProductID = 4, StoreID = 6 },
                new ProductStore { quantity = 10, ProductID = 7, StoreID = 6 },
                new ProductStore { quantity = 9, ProductID = 8, StoreID = 6 },
                new ProductStore { quantity = 7, ProductID = 5, StoreID = 6 },
                new ProductStore { quantity = 11, ProductID = 11, StoreID = 6 },
            };

            var roles = new List<Role>
            {
                new Role { name = "manager" },
                 new Role { name = "customer" },
                  new Role { name = "staff" }
            };
            roles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {
                  new User{name="Boss Job", email = "job@gmail.com", password = "12345678", avatar = "avatar", RoleID = 1},
           new User{name="Young Kaka", email = "kaka@gmail.com", password = "12345678", avatar = "avatar", RoleID = 1},
new User{name="John Tom", email = "tom@gmail.com", password = "12345678", avatar = "avatar", RoleID = 2, StoreID = 2},
new User{name="Davlid Villa", email = "villa@gmail.com", password = "12345678", avatar = "avatar", RoleID = 2, StoreID = 3},
new User{name="John Terry", email = "terry@gmail.com", password = "12345678",avatar = "avatar", RoleID = 2, StoreID = 2},
new User{name="Chole Marry", email = "marry@gmail.com", password = "12345678",avatar = "avatar", RoleID = 3, StoreID = 2 },
new User{name="Heny Linda", email = "linda@gmail.com", password = "12345678",avatar = "avatar", RoleID = 3 , StoreID = 3}
        };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var status = new List<Status> {
                new Status { name = "New" },
                new Status { name = "Working" },
                new Status { name = "Paied" },
            };
            status.ForEach(s => context.Status.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { name = "New lipsticks", description="Want the new lipsticks that are colorful.", StatusID=3, CustomerID = 3, StaffID = 6, total = 6000},
                new Order { name = "Mordern masacra", description="Want the mordern masacras that has new features.", StatusID=3, CustomerID = 4, StaffID = 6, total = 9000 },
                new Order { name = "Four new cosmetic products", description="The new cosmetic products must be modern and popular", StatusID=3, CustomerID = 3,StaffID = 6, total = 8000 },
                new Order { name = "Top cosmetic products", description="I want the top cosmetic products.", StatusID=2, CustomerID= 5 ,StaffID = 7, total = 12000},
                new Order { name = "New hair burshes", description="Want the new burshes that are helpful.", StatusID=1 , CustomerID = 5, StaffID = 6,total = 6500},
                new Order { name = "Mordern clip tools", description="Want the mordern clips that has new features.", StatusID=2 , CustomerID = 3,StaffID = 7, total = 7000},
                new Order { name = "Five new cosmetic products", description="The new cosmetic products must be modern and popular", StatusID=1, CustomerID= 4 ,StaffID = 7, total = 3000},
                new Order { name = "Basic cosmetic products", description="I want the popular cosmetic products.", StatusID=1, CustomerID = 3, StaffID = 6,total = 4500 },
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail { name = "", quantity = 3, ProductID = 2, OrderID = 1 },
                 new OrderDetail { name = "", quantity = 2, ProductID = 3, OrderID = 1 },
                  new OrderDetail { name = "", quantity = 1, ProductID = 1, OrderID = 1 },

                   new OrderDetail { name = "", quantity = 3, ProductID = 5, OrderID = 2 },
                    new OrderDetail { name = "", quantity = 2, ProductID = 8, OrderID = 2 },
                     new OrderDetail { name = "", quantity = 3, ProductID = 6, OrderID = 2 },

                      new OrderDetail { name = "", quantity = 1, ProductID = 10, OrderID = 3 },
                      new OrderDetail { name = "", quantity = 2, ProductID = 8, OrderID = 3 },
                      new OrderDetail { name = "", quantity = 1, ProductID = 9, OrderID = 3 },

                      new OrderDetail { name = "", quantity = 3, ProductID = 13, OrderID = 4 },
                      new OrderDetail { name = "", quantity = 3, ProductID = 15, OrderID = 4 },
                      new OrderDetail { name = "", quantity = 2, ProductID = 16, OrderID = 4 },

                       new OrderDetail { name = "", quantity = 2, ProductID = 13, OrderID = 5 },
                      new OrderDetail { name = "", quantity = 2, ProductID = 10, OrderID = 5 },

                      new OrderDetail { name = "", quantity = 2, ProductID = 8, OrderID = 6 },
                        new OrderDetail { name = "", quantity = 1, ProductID = 9, OrderID = 6 },

                      new OrderDetail { name = "", quantity = 3, ProductID = 14, OrderID = 7 },
                      new OrderDetail { name = "", quantity = 2, ProductID = 13, OrderID = 7 },

                      new OrderDetail { name = "", quantity = 3, ProductID = 15, OrderID = 8 },
                      new OrderDetail { name = "", quantity = 3, ProductID = 16, OrderID = 8 },
            };
            orderDetails.ForEach(s => context.OrderDetails.Add(s));
            context.SaveChanges();

            var payments = new List<Payment> {
                 new Payment { name = "Three best products", description="Pay three products", OrderID = 2, UserID = 6},
                 new Payment { name = "Top products", description="Pay Top products", OrderID = 1, UserID = 6},
                 new Payment { name = "Late products", description="Pay late products", OrderID = 3, UserID = 7},
            };
            payments.ForEach(s => context.Payments.Add(s));
            context.SaveChanges();
        }
    }
}