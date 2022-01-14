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
    /// Interaction logic for PreviewWindow.xaml
    /// </summary>
    public partial class PreviewWindow : Window
    {

        Controller.PreviewController controller;
        View.BarangMasukPage barangpage;

        private string id_user;
        private Microsoft.Win32.OpenFileDialog openFile;

        public PreviewWindow(string id_user, View.BarangMasukPage barangpage)
        {
            InitializeComponent();
            controller = new Controller.PreviewController(this);
            this.barangpage = barangpage;
            openFile = new Microsoft.Win32.OpenFileDialog();
            this.id_user = id_user;
            controller.LoadPreview(id_user);
        }

        private void btnHapusBarang_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirmation = MessageBox.Show("Apakah anda yakin?", "Konfirmasi Hapus Barang", MessageBoxButton.YesNo);
            if (confirmation == MessageBoxResult.Yes)
            {
                if (controller.deleteBarang(id_user))
                {
                    MessageBox.Show("Barang sudah terhapus");
                    barangpage.RefreshBarang();
                    Close();
                } else
                {
                    MessageBox.Show("gagal");
                }
                
            }
        }

        private void btnBrowseUpdate_Click(object sender, RoutedEventArgs e)
        {
            openFile.Filter = "Image FIle (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                string selectedFileName = openFile.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                imgFotoUPdate.Source = bitmap;
            }
        }

        private void btnUbahBarang_Click(object sender, RoutedEventArgs e)
        {
            if (controller.updateBarang())
            {
                MessageBox.Show("Barang telah sukses di update");
                barangpage.RefreshBarang();
                Close();
            } else
            {
                MessageBox.Show("barang gagal diupdate");
            }
        }
    }
}
