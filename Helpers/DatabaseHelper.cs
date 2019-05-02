using System;
using System.Collections.Generic;
using System.Data;
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


        public ProductModel GetProduct(string productID)
        {
            ConnectionObject.Open();

            string productQuery = "SELECT * FROM product WHERE ProductID = " + productID;
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            var product = new ProductModel();
            reader.Read();

            product.Id = reader.GetInt32("ProductID");
            product.Name = reader.GetString("ProductName");
            product.Price = reader.GetInt32("ProductPrice");
            product.Stock = reader.GetInt32("ProductStock");

            ConnectionObject.Close();

            return product;
        }

        public void ChangeStock(string productID, int productStock)
        {
            ConnectionObject.Open();

            string productQuery = "UPDATE product SET ProductStock = " + productStock + " WHERE ProductID = " + productID;
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            ConnectionObject.Close();
        }

        public void AddToLedger(string productID)
        {
            ConnectionObject.Open();
            var sellDate = DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            string productQuery = "INSERT INTO productledger (Product_productID, ProductQuantity, DateTime) VALUES ('" + productID + "','-1','" + sellDate + "')";
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            ConnectionObject.Close();
        }
    }
}
