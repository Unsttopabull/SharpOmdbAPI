using Newtonsoft.Json;

namespace Frost.SharpOmdbAPI.Models {

    /// <summary>Represents the OmdbAPI Search match</summary>
    public class OmdbSearch {

        /// <summary>Gets or sets the movie title.</summary>
        /// <value>The movie title.</value>
        public string Title { get; set; }

        /// <summary>Gets or sets the movie release year.</summary>
        /// <value>The movie release year.</value>
        public string Year { get; set; }

        /// <summary>Gets or sets the movie IMDB Id.</summary>
        /// <value>The movie IMDB Id.</value>
        [JsonProperty("imdbID")]
        public string ImdbId { get; set; }

        /// <summary>Gets or sets the type of the video (movie/series/featurette).</summary>
        /// <value>The type of the video (movie/series/featurette).</value>
        public string Type { get; set; }
    }
}
