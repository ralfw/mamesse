using System;
using mam.contracts;
using mam.contracts.steuerung;

namespace mam.steuerung.domäne
{
    public class Domäne : IDomäne
    {
        public void HilfeAnfordern()
        {
            var hilfeRufHandler = Hilferuf;
            if (hilfeRufHandler != null)
            {
                hilfeRufHandler();
            }

            var hilfestatusGeändertHandler = HilfestatusGeändert;
            if ( hilfestatusGeändertHandler != null )
            {
                hilfestatusGeändertHandler(Hilfestatus.HilfeAngefordert);
            }
        }

        public void Zurücksetzen()
        {
            var hilfestatusGeändertHandler = HilfestatusGeändert;
            if ( hilfestatusGeändertHandler != null )
            {
                hilfestatusGeändertHandler( Hilfestatus.KeineHilfeAngefordert );
            }

            var funktionsstatusGeändertHandler = FunktionsstatusGeändert;
            if ( funktionsstatusGeändertHandler != null )
            {
                funktionsstatusGeändertHandler( Funktionsstatus.Läuft );
            }
        }

        public void Kaputtgehen()
        {
            var funktionsstatusGeändertHandler = FunktionsstatusGeändert;
            if ( funktionsstatusGeändertHandler != null )
            {
                funktionsstatusGeändertHandler( Funktionsstatus.Kaputt );
            }
        }

        public void Reparieren()
        {
            var funktionsstatusGeändertHandler = FunktionsstatusGeändert;
            if ( funktionsstatusGeändertHandler != null )
            {
                funktionsstatusGeändertHandler( Funktionsstatus.Läuft );
            }
        }

        public void Beruhigen()
        {
            var hilfestatusGeändertHandler = HilfestatusGeändert;
            if ( hilfestatusGeändertHandler != null )
            {
                hilfestatusGeändertHandler( Hilfestatus.HilfeUnterwegs );
            }
        }

        public event Action<Hilfestatus> HilfestatusGeändert;
        public event Action<Funktionsstatus> FunktionsstatusGeändert;
        public event Action Hilferuf;
    }
}
