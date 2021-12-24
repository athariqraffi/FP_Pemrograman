using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Pemrograman.Model
{
    class UserModel
    {
        public string id_user,
                      username,
                      password;

        //declare object from ModelTemplate
        ModelTemplateQuery temp;

        //instance
        public UserModel()
        {
            temp = new ModelTemplateQuery();
        }

        public bool CekLogin()
        {
            bool result;

            DataSet dataSet = new DataSet();

            dataSet = temp.Select("userLogin", "username = '" + username + "' AND password = '" + password + "'");

            if (dataSet.Tables[0].Rows.Count > 0) //kondisi jika tables memiliki data atau tidak 
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
