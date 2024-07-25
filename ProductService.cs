using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class ProductService
    {
        Product product1 = new Product();
    
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void displayProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
           
        }

        public Product FindProduct(String name) {
            foreach (Product product in products)
            {
                if (product.Pname == name)
                {
                    return product;
                }
               
            }
            return null;

        }
        public void OrderProduct(String pname,int quantity)
        {
            Product product = FindProduct(pname);
            if(product!=null)
            {
                
                Console.WriteLine($"Product Name:{product.Pname},ProductQuantity:{quantity} ,ProductDiscount:{product.Pdiscount} ");
                if(quantity <=product.Pqty)
                {
                    Console.WriteLine("Order Successful");

                    double price = quantity * 500;
                 

                    double discount = price * (product.Pdiscount / 100.00);
                    Console.WriteLine($"price:{price}");
                    Console.WriteLine($"Discount: {discount}");
                    Console.WriteLine($"Total Price:{price - discount}");

                }
                else
                {
                    Console.WriteLine("Insufficient stock");
                }
            }
            else
            {
                Console.WriteLine("Product Not available");
            }

        }

        
        
    }
}
