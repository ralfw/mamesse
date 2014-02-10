using System.Configuration;
using System.Net;
using mam.contracts.steuerung;

namespace mam.steuerung.clientprovider
{
    public class ClientProvider : IClientProvider
    {
        public void Dispose()
        {
            // mach was, wenn nötig.
        }

        public void HilfeAnfordern()
        {
            var downloadString = ConfigurationSettings.AppSettings.Get("servicedesk.endpunkt") + "/pleaseHelp";
            SendeDownloadString( downloadString );
        }

        public static void SendeDownloadString(string downloadString)
        {
            var wc = new WebClient();
            wc.DownloadString( downloadString );
        }
    }
}
