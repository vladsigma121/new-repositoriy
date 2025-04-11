public class Animal
{
    protected string name;
    protected double weight;
    protected string breed;
    protected DateTime birthDate;

    public Animal(string name, double weight, string breed, DateTime birthDate)
    {
        this.name = name;
        this.weight = weight;
        this.breed = breed;
        this.birthDate = birthDate;
    }

    public virtual string GetInfo()
    {
        return $"Имя: {name}, Вес: {weight}, Порода: {breed}, Дата рождения: {birthDate.ToShortDateString()}";
    }
}