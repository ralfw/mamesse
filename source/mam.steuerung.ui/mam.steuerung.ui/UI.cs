using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mam.contracts;
using mam.contracts.steuerung;

namespace mam.steuerung.ui
{
    public class UI : IUI
    {
        private StartWindowViewModel _viewModel;
        public void Starten()
        {
            _viewModel = new StartWindowViewModel(() => { Hilfe(); });
            var window = new StartWindow() { DataContext = _viewModel};
            var application = System.Windows.Application.Current;
            if (application == null)
            {
                application = new System.Windows.Application();

                application.Run(new StartWindow() { DataContext = _viewModel });
            }
            else
            {
                application.MainWindow = window;
                window.Show();

            }
        }

        public void HilfestatusAnzeigen(Hilfestatus status)
        {
            _viewModel.Hilfestatus = status;
        }

        public void FunktionsstatusAnzeigen(Funktionsstatus status)
        {
            _viewModel.Funktionsstatus = status;
        }


        private void Hilfe()
        {
            var tmp = Hilferuf;
            if (tmp != null)
            {
                tmp();
            }
        }

        public event Action Hilferuf;
    }
}
