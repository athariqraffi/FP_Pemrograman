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
    }
}
