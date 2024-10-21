using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class EmailNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notification from Email:{message}");
        }
    }
}
