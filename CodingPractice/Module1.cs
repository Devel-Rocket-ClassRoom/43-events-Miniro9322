using System;

class Module1
{
    public Module1()
    {
        GlobalNotifier.OnGlobalMessage += HandleMessage;
    }

    private void HandleMessage(string message)
    {
        Console.WriteLine($"[Module1] 수신: {message}");
    }
}