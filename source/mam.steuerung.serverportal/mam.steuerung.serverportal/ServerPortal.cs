using System;
using System.Configuration;
using mam.contracts.steuerung;
using Nancy.Hosting.Self;

namespace mam.steuerung.serverportal
{
    public class ServerPortal : IServerPortal
    {
        private static NancyHost _server;

        public static ServerPortal Instance;

        public ServerPortal()
        {
            Instance = this;
        }

        public void Dispose()
        {
            if (_server != null)
            {
                _server.Dispose();
            }
        }

        public void Starten()
        {
            var conf = ConfigurationSettings.AppSettings.Get("steuerung.endpunkt");
            _server = new NancyHost(new Uri(conf));
            _server.Start();
        }

        public event Action Zurücksetzungswunsch;
        public event Action Fehler;
        public event Action Reparaturwunsch;
        public event Action HilfeUnterwegs;

        public void Feuern(string command)
        {
            switch (command)
            {
                case "Reset": this.Zurücksetzungswunsch();
                    break;
                case "Error": this.Fehler();
                    break;
                case "Repair": this.Reparaturwunsch();
                    break;
                case "Helpunderway": this.HilfeUnterwegs();
                    break;
            }
        }
    }
}