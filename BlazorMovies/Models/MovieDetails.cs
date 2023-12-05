
using System.Text.Json.Serialization;

namespace BlazorMovies.Models
{
    public class MovieDetails
    {
        [JsonPropertyName("adult")] public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")] public string? BackdropPath { get; set; }

        [JsonPropertyName("belongs_to_collection")]
        public MovieCollection? BelongsToCollection { get; set; }

        [JsonPropertyName("budget")] public int Budget { get; set; }

        [JsonPropertyName("genres")]
        // It is good practice to initialize a collection property to an empty array to avoid null reference errors.
        //public Genre[] Genres { get; set; } = []; // revert back to this after the next .NET 8 update
        public Genre[] Genres { get; set; } = null!;

        [JsonPropertyName("homepage")] public string? Homepage { get; set; }

        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("imdb_id")] public string? ImdbId { get; set; }

        [JsonPropertyName("original_language")]
        public string? OriginalLanguage { get; set; }

        [JsonPropertyName("original_title")] public string? OriginalTitle { get; set; }

        [JsonPropertyName("overview")] public string? Overview { get; set; }

        [JsonPropertyName("popularity")] public float Popularity { get; set; }

        [JsonPropertyName("poster_path")] public string? PosterPath { get; set; }

        [JsonPropertyName("production_companies")]
        //public ProductionCompanies[] ProductionCompanies { get; set; } = [] // revert back to this after the next .NET 8 update
        public ProductionCompanies[] ProductionCompanies { get; set; } = null!;

        [JsonPropertyName("production_countries")]
        //public ProductionCountries[] ProductionCountries { get; set; } = [] // revert back to this after the next .NET 8 update
        public ProductionCountries[] ProductionCountries { get; set; } = null!;

        [JsonPropertyName("release_date")] public string? ReleaseDate { get; set; }

        [JsonPropertyName("revenue")] public int Revenue { get; set; }

        [JsonPropertyName("runtime")] public int Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        //public SpokenLanguages[] SpokenLanguages { get; set; } = []; // revert back to this after the next .NET 8 update
        public SpokenLanguages[] SpokenLanguages { get; set; } = null!;

        [JsonPropertyName("status")] public string? Status { get; set; }

        [JsonPropertyName("tagline")] public string? Tagline { get; set; }

        [JsonPropertyName("title")] public string? Title { get; set; }

        [JsonPropertyName("video")] public bool Video { get; set; }

        [JsonPropertyName("vote_average")] public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")] public int VoteCount { get; set; }
    }

    public class Genre
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class ProductionCompanies
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo_path")]
        public string? LogoPath { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("origin_country")]
        public string? OriginCountry { get; set; }
    }

    public class ProductionCountries
    {

        [JsonPropertyName("iso_3166_1")]
        public string? Iso31661 { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class SpokenLanguages
    {

        [JsonPropertyName("english_name")]
        public string? EnglishName { get; set; }

        [JsonPropertyName("iso_639_1")]
        public string? Iso6391 { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }


    public class MovieCollection
    {
        [JsonPropertyName ("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }
    }
    
}