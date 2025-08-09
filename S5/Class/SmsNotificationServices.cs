using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S5.Interface;

namespace S5.Class
{
    internal class SmsNotificationServices : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending an Sms\nMessage : {message}\nTo : {recipient}\n");

        }
    }
}
