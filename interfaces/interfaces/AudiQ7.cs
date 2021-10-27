using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class AudiQ7 : ICar
    {
        public Marka marka()
        {
            return Marka.Audi;
        }

        public Renk renk()
        {
            return Renk.Siyah;
        }

        public int Tekerlek()
        {
            return 4;
        }
    }
}
