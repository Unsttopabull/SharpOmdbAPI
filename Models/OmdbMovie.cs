
using Newtonsoft.Json;

namespace Frost.SharpOmdbAPI.Models {

    /// <summary>Represents the Omdb API movie information data</summary>
    public class OmdbMovie {

        /// <summary>Movie title</summary>
        public string Title { get; set; }

        /// <summary>Movie releaase year</summary>
        public string Year { get; set; }

        /// <summary>MPAA Rating</summary>
        public string Rated { get; set; }

        /// <summary>Release date (date month year)</summary>
        public string Released { get; set; }

        /// <summary>Movie duration in minutes (in format "X minutes")</summary>
        public string Runtime { get; set; }

        /// <summary>Genres split by ", "</summary>
        public string Genre { get; set; }

        /// <summary>Movie director</summary>
        public string Director { get; set; }

        /// <summary>Movie writers split by ", " can have elaborations in () eg. John Ridley (screenplay),</summary>
        public string Writer { get; set; }

        /// <summary>Movie actors split by ", "</summary>
        public string Actors { get; set; }

        /// <summary>Movie plot description</summary>
        public string Plot { get; set; }

        /// <summary>Language used in the movie</summary>
        public string Language { get; set; }

        /// <summary>Countries that produced the movie or the movie was shot in.</summary>
        public string Country { get; set; }

        /// <summary>Movie awards. Like oscars, nominations etc.</summary>
        public string Awards { get; set; }

        /// <summary>URL to a poster image</summary>
        public string Poster { get; set; }

        /// <summary>The Metascore.com score on an integer scale from 0 to 100.</summary>
        public string Metascore { get; set; }

        /// <summary>The Metascore.com score on an integer scale from 0 to 100.</summary>
        [JsonProperty("imdbRating")]
        public string ImdbRating { get; set; }

        /// <summary>The number of votes received on IMDB.com</summary>
        [JsonProperty("imdbVotes")]
        public string ImdbVotes { get; set; }

        /// <summary>The IMDB indentification in the format of tt1234567.</summary>
        [JsonProperty("imdbID")]
        public string ImdbId { get; set; }

        /// <summary>The type of the title (movie/episode/featurette/etc.).</summary>
        public string Type { get; set; }

        /// <summary>The RottenTomatoes TomatoMeter rating on the integer scale of 0 to 100.</summary>
        [JsonProperty("tomatoMeter")]
        public string TomatoMeter { get; set; }

        /// <summary>The tomato image to display.</summary>
        [JsonProperty("tomatoImage")]
        public string TomatoImage { get; set; }

        /// <summary>The RottenTomatoes rating on the decimal scale of 0 to 10.0.</summary>
        [JsonProperty("tomatoRating")]
        public string TomatoRating { get; set; }

        /// <summary>The RottenTomatoes reviews score.</summary>
        [JsonProperty("tomatoReviews")]
        public string TomatoReviews { get; set; }

        /// <summary>The RottenTomatoes fresh/rotten line value part (min 0 max 100).</summary>
        [JsonProperty("tomatoFresh")]
        public string TomatoFresh { get; set; }

        /// <summary>The RottenTomatoes fresh/rotten line value part (min 0 max 100).</summary>
        [JsonProperty("tomatoRotten")]
        public string TomatoRotten { get; set; }

        /// <summary>The RottenTomatoes consensus.</summary>
        [JsonProperty("tomatoConsensus")]
        public string TomatoConsensus { get; set; }

        /// <summary>The RottenTomatoes user rating on the integer scale from 0 to 100.</summary>
        [JsonProperty("tomatoUserMeter")]
        public string TomatoUserMeter { get; set; }

        /// <summary>The RottenTomatoes user rating on the decimal scale from 0 to 5.0.</summary>
        [JsonProperty("tomatoUserRating")]
        public string TomatoUserRating { get; set; }

        /// <summary>The RottenTomatoes number of user reviews.</summary>
        [JsonProperty("tomatoUserReviews")]
        public string TomatoUserReviews { get; set; }

        /// <summary>The DVD release date.</summary>
        public string DVD { get; set; }

        /// <summary>The Box office earning.</summary>
        public string BoxOffice { get; set; }

        /// <summary>The movie production studio.</summary>
        public string Production { get; set; }

        /// <summary>The movie official website.</summary>
        public string Website { get; set; }

        /// <summary>Boolean value of "True" or "False" if the query succeded</summary>
        public string Response { get; set; }
    }

}
