using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanstipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 90;
            int s2 = 909;
            s1 = s2;
            s2 = 65;
            Console.WriteLine(s1);
        }
        
    }
}
