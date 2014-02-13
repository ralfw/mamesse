using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using mam.contracts;

namespace mam.steuerung.ui.tests
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var fern = new DlgFernsteuerung();
            var sut = new UI();

            fern.Reset += () => sut.FunktionsstatusAnzeigen(Funktionsstatus.Läuft);
            fern.Fehler += () => sut.FunktionsstatusAnzeigen(Funktionsstatus.Kaputt);

            sut.Hilferuf += () => MessageBox.Show("Hilfe!");

            fern.Show();

            sut.Initialize();
            Application.Current.MainWindow.Show();
        }
    }
}
