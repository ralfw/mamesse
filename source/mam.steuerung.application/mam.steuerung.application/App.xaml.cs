using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace mam.steuerung.application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var ui = new ui.UI();
            var dom = new domäne.Domäne();
            var server = new serverportal.ServerPortal();
            var servicedesk = new clientprovider.ClientProvider();

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
        }
    }
}
