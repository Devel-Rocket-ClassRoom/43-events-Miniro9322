using System;
using System.Collections.Generic;

class Inventory
{
    public event Action<string, int, int> ItemChanged;
    private Dictionary<string, int> items = new Dictionary<string, int>();

    public void AddItem(string name, int count)
    {
        int oldCount = 0;
        int newCount = 0;
        if (items.ContainsKey(name))
        {
            oldCount = items[name];
            items[name] += count;
            newCount = items[name];
        }
        else
        {
            items.Add(name, count);
            newCount = items[name];
        }

        ItemChanged?.Invoke(name, oldCount, newCount);
    }

    public void RemoveItem(string name, int count)
    {
        int oldCount = 0;
        int newCount = 0;
        if (items.ContainsKey(name))
        {
            oldCount = items[name];
            items[name] = items[name] - count < 0 ? 0 : items[name] - count;
            newCount = items[name];
        }
        else
        {
            items.Add(name, count);
        }

        ItemChanged?.Invoke(name, oldCount, newCount);
    }
}