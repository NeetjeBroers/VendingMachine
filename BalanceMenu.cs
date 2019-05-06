using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachien
{
    public partial class BalanceMenu : Form
    {
        public static string CurrentBalanceValue = "";
        public FormVendingMachine vending;

        public int CurrentBalance;
        CoinHelper coin = new CoinHelper();
        DatabaseHelper database = new DatabaseHelper();

        public BalanceMenu(FormVendingMachine vendingMachine)
        {
            InitializeComponent();
            database.mySqlConnection();
            vending = vendingMachine;
            coin.TotalAmount = coin.ConvertCurrencyToInt(vending.labelCurrentBalanceValue.Text);
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            database.ChangeCoinStockAdd(button.Text,1);
            var moneyValue = Int32.Parse(button.Text);
            coin.SetTotalAmount(coin.TotalAmount + moneyValue);            
            double totalAmount = coin.TotalAmount;
            totalAmount = totalAmount / 100;

            vending.labelCurrentBalanceValue.Text = totalAmount.ToString("C");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
