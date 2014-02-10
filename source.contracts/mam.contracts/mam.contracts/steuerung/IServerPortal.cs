using System;

namespace mam.contracts.steuerung
{
    public interface IServerPortal : IDisposable
    {
        void Starten();

        event Action Zur�cksetzungswunsch;
        event Action Fehler;
        event Action Reparaturwunsch;
        event Action HilfeUnterwegs;
    }
}