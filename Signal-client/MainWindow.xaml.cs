using Signal_client.Core;
using Signal_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Signal_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MailMessage message = new MailMessage();
            message.Body = "test";
            message.Subject = "Zgłoszenie nieprawidłowości";
            message.To = "e.kajda@doradztwoiksiegi.com";
            message.Server = "smtp.gmail.com";
            message.From = "21edqcds@gmail.com";
            MailSender.Send(message);
        }
    }
}
