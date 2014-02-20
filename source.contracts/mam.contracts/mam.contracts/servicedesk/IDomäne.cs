using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mam.contracts.servicedesk
{
    public interface IDomäne
    {
        void Zurücksetzen();
        void HilfeErfordert();
        /// <summary>
        /// Called if service employee wants to signal request acknowledged message
        /// </summary>
        void IchKomme();
        /// <summary>
        /// Called if service employee wants to mark this request as resolved
        /// </summary>
        void FehlerBehoben();

        event Action<bool> FehlerLiegtAn;
        event Action Beruhigen;
    }
}
