using System;

class ChatLogger
{
    public void OnMessageSended(string sender, string message)
    {
        Console.WriteLine($"[로그] {sender}: {message}");
    }
}