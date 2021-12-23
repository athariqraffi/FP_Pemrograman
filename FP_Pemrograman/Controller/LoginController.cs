using System;
using System.Collections.Generic;
using System.Text;

namespace FP_Pemrograman.Controller
{
    class LoginController
    {
        Model.UserModel user;
        View.LoginWindow login;

        public LoginController(View.LoginWindow login)
        {
            user = new Model.UserModel();
            this.login = login;
        }

        public void Login()
        {
            user.username = login.txtUsername.Text;
            user.password = login.txtPassword.Password;

            login.dummyBox.Text = "";
            View.MainWindow main = new View.MainWindow();
            main.Show();
            login.Close();

           
        }
    }
}
