using MySql.Data.MySqlClient;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            database.mySqlConnection();
        }
        DatabaseHelper database = new DatabaseHelper();
        private void ButtonGetSalesData_Click(object sender, EventArgs e)
        {
            chartSalesData.Series["s1"].Points.Clear();
            chartSalesData.Titles.Clear();
            var salesDataList = database.GetSalesData(dateTimePickerFromDate.Value.ToString("yyyy-MM-dd ") + "00:00:00",
                dateTimePickerToDate.Value.ToString("yyyy-MM-dd ") + "23:59:59");
            chartSalesData.Titles.Add("SalesData from " + dateTimePickerFromDate.Value.ToString("yyyy-MM-dd") 
                                        + " to " + dateTimePickerToDate.Value.ToString("yyyy-MM-dd"));
            foreach (var saleData in salesDataList)
            {
                chartSalesData.Series["s1"].Points.AddXY(saleData.ProductName + "(" + saleData.ProductSales + ")", saleData.ProductSales);                
            }



        }
    }
}
