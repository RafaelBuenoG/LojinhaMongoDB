using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LojinhaServer.Collections;

[Table("products")]
[BsonIgnoreExtraElements]
public class Product
{
    [BsonId]
    [BsonRepresentation (BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    [JsonPropertyName("Nome")] // Faz aparecer como "Nome" em vez de "Name" no arquivo .json
    public string Name { get; set; }
    
    [BsonElement("description")]
    [JsonPropertyName("Descrição")]
    public string Description { get; set; }

    [BsonElement("price")]
    public decimal Price { get; set; }

    [BsonElement("offPrice")]
    public decimal OffPrice { get; set; }

    [BsonElement("categories")]
    public List<string> Categories { get; set; }

    [BsonElement("tags")]
    public List<string> Tags { get; set; }

    [BsonElement("brand")]
    public string Brand { get; set; }
}