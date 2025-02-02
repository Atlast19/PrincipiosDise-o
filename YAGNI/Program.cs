// See https://aka.ms/new-console-template for more information

namespace YAGNI 
{
    class program 
    {
        public static void Main(string[] args) 
        {
        }

        public class ProductService 
        {
            public void AddProduct(string name, decimal price) 
            {
                Console.WriteLine($"Product {name} added whit price {price}.");
            }

            public void DeleteProduct(int productId) 
            {
                Console.WriteLine($"Product {productId} delete");
            }

        }
    }
}