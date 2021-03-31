using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace BeePack.Models
{
    public class Email
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("info@firajans.com", "BeePacks Sitesinden Yeni Mesaj Var!");
            var toAddress = new MailAddress("info@gizemcandemir.com.tr");
            const string subject = "Yeni Mesaj!";
            using (var smtp = new SmtpClient
            {
                Host = "rd-prime-win.guzelhosting.com", //smtp bilgileri buraya gelecek
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "Safir06.")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}