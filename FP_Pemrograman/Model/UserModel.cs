using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Pemrograman.Model
{
    class UserModel
    {
        public string id_admin,
                      password;

        //declare object from ModelTemplate
        ModelTemplateQuery temp;

        //instance
        public UserModel()
        {
            temp = new ModelTemplateQuery();
        }

        public DataSet getUserById()
        {
            string table = "admin";
            string id_admin = App.Current.Properties["id_admin"].ToString();
            string kondisi = string.Format("id_admin = '{0}'", id_admin);
            return temp.Select(table, kondisi);
        }

        public bool CekLogin()
        {
            bool result;

            DataSet dataSet = new DataSet();

            dataSet = temp.Select("admin", "id_admin = '" + id_admin + "' AND password = '" + password + "'");

            if (dataSet.Tables[0].Rows.Count > 0) //kondisi jika tables memiliki data atau tidak 
            {
                result = true;
                App.Current.Properties["id_admin"] = dataSet.Tables[0].Rows[0]["id_admin"].ToString();
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
