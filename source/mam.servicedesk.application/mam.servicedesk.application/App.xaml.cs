using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using mam.servicedesk.serverportal;
using mam.servicedesk.ui;
using mam.servicedesk.domäne;

namespace mam.servicedesk.application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TraceSource _ts = new TraceSource("mam.servicedesk.application", SourceLevels.All);
        protected override void OnStartup(StartupEventArgs e)
        {
            _ts.TraceEvent(TraceEventType.Start, 1, "application OnStartup...");

            var ui = new UI();
            var dom = new Domäne();
            var server = new ServerPortal();

            dom.FehlerLiegtAn += ui.FehlerAnzeigen;
            server.HilfeErfordert += dom.HilfeErfordert;

            using(server)
            {
                server.Starten();
                ui.Starten();
            }

            _ts.TraceEvent(TraceEventType.Stop, 2, "application OnStartup bendet");
        }
    }
}
