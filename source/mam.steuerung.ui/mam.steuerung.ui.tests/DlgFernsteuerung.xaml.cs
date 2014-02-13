using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace mam.steuerung.ui.tests
{
    /// <summary>
    /// Interaction logic for DlgFernsteuerung.xaml
    /// </summary>
    public partial class DlgFernsteuerung : Window
    {
        public DlgFernsteuerung()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Fehler();
        }


        public event Action Reset;
        public event Action Fehler;
    }
}
