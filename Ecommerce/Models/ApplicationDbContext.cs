using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedCustomer(builder);
            this.SeedOrder(builder);
            this.SeedOrderItem(builder);
            this.SeedDelivery(builder);
     

        }
        private void SeedCustomer(ModelBuilder builder)
        {

            var customers = new List<Customer>
            {
                   new Customer { CustomerId = 1111, CustomerName = "Allu Arjun", CustomerEmail = "alluarjun@gmail.com" },
                   new Customer { CustomerId = 2222, CustomerName = "Sai Pallavi", CustomerEmail = "saipallavi@gmail.com" },
                   new Customer { CustomerId = 3333, CustomerName = "Keerty Suresh", CustomerEmail = "keertysuresh@gmail.com" },
                   new Customer { CustomerId = 4444, CustomerName = "Dhanush", CustomerEmail = "dhanush@gmail.com" },

            };
            builder.Entity<Customer>().HasData(customers);
        }
        private void SeedOrder(ModelBuilder builder)
        {

            var orders = new List<Order>
            {
                   new Order { OrderId= 111 , CustomerId = 1111 },
                   new Order { OrderId= 222 , CustomerId= 2222 },
                   new Order { OrderId = 333 , CustomerId = 3333 },
                   new Order { OrderId = 444 , CustomerId = 4444 },

            };
            builder.Entity<Order>().HasData(orders);
        }
        private void SeedOrderItem(ModelBuilder builder)
        {

            var items = new List<OrderItem>
            {
                   new OrderItem { ItemId= 9999 , OrderId= 111 , Amount = 1928 , Status = "InTransit" },
                   new OrderItem { ItemId= 8888 , OrderId= 111 , Amount = 6453 , Status = "InTransit" },
                   new OrderItem { ItemId= 7777 , OrderId= 111 , Amount = 333 , Status = "InTransit" },
                   new OrderItem { ItemId= 6666 , OrderId= 111 , Amount = 1111 , Status = "InTransit" },

                   new OrderItem { ItemId= 1232 , OrderId= 222 , Amount = 8765 , Status = "InTransit" },
                   new OrderItem { ItemId= 8764 , OrderId= 222 , Amount = 1111 , Status = "InTransit" },

                   new OrderItem { ItemId= 3745 , OrderId= 333 , Amount = 3425 , Status = "InTransit" },
                   new OrderItem { ItemId= 9837 , OrderId= 333 , Amount = 1234 , Status = "InTransit" },
                   new OrderItem { ItemId= 1836 , OrderId= 333 , Amount = 2121 , Status = "InTransit" },
                   new OrderItem { ItemId= 3646 , OrderId= 333 , Amount = 1456 , Status = "InTransit" },


                   new OrderItem { ItemId= 7645 , OrderId= 444 , Amount = 7677 , Status = "InTransit" },
                   new OrderItem { ItemId= 9721 , OrderId= 444 , Amount = 5674 , Status = "InTransit" },
                   new OrderItem { ItemId= 7878 , OrderId= 444 , Amount = 5547 , Status = "InTransit" },





            };
            builder.Entity<OrderItem>().HasData(items);
        }
        private void SeedDelivery(ModelBuilder builder)
        {

            var deliveries = new List<Delivery>
            {
                  new Delivery { ItemId= 9999 , From= "20-sep" , To = "25-sep"  },
                   new Delivery { ItemId= 8888 , From= "20-sep"  , To = "25-sep" },
                   new Delivery { ItemId= 7777 , From= "20-sep"  , To = "25-sep" },
                   new Delivery { ItemId= 6666 , From= "20-sep"  , To = "25-sep" },

                   new Delivery { ItemId= 1232 , From= "22-sep"  , To = "26-sep"},
                   new Delivery { ItemId= 8764 , From= "22-sep"  , To = "26-sep"},

                   new Delivery { ItemId= 3745 , From= "23-sep"  , To = "28-sep"},
                   new Delivery { ItemId= 9837 , From= "23-sep"  , To = "28-sep"},
                   new Delivery { ItemId= 1836 , From= "23-sep"  , To = "28-sep"},
                   new Delivery { ItemId= 3646 , From= "23-sep"  , To = "28-sep"},


                   new Delivery { ItemId= 7645 , From= "24-sep"  , To = "29-sep"},
                   new Delivery { ItemId= 9721 , From= "24-sep"  , To = "29-sep"},
                   new Delivery { ItemId= 7878 , From= "24-sep"  , To = "29-sep"},

            };
            builder.Entity<Delivery>().HasData(deliveries);
        }
        public DbSet<Ecommerce.Models.StatusForm> StatusForm { get; set; }
        public DbSet<Ecommerce.Models.PostponeForm> PostponeForm { get; set; }

    }
}
