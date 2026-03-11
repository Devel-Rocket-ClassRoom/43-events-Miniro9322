using System;

class AchievementSystem
{
    public void OnAchievementChanged(object sender, GameEventArgs e)
    {
        if(e.EventName == "Achievement")
        {
            Console.WriteLine($"업적 달성: {e.Data}");
        }
    }
}