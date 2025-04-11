public class Cat : Animal
{
    public Cat(string name, double weight, string breed, DateTime birthDate)
        : base(name, weight, breed, birthDate) { }

    public override string GetInfo()
    {
        return base.GetInfo() + ", Тип: Котик";
    }

    public bool CatchMouse()
    {
        Random random = new Random();
        return random.Next(0, 101) > 50;
    }
}