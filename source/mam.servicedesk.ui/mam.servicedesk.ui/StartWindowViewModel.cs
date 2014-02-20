using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace mam.servicedesk.ui
{
    public class StartWindowViewModel : INotifyPropertyChanged
    {
        private Action _acknowledged;
        private Action _resolved;

        public StartWindowViewModel(Action acknowledged, Action resolved)
        {
            _acknowledged = acknowledged;
            _resolved = resolved;
        }

        private bool _fehlerLiegtAn;

        public bool FehlerLiegtAn 
        {
            get { return _fehlerLiegtAn; }
            set { _fehlerLiegtAn = value; OnPropertyChanged("FehlerLiegtAn"); }
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
    }
}
