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
            user.id_admin = login.txtUsername.Text;
            user.password = login.txtPassword.Password;
            bool result = user.CekLogin();

            if (result)
            {
                login.dummyBox.Text = "";
                View.ParentWindow parent= new View.ParentWindow();
                parent.Show();
                login.Close();
            }
            else
            {
                login.dummyBox.Text = "Username atau Password Salah";
                login.txtUsername.Text = "";
                login.txtUsername.Focus();
                login.txtPassword.Password = "";
            }
        }
    }
}
