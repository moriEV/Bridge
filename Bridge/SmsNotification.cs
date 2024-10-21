using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SmsNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notification from sms:{message}. -15 rublei,sraniy mts");
        }
    }
}
