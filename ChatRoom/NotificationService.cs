using System;
using System.Linq;

class NotificationService
{
    public void OnMessageSended(string sender, string message)
    {
        if (message.Contains("긴급"))
        {
            Console.WriteLine("[알림] 긴급 메시지 수신!");
        }
    }
}