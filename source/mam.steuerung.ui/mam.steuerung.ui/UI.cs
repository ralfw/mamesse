using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mam.contracts;
using mam.contracts.steuerung;

namespace mam.steuerung.ui
{
    public class UI : IUI
    {
        public void Starten()
        {
            throw new NotImplementedException();
        }

        public void HilfestatusAnzeigen(Hilfestatus status)
        {
            throw new NotImplementedException();
        }

        public void FunktionsstatusAnzeigen(Funktionsstatus status)
        {
            throw new NotImplementedException();
        }

        public event Action Hilferuf;
    }
}
