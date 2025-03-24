using MongoDB.Driver;

namespace api;

public class PizzaService
{
    private readonly IMongoCollection<Pizza> _pizzaCollection;

    public PizzaService(IConfiguration config)
    {
        var mongoClient = new MongoClient(config["MongoDB:ConnectionString"]);
        var database = mongoClient.GetDatabase(config["MongoDB:DatabaseName"]);
        _pizzaCollection = database.GetCollection<Pizza>("pizzas");
    }

    public async Task<List<Pizza>> GetAllAsync() => 
        await _pizzaCollection.Find(_ => true).ToListAsync();
}
