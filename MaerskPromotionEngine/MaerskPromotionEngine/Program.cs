using BusinessLayer;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaerskPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                ProductService objprod = new ProductService();
                Console.WriteLine("Total number of order like 1,2,3..");
                int Num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Num; i++)
                {
                    Console.WriteLine("Enter the type of Product:A,B,C or D");
                    string type = Console.ReadLine();
                    Product p = new Product(type);
                    products.Add(p);
                }

                int totalPrice = objprod.GetTotalPrice(products);
                Console.WriteLine("Total Price:" + totalPrice);
                Console.ReadLine();
            }
            catch (Exception exp)
            { }
        }
    }
}
