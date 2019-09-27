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
            Festmeny f = new Festmeny("Jani","Ákos","anya",1,2101,DateTime.Now,false);
            f.Licit();
            Console.ReadKey();
        }
    }
}
