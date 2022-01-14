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
    /// Interaction logic for ParentWindow.xaml
    /// </summary>
    /// 
    public partial class ParentWindow : Window
    {

        Controller.ParrentController controller;

        public ParentWindow()
        {
            InitializeComponent();
            controller = new Controller.ParrentController(this);
            controller.ShowAdminName();
        }

        private void menuDashboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new DashboardPage());
        }

        private void menuStocks_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new BarangMasukPage());
        }

        private void menuHelps_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new HelpPage());
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            if (popProfile.Visibility == Visibility.Visible)
            {
                popProfile.Visibility = Visibility.Hidden;
            }
            else
            {
                popProfile.Visibility = Visibility.Visible;
            }
        }

        private void drpProfile_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new ProfilePage());
        }

        private void drpHelp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new HelpPage());

        }

        private void drpLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void menuDataBarang_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new BarangMasukPage());
        }

        private void menuDataSupplier_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new SupplierPage());
        }

        private void menuDataTransaksi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new TransaksiPage());
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Properties["id_admin"] = null;
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();
        }
    }
}
