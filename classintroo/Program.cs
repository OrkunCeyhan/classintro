using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classintroo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 33;

            Kurs kurs1 = new Kurs();

            kurs1.kursadi = "c#";
            kurs1.egitmen = "engin demirog";
            kurs1.izlenmeorani = 44;

            Kurs kurs2 = new Kurs();

            kurs2.kursadi = "java";
            kurs2.egitmen = "ahmet demirog";
            kurs2.izlenmeorani = 23;

            Kurs kurs3 = new Kurs();

            kurs3.kursadi = "js";
            kurs3.egitmen = "berkay demirog";
            kurs3.izlenmeorani = 55;

            Console.WriteLine(kurs1.kursadi+":"+ kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi +":"+kurs.egitmen);
            }
        }
        class Kurs
        {
            public string kursadi { get; set; }
            public string egitmen { get; set; }
            public int izlenmeorani { get; set; }
        }
    }
}
