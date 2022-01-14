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
using System.Windows.Shapes;

namespace FP_Pemrograman.View
{
    /// <summary>
    /// Interaction logic for SupplierUpdateWindow.xaml
    /// </summary>
    public partial class SupplierUpdateWindow : Window
    {

        private Controller.UpdateSupplierController controller;
        private SupplierPage page;

        public SupplierUpdateWindow(SupplierPage page,string id)
        {
            InitializeComponent();
            controller = new Controller.UpdateSupplierController(this, id);
            this.page = page;
        }

        private void btnBatalBrng_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSimpanBrng_Click(object sender, RoutedEventArgs e)
        {
            if (controller.updateSupplier())
            {
                MessageBox.Show("Data berhasil diubah");
                page.Refresh();
                Close();
            }
            else
            {
                MessageBox.Show("Data Gagal Diubah");

            }
        }
    }
}
