using System;

namespace mam.contracts.steuerung
{
    public interface IUI
    {
        void Starten();

        event Action Hilferuf;

        void HilfestatusAnzeigen(Hilfestatus status);
        void FunktionsstatusAnzeigen(Funktionsstatus status);
    }
}
