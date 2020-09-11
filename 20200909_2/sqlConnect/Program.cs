using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySqlX.XDevAPI;
using System.Data;
using MySql.Data.MySqlClient;

namespace sqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet aDataSet = new DataSet();
            string Query = "SERVER=192.168.0.106;DATABASE=mydb;UID=root;PASSWORD=1234;";

            using (MySqlConnection aMySqlConnection = new MySqlConnection())
            {
                Query = "SELECT * FROM tblRegister";
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(Query,aMySqlConnection);
                aMySqlDataAdapter.Fill(aDataSet, "tblRegister");
            }

            DataRow aDataRow;
            aDataRow = aDataSet.Tables["tblRegister"].Rows[0];
            Console.WriteLine(aDataSet.Tables["tblRegister"].Rows.Count);
        }
    }
}
    
