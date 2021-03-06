using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FP_Pemrograman.Model
{
    class ModelTemplateQuery
    {
        private static SqlConnection conn;
        private SqlCommand command;
        private bool result;

        public ModelTemplateQuery()
        {
            GetConnection();
        }

        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-CA6UQE7\\WIDIXON;" +
                                    "Initial Catalog = projectakhirfinalfinal;" +
                                    "Integrated Security = True";
            return conn;
        }




        public DataSet Select(string tabel, string kondisi = "") //function select data (read)
        {
            GetConnection();

            DataSet dataSet = new DataSet();
            conn.Open();
            command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            if (kondisi == "")
            {
                command.CommandText = "SELECT * FROM " + tabel;
            }
            else
            {
                command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet, tabel);
           /* try
            {
               
            }
            catch (SqlException)
            {
                dataSet = null;
            }*/

            conn.Close();
            return dataSet;
        }

        public DataSet CustomSelect(string tabel, string data, string kondisi = "")
        {
            GetConnection();

            DataSet dataSet = new DataSet();
            conn.Open();
            command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            if (kondisi == "")
            {
                command.CommandText = "SELECT " + data + " FROM " + tabel;
            }
            else
            {
                command.CommandText = "SELECT " + data + " FROM " + tabel + " " + kondisi;
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet, tabel);
            /* try
             {

             }
             catch (SqlException)
             {
                 dataSet = null;
             }*/

            conn.Close();
            return dataSet;
        }

        public Boolean Insert(string tabel, string data) //insert data (create)
        {
            GetConnection();
            result = false;

            string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
            conn.Open();
            command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            command.ExecuteNonQuery();
            result = true;

          /*  try
            {
                
            }
            catch (SqlException)
            {
                result = false;
            }*/
            conn.Close();
            return result;
        }

        public DataSet SelectData(string query, string tabel)
        {
            DataSet ds = new DataSet();
            conn.Open();
            command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, tabel);
           
            conn.Close();
            return ds;
        }

        public Boolean Update(string tabel, string data, string kondisi) //update data (update)
        {
            GetConnection();
            result = false;

            try
            {
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Delete(string tabel, string kondisi) //delete data (delete)
        {
            GetConnection();
            result = false;

            try
            {
                string query = "DELETE FROM " + tabel + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean customNonQuery(string query)
        {
            GetConnection();

            Boolean result;
            int a = 0;

            conn.Open();
            command = new SqlCommand(query, conn);
            try
            {
                a = command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();

            return result;
        }


    }
}

