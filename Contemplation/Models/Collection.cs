using System.Net.Http.Json;
using Contemplation.Pages;

namespace Contemplation.Models;

public class Collection
{
    public string Name { get; set; }
    public CollectionImage[] Images { get; set; }

    public string GetFullPath(CollectionImage image) =>
        $"collections/{Name}/{image.Filename}";
    
    public static async Task<Collection?> GetCollection(string id, HttpClient http) =>
        await http.GetFromJsonAsync<Collection>("collections/" + id);
}