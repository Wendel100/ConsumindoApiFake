using Newtonsoft.Json;
namespace ConsumindoApiFake;
internal class Program
{
    static async Task Main(string[] args)
    {

        HttpClient client = new();
        string url = "https://jsonplaceholder.typicode.com/users/1";

        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var json = JsonConvert.DeserializeObject<Cliente.Welcome>(content);
        Console.WriteLine(json.Name);
         

    }
}
