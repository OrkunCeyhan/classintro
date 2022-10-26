using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 400;
            product1.UnitsinStock = 3;

            Product product2 = new Product { Id=2, CategoryId=5, UnitsinStock=5, ProductName="kalem", UnitPrice=34};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);


        }
    }
}
