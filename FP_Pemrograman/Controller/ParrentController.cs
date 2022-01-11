using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Pemrograman.Controller
{
    class ParrentController
    {

        View.ParentWindow view;
        Model.UserModel user;

        public ParrentController(View.ParentWindow view)
        {
            user = new Model.UserModel();
            this.view = view;
        }

        public void ShowAdminName()
        {
            DataSet data = user.getUserById();
            string AdminName = data.Tables[0].Rows[0]["nama"].ToString();
            view.lbName.Content = AdminName;
        }

    }
}
