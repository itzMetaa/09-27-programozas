using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Program
    {
        static Random r = new Random();
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

            foreach (Festmeny festmenyek in F)
            {
                Console.WriteLine(festmenyek);
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

            Festmeny festmeny;
            for (int i = 0; i < N; i++)
            {
                
                //Console.WriteLine("asd" + i);
                Console.Write("Festő: ");
                string festo = Console.ReadLine();
                Console.Write("Cím: ");
                string cim = Console.ReadLine();
                Console.Write("Stíéus: ");
                string stilus = Console.ReadLine();
                F.Add(festmeny = new Festmeny(cim, festo, stilus));

            }
            Console.WriteLine("------------\n\n");

            foreach (Festmeny festmenyek in F)
            {
                Console.WriteLine(festmenyek);
            }
       
            for (int i = 0; i < 20; i++)
            {
                int festmenySzam = r.Next(0, F.Count);

                if (!(F[festmenySzam].Elkelt()))
                {
                    switch (r.Next(0,1))
                    {
                        case 0:
                            F[festmenySzam].Licit();
                            break;
                        case 1:
                            F[festmenySzam].Licit(r.Next(0,21));
                            break;
                    }
                    switch (r.Next(0, 4))
                    {
                        case 0:
                           F[festmenySzam].setElkelt(true);
                            break;
                        default:
                            F[festmenySzam].setElkelt(false);
                            break;
                    }
                }
                else if (F[festmenySzam].Elkelt())
                {
                    Console.WriteLine("Ez a festmény elkelt");
                }
            }
            Console.WriteLine("------------\n\n");

            foreach (Festmeny festmenyek in F)
            {
                Console.WriteLine(festmenyek);
            }



            Console.ReadKey();
        }
    }
}
