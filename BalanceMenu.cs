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

        public int CurrentBalance;
        CoinHelper coin = new CoinHelper();
        public BalanceMenu()
        {
            InitializeComponent();

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            var moneyValue = Int32.Parse(button.Text);
            coin.SetTotalAmount(coin.TotalAmount + moneyValue);
            double testXx = coin.TotalAmount;
            testXx = testXx / 100;

            labelCurrentBalanceValue.Text = testXx.ToString("C");
        }

        

        private void ButtonRefundBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(coin.Coin5.ToString() + " X 0,05" + Environment.NewLine +
                            coin.Coin10.ToString() + " X 0,10" + Environment.NewLine +
                            coin.Coin20.ToString() + " X 0,20" + Environment.NewLine +
                            coin.Coin50.ToString() + " X 0,50" + Environment.NewLine +
                            coin.Coin100.ToString() + " X 1,00" + Environment.NewLine +
                            coin.Coin200.ToString() + " X 2,00");
            labelCurrentBalanceValue.Text = "0,00";
        }
    }
}
