using System;
using System.Configuration;
using System.Diagnostics;
using mam.contracts.steuerung;
using Nancy.Hosting.Self;

namespace mam.steuerung.serverportal
{
    public class ServerPortal : IServerPortal
    {
        private readonly TraceSource _ts = new TraceSource("mam.steuerung.serverportal", SourceLevels.All);

        private static NancyHost _server;

        public static ServerPortal Instance;

        public ServerPortal() { Instance = this; }


        public void Starten()
        {
            var endpunktAdresse = ConfigurationManager.AppSettings.Get("steuerung.endpunkt");
            _ts.TraceEvent(TraceEventType.Information, 0, "Serverportal starten auf {0}", endpunktAdresse);

            var nancyCfg = new HostConfiguration { UrlReservations = { CreateAutomatically = true } };
            _server = new NancyHost(nancyCfg, new Uri(endpunktAdresse));
            _server.Start();
            _ts.TraceEvent(TraceEventType.Start, 1, "Serverportal der Steuerung gestartet. ");
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


        public void Dispose()
        {
            _server.Dispose();
            _ts.TraceEvent(TraceEventType.Stop, 2, "Serverportal der Steuerung gestoppt. ");
        }
    }
}