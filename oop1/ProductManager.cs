using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "kamera";
        }
        public void update(Product product)
        {
            Console.WriteLine(product.ProductName+"güncellendi");
        }
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public void Topla2(int s1, int s2)
        {
            Console.WriteLine(s1 + s2 );
        }
    }
}
