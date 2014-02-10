using NUnit.Framework;

namespace mam.steuerung.clientprovider.test
{
    [TestFixture]
    public class ClientProviderTest
    {
        [Test, Explicit]
        public void Nutze_SendeDownloadString_MitGoogleAdresse()
        {
            ClientProvider.SendeDownloadString("http://www.google.de");
        }

        [Test, Explicit, ExpectedException( typeof( System.Net.WebException ) )]
        public void Nutze_SendeDownloadString_MitNichtVorhandenerAdresse()
        {
            ClientProvider.SendeDownloadString( "http://vklthidfvtnhuvhghdfuvhugrsdih.de" );
        }
    }
}
