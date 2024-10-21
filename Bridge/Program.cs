using Bridge;

internal class Program
{
    private static void Main(string[] args)
    {
        INotification emailNotification = new EmailNotification();
        INotification smsNotification = new SmsNotification();
        Notify htmlNotify = new HtmlNotify(emailNotification);
        Notify textNotify = new TextNotify(smsNotification);
        htmlNotify.Notifying("Hello via email");
        textNotify.Notifying("Usluga platnie sms podkluchena, s luboviu vash mts");
    }
}