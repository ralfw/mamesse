using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mam.contracts.servicedesk
{
    public interface IServerPortal : IDisposable
    {
        void Starten();
        event Action Zuruecksetzungswunsch;
        event Action HilfeErfordert;
    }
}
