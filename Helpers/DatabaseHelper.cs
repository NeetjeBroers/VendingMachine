using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VendingMachien
{
    class DatabaseHelper
    {
        public MySqlConnection ConnectionObject;
        public void mySqlConnection()
        {
            string conString = "Server= localhost; Database = vendingmachine; Uid=root";

            try
            {
                if (ConnectionObject == null)
                    ConnectionObject = new MySqlConnection(conString);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    default:
                        throw;
                }
            }
        }
    }
}
