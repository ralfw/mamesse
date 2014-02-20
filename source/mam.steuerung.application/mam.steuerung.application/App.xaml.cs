using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using mam.steuerung.ui;
using mam.steuerung.domäne;
using mam.steuerung.serverportal;
using mam.steuerung.clientprovider;

namespace mam.steuerung.application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TraceSource _ts = new TraceSource("mam.steuerung.application", SourceLevels.All);

        protected override void OnStartup(StartupEventArgs e)
        {
            _ts.TraceEvent(TraceEventType.Start, 1, "application OnStartup...");

            var ui = new UI();
            var dom = new Domäne();
            var server = new ServerPortal();
            var servicedesk = new ClientProvider();

            ui.Hilferuf += dom.HilfeAnfordern;
            dom.HilfestatusGeändert += ui.HilfestatusAnzeigen;
            dom.FunktionsstatusGeändert += ui.FunktionsstatusAnzeigen;

            dom.Hilferuf += servicedesk.HilfeAnfordern;

            server.Zurücksetzungswunsch += dom.Zurücksetzen;
            server.Fehler += dom.Kaputtgehen;
            server.Reparaturwunsch += dom.Reparieren;
            server.HilfeUnterwegs += dom.Beruhigen;

            using(server)
            using(servicedesk)
            {
                server.Starten();
                ui.Starten();
            }

            _ts.TraceEvent(TraceEventType.Stop, 2, "application OnStartup beendet");
        }
    }
}
