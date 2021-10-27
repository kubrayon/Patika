using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class ToyotaAuris : ICar
    {
        public Marka marka()
        {
            return Marka.Toyota;
        }

        public Renk renk()
        {
            return Renk.Gri;
        }

        public int Tekerlek()
        {
            return 4;
        }
    }
}
