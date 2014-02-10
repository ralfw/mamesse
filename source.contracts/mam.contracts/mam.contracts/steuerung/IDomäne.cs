using System;

namespace mam.contracts.steuerung
{
    public interface IDom�ne
    {
        void HilfeAnfordern();

        void Zur�cksetzen();
        void Kaputtgehen();
        void Reparieren();
        void Beruhigen();

        event Action<Hilfestatus> HilfestatusGe�ndert;
        event Action<Funktionsstatus> FunktionsstatusGe�ndert;
        event Action Hilferuf;
    }
}