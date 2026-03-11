using System;

class InventoryUI
{
    public void OnItemChanged(string name, int oldCount, int newCount)
    {
        Console.WriteLine($"[UI] {name}: {oldCount} → {newCount}");
    }
}