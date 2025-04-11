using System.Diagnostics;

public class Drink : CafeMenu
{
    private double volume;

    public Drink(string itemName, decimal price, string category, double volume)
        : base(itemName, price, category)
    {
        this.volume = volume;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Объем: {volume} мл";
    }

    public decimal PriceWithDiscount(decimal discountPercentage)
    {
        return price - (price * discountPercentage / 100);
    }
}