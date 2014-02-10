using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mam.steuerung.clientprovider.test
{
    [TestClass]
    public class ClientProviderTest
    {
        [TestMethod]
        public void Nutze_SendeDownloadString_MitGoogleAdresse()
        {
            ClientProvider.SendeDownloadString("http://www.google.de");
        }

        [TestMethod, ExpectedException( typeof( System.Net.WebException ) )]
        public void Nutze_SendeDownloadString_MitNichtVorhandenerAdresse()
        {
            ClientProvider.SendeDownloadString( "http://vklthidfvtnhuvhghdfuvhugrsdih.de" );
        }
    }
}
