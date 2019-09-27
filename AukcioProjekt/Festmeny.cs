using System;
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
        private int licitekSzama;
        private int legmagasabbLicit;
        private DateTime legutolsoLicitIdeje;
        private bool elkelt;

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
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

        }

        public void Licit(int mertek)
        {

        }
    }
}
