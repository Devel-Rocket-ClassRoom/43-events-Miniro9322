using System;

class Module2
{
    public Module2()
    {
        GlobalNotifier.OnGlobalMessage += HandleMessage;
    }

    private void HandleMessage(string message)
    {
        Console.WriteLine($"[Module2] 수신: {message}");
    }
}