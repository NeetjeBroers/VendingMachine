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
        public void ChangeCoinStock(string coinName, int coinQuantity)
        {
            ConnectionObject.Open();

            string productQuery = "UPDATE coin SET coinQuantity = " + coinQuantity + " WHERE coinName = " + coinName;
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            ConnectionObject.Close();
        }
        public void ChangeCoinStockAdd(string coinName, int selectedCoin)
        {
            ConnectionObject.Open();

            string productQuery = "UPDATE coin SET coinQuantity = coinQuantity + " + selectedCoin + " WHERE coinName = " + coinName;
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            ConnectionObject.Close();
        }
        public void ChangeCoinStockSubstract(int coinName, int coinsToSubstract)
        {
            ConnectionObject.Open();

            string productQuery = "UPDATE coin SET coinQuantity = coinQuantity - " + coinsToSubstract + " WHERE coinName = " + coinName;
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

        public List<SaleDataModel> GetSalesData(string fromDate, string toDate)
        {
            ConnectionObject.Open();

            string productQuery = "SELECT product.ProductName, productLedger.Product_productID, SUM(productLedger.ProductQuantity) AS Quantity " +
                "FROM `productledger` AS productLedger, `product` " +
                "AS product " +
                "WHERE productLedger.DateTime >= '" + fromDate +
                "' AND productLedger.DateTime <= '" + toDate +
                "' AND productLedger.Product_productID = product.ProductID " +
                "GROUP BY productLedger.Product_productID";
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            var salesDataList = new List<SaleDataModel>();
            while (reader.Read())
            {
                var saleData = new SaleDataModel();
                saleData.ProductName = reader.GetString("ProductName");
                saleData.ProductSales = - reader.GetInt32("Quantity");
                salesDataList.Add(saleData);
            }

            ConnectionObject.Close();

            return salesDataList;
        }

        public int GetCoinStock(int coinName)
        {
            ConnectionObject.Open();

            string productQuery = "SELECT coinQuantity FROM coin WHERE coinName = " + coinName;
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            var coinStock = reader.GetInt32("coinQuantity");

            ConnectionObject.Close();

            return coinStock;
        }
    }
}
