using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mam.contracts.servicedesk
{
    public interface IUI
    {
        void Starten();

        event Action IchKomme;

        void FehlerAnzeigen(bool status);
    }
}
