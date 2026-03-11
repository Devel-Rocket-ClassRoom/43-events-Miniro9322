using System;

class ScoreSystem
{
    public void OnScoreChanged(object sender, GameEventArgs e)
    {
        if(e.EventName == "ScoreChanged")
        {
            Console.WriteLine($"점수 변경: {e.Data}점");
        }
    }
}