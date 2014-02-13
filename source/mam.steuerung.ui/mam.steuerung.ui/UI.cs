using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using mam.contracts;
using mam.contracts.steuerung;

namespace mam.steuerung.ui
{
    public class UI : IUI
    {
        readonly TraceSource _ts = new TraceSource("mam.steuerung.ui", SourceLevels.All);

        private StartWindowViewModel _viewModel;

        public void Starten()
        {
            Initialize();
            Application.Current.MainWindow.ShowDialog();
        }

        internal void Initialize()
        {
            _viewModel = new StartWindowViewModel(Hilfe);
            var window = new StartWindow { DataContext = _viewModel };
            Application.Current.MainWindow = window;
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
            Hilferuf();
        }


        public event Action Hilferuf;
    }
}
