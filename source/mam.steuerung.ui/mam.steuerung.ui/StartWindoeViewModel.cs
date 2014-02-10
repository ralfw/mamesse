using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using mam.contracts;
using System.Windows.Input;

namespace mam.steuerung.ui
{
    internal class StartWindowViewModel : INotifyPropertyChanged
    {
        private Action _action;


        public StartWindowViewModel(Action action)
        {
            _action = action;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        private Hilfestatus _hilfestatus;

        public Hilfestatus Hilfestatus
        {
            get { return _hilfestatus; }
            set { _hilfestatus = value; OnPropertyChanged("Hilfestatus"); }
        }

        private Funktionsstatus _funktionsstatus;

        public Funktionsstatus Funktionsstatus
        {
            get { return _funktionsstatus; }
            set { _funktionsstatus = value; OnPropertyChanged("Funktionsstatus"); }
        }

        RelayCommand _helpCommand;
        private Action action;
        public ICommand HelpCommand
        {
            get
            {
                if (_helpCommand == null)
                {
                    _helpCommand = new RelayCommand(param => _action());
                }
                return _helpCommand;
            }
        }

    }
}
