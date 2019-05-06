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
        public int Coin5Stock { get; set; }
        public int Coin10Stock { get; set; }
        public int Coin20Stock { get; set; }

        public int Coin50Stock { get; set; }
        public int Coin100Stock { get; set; }
        public int Coin200Stock { get; set; }

        public void SetTotalAmount(int totalAmount)

        {

            TotalAmount = totalAmount;
            Coin200 = totalAmount / 200;
            if (Coin200 > Coin200Stock)
            {
                Coin200 = Coin200Stock;
            }
            totalAmount = totalAmount - (Coin200 * 200);

            Coin100 = totalAmount / 100;
            if (Coin100 > Coin100Stock)
            {
                Coin100 = Coin100Stock;
            }
            totalAmount = totalAmount - (Coin100 * 100);

            Coin50 = totalAmount / 50;
            if (Coin50 > Coin50Stock)
            {
                Coin50 = Coin50Stock;
            }
            totalAmount = totalAmount - (Coin50 * 50);

            Coin20 = totalAmount / 20;
            if (Coin20 > Coin20Stock)
            {
                Coin20 = Coin20Stock;
            }
            totalAmount = totalAmount - (Coin20 * 20);

            Coin10 = totalAmount / 10;
            if (Coin10 > Coin10Stock)
            {
                Coin10 = Coin10Stock;
            }
            totalAmount = totalAmount - (Coin10 * 10);

            Coin5 = totalAmount / 5;
            if (Coin5 > Coin5Stock)
            {
                Coin5 = Coin5Stock;
            }
            totalAmount = totalAmount - (Coin5 * 5);
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


        public int ConvertCurrencyToInt(string currencyValue)
        {
            var currentBalanceWithoutCurrency = currencyValue.Substring(2, currencyValue.Length - 2);

            var decimalCurrentBalanceWithoutCurrency = decimal.Parse(currentBalanceWithoutCurrency);

            var decimalToIntCurrentBalanceWithoutCurrency = decimalCurrentBalanceWithoutCurrency * 100;

            var intCurrentBalance = decimal.ToInt32(decimalToIntCurrentBalanceWithoutCurrency);

            int currentBalanceValue = Int32.Parse(intCurrentBalance.ToString());

            return currentBalanceValue;
        }

    }
}
