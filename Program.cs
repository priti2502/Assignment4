namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            Product.Pbrand = "Laptop";
            Console.WriteLine("-----Welcome----");
           

            while (true) {
                Console.WriteLine("Who are You? 1.Admin 2.Customer 3.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Do you want to 1.Add Product 2.Display Product 3.Exit");
                            int ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter Product Code");
                                        int pcode = Byte.Parse(Console.ReadLine());

                                    
                                        Console.WriteLine("ENter Product Name");
                                        String pname = Console.ReadLine();

                                        Console.WriteLine("Enter quantity in stock");
                                        int qty = Byte.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter discount ");

                                        double discount = Byte.Parse(Console.ReadLine());

                                        Product newProduct = new Product(pcode, pname, qty, discount);
                                        productService.AddProduct(newProduct);

                                        break;
                                    }

                                case 2:
                                    {
                                        productService.displayProducts();
                                        break;
                                    }
                                case 3:
                                    {
                                        return;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                    }
                            }


                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Do you want to  1.Order Product");
                            int ch = Byte.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter your product name");
                                        String pname = Console.ReadLine();

                                        Console.WriteLine("Enter quantity");
                                        int qty = Byte.Parse(Console.ReadLine());

                                        productService.OrderProduct(pname, qty); 
                                        break;

                                    }  
                                default:
                                    {
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                    }
                            }

                            break;
                        }

                    case 3:
                        {
                            return;
                        }
                    case 4:
                        {
                            Console.WriteLine("Wrong Choice");
                            break;
                        }
                }

            }

        }
    }
}
