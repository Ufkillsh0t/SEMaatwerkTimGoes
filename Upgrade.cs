using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public class Upgrade
    {
        public string Naam { get; set; }

        public int Kps { get; set; }

        public int Prijs { get; set; }

        public int PrijsInterval { get; set; }

        public int Aantal { get; set; }

        public Upgrade(string naam, int kps, int prijs, int prijsinterval)
        {
            Aantal = 0;
        }
    }
}
