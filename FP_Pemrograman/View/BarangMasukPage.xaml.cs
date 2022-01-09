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

        private Microsoft.Win32.OpenFileDialog openFile;

        public BarangMasukPage()
        {
            InitializeComponent();
            barang = new Controller.BarangController(this);
            barang.populateSupplier();
            barang.loadBarang();
            openFile = new Microsoft.Win32.OpenFileDialog();
        }

        private void btnSimpanBrng_Click(object sender, RoutedEventArgs e)
        {
            string filename = txtIdBrng.Text + ".jpg";
            string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                "\\FotoBarang\\" + filename;
            System.IO.File.Copy(openFile.FileName, path, true);
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

        private void dtpTglMsk_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            openFile.Filter = "Image FIle (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                string selectedFileName = openFile.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                imgFoto.Source = bitmap;
            }
        }
    }
}
