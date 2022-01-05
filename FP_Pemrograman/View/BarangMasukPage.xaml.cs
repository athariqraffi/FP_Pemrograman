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
    /// Interaction logic for BarangMasukPage.xaml
    /// </summary>
    public partial class BarangMasukPage : Page
    {
        Controller.BarangController barang;

        public BarangMasukPage()
        {
            InitializeComponent();
            barang = new Controller.BarangController(this);
            barang.populateSupplier();
        }

        private void btnSimpanBrng_Click(object sender, RoutedEventArgs e)
        {
            barang.InsertController();
        }

        private void btnTambahMasuk_Click(object sender, RoutedEventArgs e)
        {
            if (popTambah.Visibility == Visibility.Visible)
            {
                popTambah.Visibility = Visibility.Hidden;
            }
            else
            {
                popTambah.Visibility = Visibility.Visible;
            }
        }

        private void btnTambahMasuk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (popTambah.Visibility == Visibility.Visible)
            {
                popTambah.Visibility = Visibility.Hidden;
            }
            else
            {
                popTambah.Visibility = Visibility.Visible;
            }
        }
    }
}
