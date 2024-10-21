using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class HtmlNotify:Notify
    {
        public HtmlNotify(INotification notification):base(notification) { }
        public override void Notifying(string message) { _notification.Send($"<html><body><h1>HTML</h1><p>{message}</p></body></html>"); }
    }
}
