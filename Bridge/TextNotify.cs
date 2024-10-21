using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class TextNotify:Notify
    {
        public TextNotify(INotification notification):base(notification) 
        {

        }
        public override void Notifying(string message)
        {
            _notification.Send($"Text:{message}");
        }
    }
}
