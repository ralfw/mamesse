using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using mam.contracts;
using mam.contracts.servicedesk;

namespace mam.servicedesk.ui
{
    public class UI : IUI
    {
        readonly TraceSource _ts = new TraceSource("mam.servicedesk.ui", SourceLevels.All);

        private StartWindowViewModel _viewModel;

        public void Starten()
        {
            Initialize();
            Application.Current.MainWindow.ShowDialog();
        }

        internal void Initialize()
        {
            _viewModel = new StartWindowViewModel(IchKomme, FehlerBehoben);
            var window = new StartWindow { DataContext = _viewModel };
            Application.Current.MainWindow = window;
        }

        public event Action IchKomme;
        public event Action FehlerBehoben;

        public void FehlerAnzeigen(bool status)
        {
            _viewModel.FehlerLiegtAn = status;
        }
    }
}
