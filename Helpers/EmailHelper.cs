using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace VendingMachien
{
    class EmailHelper
    {
        MailMessage mail = new MailMessage("vendingmachinenathan@gmail.com", "400028343@st.roc.a12.nl");
        public void SendAlmostOutOfStockMail(int productStock, string productName)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("vendingmachinenathan", "[VMN]2019")
            };
            mail.Subject = productName + " is almost out of stock";
            mail.Body = productName + " is almost out of stock, current stock is " + productStock + " or less";
            client.Send(mail);
            client.Dispose();
        }
        public void SendOutOfStockMail(int productStock, string productName)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("vendingmachinenathan", "[VMN]2019")
            };
            mail.Subject = productName + " is out of stock";
            mail.Body = productName + " is out of stock, go to your machine to resupply";
            client.Send(mail);
            client.Dispose();
        }

    }
}
