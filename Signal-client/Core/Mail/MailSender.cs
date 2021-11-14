using Signal_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Signal_client.Core.Mail
{
    class MailSender
    {
        private readonly Models.MailMessage _mailMessage;
        public MailSender( Models.MailMessage mailMessage)
        {
            _mailMessage = mailMessage;
        }
        public void Send()
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(_mailMessage.From, _mailMessage.To, _mailMessage.Subject, _mailMessage.Body);
            SmtpClient client = new SmtpClient(_mailMessage.Server);
            client.Credentials = new NetworkCredential(_mailMessage.From, _mailMessage.Password);
            client.EnableSsl = true;
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
