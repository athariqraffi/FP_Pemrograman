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
    /// Interaction logic for SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : Page
    {
        Controller.SupplierController supplier;
        public SupplierPage()
        {
            InitializeComponent();
            supplier = new Controller.SupplierController(this);
        }

        public void Refresh()
        {
            supplier.loadSupplier();
        }

        private void btnSimpanBrng_Click(object sender, RoutedEventArgs e)
        {
            supplier.InsertController();
        }

        private void btnAddSupplier_Click(object sender, RoutedEventArgs e)
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

        private void btnHapusSupplier_Click(object sender, RoutedEventArgs e)
        {
            object idx = dgSupplier.SelectedItem;
            if (idx == null)
            {
                MessageBox.Show("Silahkan pilih supplier terlebih dahulu");
            }
            else
            {
                string id_supplier = (dgSupplier.SelectedCells[0].Column.GetCellContent(idx) as TextBlock).Text;
                MessageBoxResult conf = MessageBox.Show("Apakah anda yakin?", "Konfirmasi", MessageBoxButton.YesNo);
                if(conf == MessageBoxResult.Yes)
                {
                    supplier.remvoeSupplier(id_supplier);
                }
            }
        }

        private void dgSupplier_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = dgSupplier.SelectedItem;
            string id_supplier = (dgSupplier.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            SupplierUpdateWindow window = new SupplierUpdateWindow(this, id_supplier);
            window.Show();
        }
    }
}
