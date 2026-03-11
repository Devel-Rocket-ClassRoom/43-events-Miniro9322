using System;

class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; }
    public decimal NewPrice { get; }
    public decimal ChangePercent { get; }

    public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
        if (oldPrice != 0)
        {
            ChangePercent = (newPrice - oldPrice) / oldPrice * 100;
        }
    }
}