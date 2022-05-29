using lab2_kozak;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var cryptos = new List<Crypto>();

app.MapGet("/cryptos", () => cryptos);

app.MapPost("/cryptos", (Crypto p) => cryptos.Add(p));

app.MapPut("/cryptos", (CryUpdate product) =>
{
    int index = cryptos.FindIndex(p => p.Id == product.Id);
    if (index > -1)
    {
        cryptos[index] = product;
    }
});

app.MapDelete("/cryptos", (string id) =>
{
    int index = cryptos.FindIndex(p => p.Id == id);
    if (index > -1)
    {
        cryptos.RemoveAt(index);
    }
});

app.Run();