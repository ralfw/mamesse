using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mam.contracts;
using mam.contracts.steuerung;

namespace mam.steuerung.domäne
{
    public class Domäne : IDomäne
    {
        public void HilfeAnfordern()
        {
            throw new NotImplementedException();
        }

        public void Zurücksetzen()
        {
            throw new NotImplementedException();
        }

        public void Kaputtgehen()
        {
            throw new NotImplementedException();
        }

        public void Reparieren()
        {
            throw new NotImplementedException();
        }

        public void Beruhigen()
        {
            throw new NotImplementedException();
        }

        public event Action<Hilfestatus> HilfestatusGeändert;
        public event Action<Funktionsstatus> FunktionsstatusGeändert;
        public event Action Hilferuf;
    }
}
