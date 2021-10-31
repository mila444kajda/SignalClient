using Signal_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Signal_client.Core
{
    class MailSender
    {
        public static void Send(Models.MailMessage mailMessage)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(mailMessage.From, mailMessage.To, mailMessage.Subject, mailMessage.Body);
            SmtpClient client = new SmtpClient(mailMessage.Server);
            client.Credentials = new NetworkCredential("21edqcds@gmail.com", "P@ssw0rd_");
            client.EnableSsl = true;
            client.Port = 587;
            try
            {
                client.Send(message);
                MessageBox.Show("Twoje zgłoszenie zostało wysłane");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
