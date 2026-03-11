using System;

class Player
{
    public event Action<int> DamageTaken;

    private int _health = 100;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"플레이어 체력: {_health}");
        DamageTaken?.Invoke(_health);
    }
}