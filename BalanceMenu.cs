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
       public decimal CurrentBalance;
        public BalanceMenu()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var moneyValue = Decimal.Parse(button.Text);

            CurrentBalance = CurrentBalance + moneyValue;

            if (labelCurrentBalanceValue.Text == "0")
            {
                labelCurrentBalanceValue.Text = "";
            }

            labelCurrentBalanceValue.Text = CurrentBalance.ToString("C");
        }

        private void ButtonRefundBalance_Click(object sender, EventArgs e)
        {
            CurrentBalance = 0;
            labelCurrentBalanceValue.Text = CurrentBalance.ToString("C");
        }
    }
}
