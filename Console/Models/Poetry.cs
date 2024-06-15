using System.Text.Json.Serialization;

namespace Console.Models;

public class Poetry
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("fullTitle")]
    public string FullTitle { get; set; }
    [JsonPropertyName("plainText")]
    public string PlainText { get; set; }
}