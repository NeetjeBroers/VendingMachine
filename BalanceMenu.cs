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
        public BalanceMenu()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (labelCurrentBalanceValue.Text == "0")
            {
                labelCurrentBalanceValue.Text = "";
            }
            Button button = (Button)sender;
            labelCurrentBalanceValue.Text = labelCurrentBalanceValue.Text + button.Text;

            
        }
    }
}
