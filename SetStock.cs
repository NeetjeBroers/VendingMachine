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
    public partial class SetStock : Form
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        DatabaseHelper database = new DatabaseHelper();
        public SetStock()
        {
            InitializeComponent();
            database.mySqlConnection();            
        }
        private void ButtonSetStock_Click(object sender, EventArgs e)
        {
            var newStock = Int32.Parse(textBoxNewStock.Text);
            database.ChangeStock(ProductID,newStock);
            
            this.Close();
        }

        private void SetStock_Load(object sender, EventArgs e)
        {
            labelProductName.Text = ProductName;
        }
    }
}
