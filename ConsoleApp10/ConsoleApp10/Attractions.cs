public class Attraction
{
    protected string name;
    protected TimeSpan duration;
    protected int maxCapacity;

    public Attraction(string name, TimeSpan duration, int maxCapacity)
    {
        this.name = name;
        this.duration = duration;
        this.maxCapacity = maxCapacity;
    }

    public virtual string GetInfo()
    {
        return $"Название: {name}, Продолжительность: {duration.TotalMinutes} минут, Максимум мест: {maxCapacity}";
    }
}