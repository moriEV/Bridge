using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Notify
    {
        protected INotification _notification;
        protected Notify(INotification notification)
        {
            _notification = notification;
        }
        public abstract void Notifying(string message);
    }
}
