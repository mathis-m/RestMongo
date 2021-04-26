using System.Text.Json.Serialization;
using MongoBase.Attributes;
using MongoBase.Interfaces;
using Sample.Domain.Models.Enities;
public class MaterialClassificationDTO 
{


    public string AttributeId { get; set; }
    [IsQueryableAttribute()]
    [JsonPropertyName("Label")]
    public string Label { get; set; }
    [IsQueryableAttribute()]
    [JsonPropertyName("Value")]
    public string Value { get; set; }
    [IsQueryableAttribute()]
    [JsonPropertyName("ValueText")]
    public string ValueText { get; set; }





}