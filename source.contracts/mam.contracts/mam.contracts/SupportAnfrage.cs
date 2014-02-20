using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace mam.contracts
{
    public enum SupportStatus
    {
        offen,
        inBearbeitung,
        erledigt,
    }

    public class SupportAnfrage : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private string _gerät;
        private int _fehlerNummer;

        public SupportAnfrage(string name, string gerät, int fehlernummer)
        {
            Id = Guid.NewGuid();
            Name = name;
            Gerät = gerät;
            FehlerNummer = fehlernummer;
            Status = SupportStatus.offen;
        }

        public SupportStatus Status { get; set; }

        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Gerät
        {
            get { return _gerät; }
            private set { _gerät = value; }
        }

        public int FehlerNummer
        {
            get { return _fehlerNummer; }
            private set { _fehlerNummer = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
