using System.Text.Json;
using Console.Models;

namespace Console.Services;

public class PoetryService
{
    private readonly string HafezURL;

    public PoetryService()
    {
        this.HafezURL = "https://api.ganjoor.net/api/ganjoor/hafez/faal";
    }

    public async Task<string> GetRandomPoetFromHafez()
    {
        using (var httpClient = new HttpClient())
        {
            var result = await httpClient.GetAsync(HafezURL);

            var jsonResult = await result.Content.ReadAsStringAsync();
            var content = JsonSerializer.Deserialize<Poetry>(jsonResult);

            return content?.PlainText;
        }
    }
}