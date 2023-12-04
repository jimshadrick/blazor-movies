using System.Net.Http.Json;
using BlazorMovies.Models;

namespace BlazorMovies.Services;

public class TMDBClient
{
    private readonly HttpClient _httpClient;

    public TMDBClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
        _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

        string apiKey = config["TMDBKey"] ?? throw new Exception("TMDBkey not found");
        _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
    }

    public Task<PopularMoviePagedResponse> GetPopularMoviesAsync()
    {
        return _httpClient.GetFromJsonAsync<PopularMoviePagedResponse>("movie/popular");
    }
    
}