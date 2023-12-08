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

    public Task<PopularMoviePagedResponse?> GetPopularMoviesAsync(int page = 1)
    {
        // Validate page values
        if (page < 1) page = 1;
        if (page > 500) page = 500; // TMBD only supports up to 500 pages
        
        return _httpClient.GetFromJsonAsync<PopularMoviePagedResponse>($"movie/popular?page={page}");
    }

    public Task<MovieDetails?> GetMovieDetailsAsync(int Id)
    {
        return _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{Id}");
    }
    
}