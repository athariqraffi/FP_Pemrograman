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
using System.Windows.Shapes;

namespace FP_Pemrograman.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Controller.LoginController user;
        public LoginWindow()
        {
            InitializeComponent();

            user = new Controller.LoginController(this);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            user.Login();
        }
    }
}