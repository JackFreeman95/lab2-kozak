namespace lab2_kozak;

public class CryUpdate : Crypto
{
    public CryUpdate(string id, string name, int price) : base(name, price)
    {
        Id = id;
    }
}