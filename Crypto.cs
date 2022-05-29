namespace lab2_kozak;

public class Crypto
{
    public string Id { get; protected set; }
    public string Name { get; }
    public int Price { get; }

    public Crypto(string name, int price)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Price = price;
    }
}