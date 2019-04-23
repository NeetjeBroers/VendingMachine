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
    public partial class FormVendingMachine : Form
    {
        public float Price = 120;
        public float Input = 200;
        public FormVendingMachine()
        {
            InitializeComponent();
                 Product snickers = new Product("Snickers", 120, 30, true);
                Coins Euro = new Coins("1 Euro", 100);

            Input =- Price;
            decimal a = 80/20;
            Math.Floor(a);

            label1.Text = a.ToString();

        }

    }
}
