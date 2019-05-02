using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachien
{
    public class CoinHelper

    {
        public int TotalAmount { get; set; }
        public int Coin5 { get; set; }
        public int Coin10 { get; set; }
        public int Coin20 { get; set; }
        public int Coin50 { get; set; }
        public int Coin100 { get; set; }
        public int Coin200 { get; set; }

        public void SetTotalAmount(int totalAmount)

        {

            TotalAmount = totalAmount;

            Coin200 = totalAmount / 200;

            totalAmount = totalAmount % 200;



            Coin100 = totalAmount / 100;

            totalAmount = totalAmount % 100;



            Coin50 = totalAmount / 50;

            totalAmount = totalAmount % 50;



            Coin20 = totalAmount / 20;

            totalAmount = totalAmount % 20;


            Coin10 = totalAmount / 10;
            totalAmount = totalAmount % 10;


            Coin5 = totalAmount / 5;
            totalAmount = totalAmount % 5;
        }



        public void SetCoins(int coin5, int coin10, int coin20, int coin50, int coin100, int coin200)

        {
            Coin5 = coin5;
            Coin10 = coin10;
            Coin20 = coin20;
            Coin50 = coin50;
            Coin100 = coin100;
            Coin200 = coin200;
            TotalAmount = (coin5 * 5) + (coin10 * 10) + (coin20 * 20) + (coin50 * 50) + (coin100 * 100) + (coin200 * 200);
        }

    }
}
