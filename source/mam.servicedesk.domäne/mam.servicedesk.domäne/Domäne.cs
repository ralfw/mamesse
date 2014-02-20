using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mam.contracts;
using mam.contracts.servicedesk;

namespace mam.servicedesk.domäne
{
    public class Domäne : IDomäne
    {
        public event Action Beruhigen;

        public event Action<bool> FehlerLiegtAn;

        public void HilfeErfordert()
        {
            var fehlerLiegtAn = FehlerLiegtAn;
            if (fehlerLiegtAn != null)
            {
                fehlerLiegtAn(true);
            }
        }

        public void IchKomme()
        {
            var beruhigenHandler = Beruhigen;
            if (beruhigenHandler != null)
            {
                beruhigenHandler();
            }
        }

        public void Zurücksetzen()
        {
            var fehlerLiegtAn = FehlerLiegtAn;
            if (fehlerLiegtAn != null)
            {
                fehlerLiegtAn(false);
            }
        }

        public void FehlerBehoben()
        {
            var fehlerLiegtAn = FehlerLiegtAn;
            if (fehlerLiegtAn != null)
            {
                fehlerLiegtAn(false);
            }
        }
    }
}
