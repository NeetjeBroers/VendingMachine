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

            string productQuery = "select * from product order by productID";
            MySqlCommand command = new MySqlCommand(productQuery, ConnectionObject);
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                LekkersUC ucProduct = new LekkersUC();
                ucProduct.BackgroundImage = Image.FromFile(reader.GetString("LinkAfbeelding"));
                ucProduct.Id = reader.GetInt32("IDProduct");
                ucProduct.Naam = reader.GetString("Naam");
                ucProduct.Prijs = reader.GetFloat("Prijs");
                ucProduct.WichtArticle = reader.GetBoolean("WichtArticle");
                ucProduct.Eenheid = reader.GetString("Eenheid");
                ucProduct.Left = 160 * imageNr;
                ucProduct.Top = 160 * rowNr;
                ucProduct.Click += UcProduct_Click;
                pnlProduct.Controls.Add(ucProduct);
                imageNr++;
                if ((imageNr * 160) + 150 >= pnlProduct.Width - 20)
                {
                    imageNr = 0;
                    rowNr++;
                }
            }
            ConnectionObject.Close();
        }
    }

}


