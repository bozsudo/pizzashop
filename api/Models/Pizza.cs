using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api;

public class Pizza
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    [BsonElement("name")]
    public string Name { get; set; } = null!;

    [BsonElement("isGlutenFree")]
    public bool IsGlutenFree { get; set; }
}
