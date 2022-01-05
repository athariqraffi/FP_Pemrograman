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
    public partial class ParentWindow : Window
    {
        public ParentWindow()
        {
            InitializeComponent();
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
    }
}
