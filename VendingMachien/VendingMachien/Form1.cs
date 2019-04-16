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
        public FormVendingMachine()
        {
            InitializeComponent();

        }

        Product snickers = new Product("Snickers", 1.20, 30, true);
    }
}
