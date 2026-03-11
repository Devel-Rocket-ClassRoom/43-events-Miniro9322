using System;

class HealthBar
{
    public void OnPlayerDamaged(int currentHealth)
    {
        Console.WriteLine($"[UI] 체력바 업데이트: {currentHealth}%");
    }
}