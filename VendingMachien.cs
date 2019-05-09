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
        public bool AdminMode = false;
        DatabaseHelper database = new DatabaseHelper();
        EmailHelper email = new EmailHelper();
        CoinHelper coin = new CoinHelper();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Github Projects\VendingMachine\coin-sound\coinreturn.wav");

        public FormVendingMachine(string[] args)
        {
            InitializeComponent();

            if (args.Length > 0)
            {
                if (args[0].ToLower() == "/admin")
                {
                    buttonShowAdminPage.Visible = true;
                    buttonAddCoinStock.Visible = true;
                    buttonAddBalance.Visible = false;
                    buttonRefundBalance.Visible = false;
                    AdminMode = true;
                }
            }
        }

        private void FormVendingMachine_Load(object sender, EventArgs e)
        {
            database.mySqlConnection();
            ShowProducts();


        }
        private void ButtonAddBalance_Click(object sender, EventArgs e)
        {
            var formBalanceMenu = new BalanceMenu(this);
            formBalanceMenu.Show();
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
                ucProduct.labelProductPrice.Text = (Convert.ToDouble(ucProduct.Price) / 100).ToString("C");
                ucProduct.Stock = reader.GetInt32("ProductStock");
                ucProduct.labelProductStock.Text = ucProduct.Stock.ToString();
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
            var selectedProduct = database.GetProduct(ucProduct.ID.ToString());

            if (AdminMode == true)
            {
                SetProductStockUC setStock = new SetProductStockUC();
                setStock.ProductID = ucProduct.ID.ToString();
                setStock.ProductName = ucProduct.Name;
                setStock.ShowDialog();

                ShowProducts();
            }
            else
            {
                var currentBalanceValue = coin.ConvertCurrencyToInt(labelCurrentBalanceValue.Text);
                coin.SetTotalAmount(currentBalanceValue);

                if (selectedProduct.Stock == 4)
                {
                    email.SendAlmostOutOfStockMail(selectedProduct.Stock, selectedProduct.Name);
                }
                if (selectedProduct.Stock <= 0)
                {
                    MessageBox.Show("Product out of stock");
                    email.SendOutOfStockMail(selectedProduct.Name);

                }
                else if (selectedProduct.Price > coin.TotalAmount)
                {
                    MessageBox.Show("Not enough balance, insert more coins");
                }
                else
                {
                    listBoxSoldProducts.Items.Insert(0, selectedProduct.Name);
                    coin.TotalAmount = coin.TotalAmount - selectedProduct.Price;
                    labelCurrentBalanceValue.Text = (Convert.ToDouble(coin.TotalAmount) / 100).ToString("C");
                    database.ChangeStock(ucProduct.ID.ToString(), ucProduct.Stock - 1);
                    database.AddToLedger(ucProduct.ID.ToString());
                    ucProduct.Stock = ucProduct.Stock - 1;
                    ucProduct.labelProductStock.Text = ucProduct.Stock.ToString();
                }
            }
        }

        private void ButtonRefundBalance_Click(object sender, EventArgs e)
        {
            var currentBalanceValue = coin.ConvertCurrencyToInt(labelCurrentBalanceValue.Text);
            coin.SetTotalAmount(currentBalanceValue);

            player.Play();

            MessageBox.Show(coin.Coin5.ToString() + " X 0,05" + Environment.NewLine +
                               coin.Coin10.ToString() + " X 0,10" + Environment.NewLine +
                               coin.Coin20.ToString() + " X 0,20" + Environment.NewLine +
                               coin.Coin50.ToString() + " X 0,50" + Environment.NewLine +
                               coin.Coin100.ToString() + " X 1,00" + Environment.NewLine +
                               coin.Coin200.ToString() + " X 2,00");

            database.ChangeCoinStockSubstract(5, coin.Coin5);
            database.ChangeCoinStockSubstract(10, coin.Coin10);
            database.ChangeCoinStockSubstract(20, coin.Coin20);
            database.ChangeCoinStockSubstract(50, coin.Coin50);
            database.ChangeCoinStockSubstract(100, coin.Coin100);
            database.ChangeCoinStockSubstract(200, coin.Coin200);            

            labelCurrentBalanceValue.Text = "€ 0,00";
        }

        private void ButtonShowAdminPage_Click(object sender, EventArgs e)
        {
            AdminPage adminpage = new AdminPage();

            adminpage.Show();
        }

        private void ButtonAddCoinStock_Click(object sender, EventArgs e)
        {
            BalanceMenu balanceMenu = new BalanceMenu(this);
            balanceMenu.Show();
        }
    }

}


