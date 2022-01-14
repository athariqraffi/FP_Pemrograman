﻿using System;
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
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {

        private Controller.DashboardController controller;

        public DashboardPage()
        {
            InitializeComponent();
            controller = new Controller.DashboardController(this);
            controller.Refresh();
            controller.showincome();
            controller.showjumlahmasuktoday();
            controller.DataTransaksi();
        }
    }
}
