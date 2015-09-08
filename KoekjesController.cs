using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public class KoekjesController
    {
        public int Kps { get; set; }

        public int Koekjes { get; set; }

        public int KoekjesPerKlik { get; set; }

        public KoekjesController()
        {
            this.Kps = 0;
            this.Koekjes = 0;
            this.KoekjesPerKlik = 10;
        }
    }
}
