﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJD2
{
    public static class SQLClass
    {
       public const string CONNECTION_STRING =
       "SslMode=none;Server=localhost;Database=rjd;port=3306;Uid=root;charset=utf8";

        public static MySqlConnection CONN;
        //Функция SELECT-запроса
        public static List<string> MySelect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            conn.Close();
            return list;
        }
        //Функция INSERT-запроса
        public static void MyUpDate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }
    }
}
