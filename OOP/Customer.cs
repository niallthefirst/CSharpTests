using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Business
{
    
    /// <summary>
    /// Manage Business, residential, government, and educator types of customers.
    /// Customer name: Last Name, First Name.
    /// Email Address.
    /// Home and work address.
    /// 
    /// Manage both our current products and Consolidated systems products.
    /// Product Name
    /// Description
    /// Current Price.
    /// 
    /// Accept orders for customers either online or through our call center.
    /// Customer
    /// Order date
    /// Shipping Address
    /// Products and quantities ordered.
    /// </summary>
    public class Business
    {
        public static void Run()
        {
            Customer me = new Customer { LastName = "Fallon", FirstName = "Niall", Address = "Home" };
            Product product = new Product { Name = "One", Description = "First", CurrentPrice = 100.11 };

            Order order = new Order { Customer = me, 
                                    OrderDate = DateTime.Today, 
                                    ShippingAddress = me.Address, 
                                    ProductsAndQuantities = new Dictionary<Product, int>() { { product, 2 } } 
            };


            order.Print();
        }
    }

    class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
    }

    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Double CurrentPrice { get; set; }

        public override string ToString()
        {
            return Name + ", " + Description + ", " + CurrentPrice;
        }
    
    }

    class Order
    {
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public Dictionary<Product, int> ProductsAndQuantities { get; set; }
        public bool Accept(Order order) { return true; }

        public void Print()
        {
            foreach (var kvp in ProductsAndQuantities)
            {
                Console.WriteLine(kvp.Key.ToString() + " " + kvp.Value);
            }
        }
    }

}
