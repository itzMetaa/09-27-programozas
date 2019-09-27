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
            Festmeny f = new Festmeny("Jani","Ákos","anya",1,100,DateTime.Now,false);
            f.Licit();
            f.Licit(15);
            f.Kiir();
            Console.ReadKey();
        }
    }
}
