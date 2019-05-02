using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VendingMachien
{
    public partial class FormVendingMachine : Form
    {
        DatabaseHelper database = new DatabaseHelper();
        public float Price = 120;
        public float Input = 200;
        public FormVendingMachine()
        {
            InitializeComponent();
            CoinHelper Euro = new CoinHelper();
        }

        private void FormVendingMachine_Load(object sender, EventArgs e)
        {
            database.mySqlConnection();
            ShowProducts();


        }
        private void ButtonAddBalance_Click(object sender, EventArgs e)
        {
            BalanceMenu balanceMenu = new BalanceMenu();
            balanceMenu.Show();
            balanceMenu.Refresh();

            labelCurrentBalanceValue.Text = BalanceMenu.CurrentBalanceValue;
        }

        private void ShowProducts()
        {
            panelProduct.Controls.Clear();
            database.ConnectionObject.Open();

            string productQuery = "select * from product order by ProductID";
            MySqlCommand command = new MySqlCommand(productQuery, database.ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            var imageNr = 0;
            var rowNr = 0;

            while (reader.Read())
            {
                ProductUC ucProduct = new ProductUC();
                ucProduct.BackgroundImage = Image.FromFile(reader.GetString("ImagePath"));
                ucProduct.ID = reader.GetInt32("ProductID");
                ucProduct.Name = reader.GetString("ProductName");
                ucProduct.Price = reader.GetInt32("ProductPrice");
                ucProduct.Stock = reader.GetInt32("ProductStock");
                ucProduct.Left = 160 * imageNr;
                ucProduct.Top = 300 * rowNr;
                ucProduct.Click += UcProduct_Click;
                panelProduct.Controls.Add(ucProduct);
                imageNr++;
                if ((imageNr * 160) + 15 >= panelProduct.Width - 20)
                {
                    imageNr = 0;
                    rowNr++;
                }
            }
            database.ConnectionObject.Close();
        }
        private void UcProduct_Click(object sender, EventArgs e)
        {
            var ucProduct = (ProductUC)sender;

        }

        private void BalanceMenu_FormClosed(object sender, FormClosingEventArgs e)
        {
                CoinHelper coin = new CoinHelper();
                BalanceMenu.CurrentBalanceValue = coin.TotalAmount.ToString();
        }
    }

}


