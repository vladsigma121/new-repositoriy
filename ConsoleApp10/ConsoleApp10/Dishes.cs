using System.Diagnostics;

public class Dish : CafeMenu
{
    private double calories;
    private double weight;

    public Dish(string itemName, decimal price, string category, double calories, double weight)
        : base(itemName, price, category)
    {
        this.calories = calories;
        this.weight = weight;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Калорийность: {calories} ккал, Вес: {weight} г";
    }

    public decimal PricePerGram()
    {
        return price / (decimal)weight;
    }
}