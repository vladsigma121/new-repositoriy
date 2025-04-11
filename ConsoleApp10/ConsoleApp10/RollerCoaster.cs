public class RollerCoaster : Attraction
{
    private decimal ticketPrice;

    public RollerCoaster(string name, TimeSpan duration, int maxCapacity, decimal ticketPrice)
        : base(name, duration, maxCapacity)
    {
        this.ticketPrice = ticketPrice;
    }

    public decimal CalculateRevenue(int peopleCount = 0)
    {
        if (peopleCount == 0)
        {
            peopleCount = maxCapacity;
        }
        return peopleCount * ticketPrice;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Цена одной поездки: {ticketPrice:C}";
    }
}
//huvgtuivbubnuiscd