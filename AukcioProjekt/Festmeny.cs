﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Festmeny
    {
        private string cim;
        private string festo;
        private string stilus;
        private int licitekSzama = 0;
        private int legmagasabbLicit = 0;
        private DateTime legutolsoLicitIdeje;
        private bool elkelt = false;

        public Festmeny()
        {

        }

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
        }

        public Festmeny(string cim, string festo, string stilus, int licitekSzama, int legmagasabbLicit, DateTime legutolsoLicitIdeje, bool elkelt)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
            this.licitekSzama = licitekSzama;
            this.legmagasabbLicit = legmagasabbLicit;
            this.legutolsoLicitIdeje = legutolsoLicitIdeje;
            this.elkelt = elkelt;
        }

        public string Festo() {
            return this.festo;
        }
        public string Stilus()
        {
            return this.stilus;
        }
        public int LicitekSzama()
        {
            return this.licitekSzama;
        }
        public int LegmagasabbLicit()
        {
            return this.legmagasabbLicit;
        }
        public DateTime LegutolsoLicitIdeje()
        {
            return this.legutolsoLicitIdeje;
        }
        public bool Elkelt()
        {
            return this.elkelt;
        }
        public void setElkelt(bool ertek)
        {
            this.elkelt = ertek;
        }


        public void Licit()
        {
            if (this.elkelt == true)
            {
                Console.WriteLine("A festmény már elkelt");
            }
            if (this.licitekSzama == 0)
            {
                this.legmagasabbLicit = 100;
            }
            else if (this.licitekSzama > 0)
            {
                this.legmagasabbLicit = (int)Math.Round(this.legmagasabbLicit * 1.1);
            }
            licitekSzama++;
            legutolsoLicitIdeje = DateTime.Now;
            Console.WriteLine(this.legmagasabbLicit);

        }

        public void Licit(int mertek)
        {
            if (this.elkelt == true)
            {
                Console.WriteLine("A festmény már elkelt");
            }
            if (this.licitekSzama == 0)
            {
                this.legmagasabbLicit = 100;
            }
            else if (this.licitekSzama > 0)
            {
                this.legmagasabbLicit += (int)Math.Round(this.legmagasabbLicit * (mertek / 100.0));
            }
            licitekSzama++;
            legutolsoLicitIdeje = DateTime.Now;
            Console.WriteLine(this.legmagasabbLicit);
        }

        public void Kiir()
        {
            Console.WriteLine("{0}: {1} ({2})", this.festo, this.cim, this.stilus);
            Console.WriteLine("{0}", this.elkelt? "elkelt" : "nem kelt el");
            Console.WriteLine("{0}$ - {1} (összesen: {2} db)", this.legmagasabbLicit, this.legutolsoLicitIdeje, this.licitekSzama);
        }

    }
}
