using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Festmeny f = new Festmeny("Jani","Ákos","anya");
            f.Licit();
            f.Licit(15);
            //f.Kiir();
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
