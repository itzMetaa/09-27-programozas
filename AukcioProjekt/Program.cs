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
            Festmeny f2 = new Festmeny("xd", "Áasdkos", "tutya");

            f.Licit();
            f.Licit(15);
            //f.Kiir();
            Console.WriteLine(f);

            List<Festmeny> F = new List<Festmeny>();

            F.Add(f);
            F.Add(f2);

            for (int i = 0; i < F.Count; i++)
            {
                Console.WriteLine(F[i]);
            }

            Console.WriteLine("------------\n\n");

            bool kilep = false;
            int N = 0;
            do
            {
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                    kilep = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bibás formátumxd");
                    kilep = false;
                }
            } while (!kilep);
            //Console.WriteLine("kilépett");

            for (int i = 0; i < N; i++)
            {
                //Console.WriteLine("asd" + i);
            }


            Console.ReadKey();
        }
    }
}
