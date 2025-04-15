using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    internal class Dane
    {
        public ZarzadzaniePytaniami Pytania;
        public ZarzadzanieWykladowcami Wykladowcy;
        Dane() {
            this.Pytania = new ZarzadzaniePytaniami();
            this.Wykladowcy = new ZarzadzanieWykladowcami();
        }
    }
}
