using System;

class SoundSystem
{
    public void OnSoundChanged(object sender, GameEventArgs e)
    {
        Console.WriteLine($"[Sound] 이벤트: {e.EventName}");
    }
}