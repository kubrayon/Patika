using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class SkodaKodiaq : ICar
    {
        public Marka marka()
        {
            return Marka.Skoda;
        }

        public Renk renk()
        {
            return Renk.Beyaz;
        }

        public int Tekerlek()
        {
            return 4;
        }
    }
}
