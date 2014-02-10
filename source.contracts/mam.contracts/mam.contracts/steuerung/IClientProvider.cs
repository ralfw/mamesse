using System;

namespace mam.contracts.steuerung
{
    public interface IClientProvider : IDisposable
    {
        void HilfeAnfordern();
    }
}