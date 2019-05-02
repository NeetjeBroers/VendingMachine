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
        SmtpClient client = new SmtpClient();
        //public void SendAlmostOutOfStockEmail(string productID, int productStock, string productName)
        //{
        //    client.Port = 587;
        //    client.Host = "smtp.gmail.com";
        //    client.EnableSsl = true;
        //    client.Timeout = 10000;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    client.Credentials = new System.Net.NetworkCredential("smtptestnathanbroers@gmail.com", "6e7b+)FGC ~_>Nf3`");

        //    MailMessage mail = new MailMessage("smtptestnathanbroers@gmail.com", "nathanmortenbieslook@gmail.com", productName + " Is almost out of stock", productName + " Is almost out of stock there are 4 or less");
        //    mail.BodyEncoding = UTF8Encoding.UTF8;
        //    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        //    client.Send(mail);
        //}
        public void SendAlmostOutOfStockEmail(int productStock, string productName)
        {
            string mailBodyhtml =
                "<p>" + productName + " is almost out of stock, there are " + productStock + "pieces left </p>";
            var msg = new MailMessage("smtptestnathanbroers@gmail.com", "nathanmortenbieslook@gmail.com", "Fakka neef", mailBodyhtml);
            msg.To.Add("nathanmortenbieslook@gmail.com");
            msg.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com", 465); //**if your from email address is "from@hotmail.com" then host should be "smtp.hotmail.com"**
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential("smtptestnathanbroers@gmail.com", "6e7b+)FGC ~_>Nf3`");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
            Console.WriteLine("Email Sent Successfully");
        }
    }
}
