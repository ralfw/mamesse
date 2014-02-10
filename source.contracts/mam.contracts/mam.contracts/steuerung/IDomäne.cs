using System;

namespace mam.contracts.steuerung
{
    public interface IDomäne
    {
        void HilfeAnfordern();

        void Zurücksetzen();
        void Kaputtgehen();
        void Reparieren();
        void Beruhigen();

        event Action<Hilfestatus> HilfestatusGeändert;
        event Action<Funktionsstatus> FunktionsstatusGeändert;
        event Action Hilferuf;
    }
}