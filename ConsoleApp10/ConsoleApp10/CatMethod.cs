public class CatMethod
{
    private string nickname;
    private readonly string breed;
    private double height;
    private double weight;
    private string owner;

    public CatMethod(string nickname, string breed, double height, double weight, string owner)
    {
        this.nickname = nickname;
        this.breed = breed;
        this.height = height;
        this.weight = weight;
        this.owner = owner;
    }

    public string GetNickname()
    {
        return nickname;
    }

    public void SetNickname(string value)
    {
        nickname = value;
    }

    public string GetBreed()
    {
        return breed;
    }

    public double GetHeight()
    {
        return height;
    }

    public void SetHeight(double value)
    {
        height = value;
    }

    public double GetWeight()
    {
        return weight;
    }

    public void SetWeight(double value)
    {
        weight = value;
    }

    public string GetOwner()
    {
        return owner;
    }

    public string GetInformation()
    {
        return $"Кличка: {GetNickname()}, Порода: {GetBreed()}, Рост: {GetHeight()}, Вес: {GetWeight()}, Хозяин: {GetOwner()}";
    }
}