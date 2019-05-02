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
        MySqlConnection ConnectionObject;
        public float Price = 120;
        public float Input = 200;
        public FormVendingMachine()
        {
            InitializeComponent();
            Product snickers = new Product("Snickers", 120, 30, true);
            Coin Euro = new Coin();

            Input = -Price;
            decimal a = 80 / 20;
            Math.Floor(a);

            label1.Text = a.ToString();

        }

        private void FormVendingMachine_Load(object sender, EventArgs e)
        {

        }
        private void ButtonAddBalance_Click(object sender, EventArgs e)
        {
            BalanceMenu balanceMenu = new BalanceMenu();
            balanceMenu.Show();
        }

        private void mySqlConnection()
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
        private void ShowProductLB()
        {
            panelProduct.Controls.Clear();
            ConnectionObject.Open();

            string productQuery = "select * from product order by ProductID";
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();

            var imageNr = 0;
            var rowNr = 0;

            while (reader.Read())
            {
                ProductUC ucProduct = new ProductUC();
                ucProduct.BackgroundImage = Image.FromFile(reader.GetString("LinkAfbeelding"));
                ucProduct.ID = reader.GetInt32("ProductID");
                ucProduct.Name = reader.GetString("ProductName");
                ucProduct.Price = reader.GetInt32("ProductPrice");               
                ucProduct.Stock = reader.GetInt32("ProductStock");
                ucProduct.Left = 160 * imageNr;
                ucProduct.Top = 160 * rowNr;
                ucProduct.Click += UcProduct_Click;
                panelProduct.Controls.Add(ucProduct);
                imageNr++;
                if ((imageNr * 160) + 150 >= panelProduct.Width - 20)
                {
                    imageNr = 0;
                    rowNr++;
                }
            }
            ConnectionObject.Close();
        }
        private void UcProduct_Click(object sender, EventArgs e)
        {
            var ucProduct = (ProductUC)sender;
           
        }
    }

}


