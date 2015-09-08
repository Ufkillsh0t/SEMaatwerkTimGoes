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
            Kps = 0;
            Koekjes = 0;
            KoekjesPerKlik = 10;
        }
    }
}
