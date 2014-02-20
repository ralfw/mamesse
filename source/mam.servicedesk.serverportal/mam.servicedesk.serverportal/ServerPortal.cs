using System;
using System.Configuration;
using System.Diagnostics;
using mam.contracts.servicedesk;
using Nancy.Hosting.Self;

namespace mam.servicedesk.serverportal
{
    public class ServerPortal : IServerPortal
    {
        private readonly TraceSource _ts = new TraceSource("mam.steuerung.serverportal", SourceLevels.All);

        private static NancyHost _server;

        public static ServerPortal Instance;

        public ServerPortal() { Instance = this; }

        public void Starten() 
        {
            var endpunktAdresse = ConfigurationManager.AppSettings.Get("servicedesk.endpunkt");
            _ts.TraceEvent(TraceEventType.Information, 0, "Serverportal des service desk starten auf {0}", endpunktAdresse);

            var nancyCfg = new HostConfiguration { UrlReservations = { CreateAutomatically = true } };
            _server = new NancyHost(nancyCfg, new Uri(endpunktAdresse));
            _server.Start();
            _ts.TraceEvent(TraceEventType.Start, 1, "Serverportal des service desk gestartet");
        }

        public event Action HilfeErfordert;
        public event Action Zuruecksetzungswunsch;

        public void Feuern(string command)
        {
            switch (command)
            {
                case "Reset": this.Zuruecksetzungswunsch();
                    break;
                case "Pleasehelp": this.HilfeErfordert();
                    break;
            }
        }

        public void Dispose()
        {
            _server.Dispose();
            _ts.TraceEvent(TraceEventType.Stop, 2, "Serverportal des service desk gestoppt.");
        }
    }
}
