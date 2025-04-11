public class CafeMenu
{
    protected string itemName;
    protected decimal price;
    protected string category;

    public CafeMenu(string itemName, decimal price, string category)
    {
        this.itemName = itemName;
        this.price = price;
        this.category = category;
    }

    public virtual string GetInfo()
    {
        return $"Название: {itemName}, Цена: {price:C}, Категория: {category}";
    }
}