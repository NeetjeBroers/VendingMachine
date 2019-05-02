using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachien
{
    public partial class ProductUC : UserControl
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductUC()
        {
            InitializeComponent();
        }

        public void ButtonProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
