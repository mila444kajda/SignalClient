using Signal_client.Core.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_client.Core.Services
{
    class MailService
    {
        private readonly MailSender _mailSender;
        public MailService(MailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public void Send()
        {
            _mailSender.Send();
        }
    }
}
