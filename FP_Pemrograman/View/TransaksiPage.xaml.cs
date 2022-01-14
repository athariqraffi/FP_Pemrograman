using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FP_Pemrograman.View
{

    /// <summary>
    /// Interaction logic for TransaksiPage.xaml
    /// </summary>
    public partial class TransaksiPage : Page
    {
        Controller.TransaksiController transaksi;
        public TransaksiPage()
        {
            InitializeComponent();
            transaksi = new Controller.TransaksiController(this);
            transaksi.DataTransaksi();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCari_Click(object sender, RoutedEventArgs e)
        {
            transaksi.DataTransaksi();
        }
    }
}
