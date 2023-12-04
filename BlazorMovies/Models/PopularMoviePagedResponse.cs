using System.Text.Json.Serialization;

namespace BlazorMovies.Models;

public class PopularMoviePagedResponse
{

    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("results")]
    //public IEnumerable<PopularMovie> Results { get; set; } = []; // revert back to this after the next .NET 8 update
    public IEnumerable<PopularMovie> Results { get; set; } = null!;

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}


