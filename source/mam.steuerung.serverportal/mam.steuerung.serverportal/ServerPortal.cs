using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mam.contracts.steuerung;

namespace mam.steuerung.serverportal
{
    public class ServerPortal : IServerPortal
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Starten()
        {
            throw new NotImplementedException();
        }

        public event Action Zurücksetzungswunsch;
        public event Action Fehler;
        public event Action Reparaturwunsch;
        public event Action HilfeUnterwegs;
    }
}
