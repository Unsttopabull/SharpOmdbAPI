using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Frost.SharpOmdbAPI.Models;
using Newtonsoft.Json;

namespace Frost.SharpOmdbAPI {

    /// <summary>The lengt of plot to return</summary>
    public enum PlotLength {
        /// <summary>Short summary</summary>
        Short,
        /// <summary>Full description</summary>
        Full
    }

    /// <summary>A client for communication with the OmdbAPI service.</summary>
    public static class SharpOmdb {
        private const string SEARCH_URI = "http://www.omdbapi.com/?s={0}{1}";
        private const string GET_IMDB_URI = "http://www.omdbapi.com/?i={0}&plot={1}&tomatoes={2}";
        private const string GET_TITLE_URI = "http://www.omdbapi.com/?t={0}{1}&plot={2}&tomatoes={3}";

        /// <summary>Gets the by Imdb movie info by Imdb Id.</summary>
        /// <param name="id">The ImdbId identifier.</param>
        /// <param name="plotLength">Length of the plot.</param>
        /// <param name="includeTomatoesInfo">if set to <c>true</c> includes RottenTomatoes information.</param>
        /// <returns>Returns an instance of OmdbMovie if successful, otherwise null.</returns>
        /// <exception cref="WebException">Throws when there was an error accessing the web API service.</exception>
        public static OmdbMovie GetByImdbId(string id, PlotLength plotLength = PlotLength.Short, bool includeTomatoesInfo = false) {
            return !string.IsNullOrEmpty(id) 
                ? Download<OmdbMovie>(string.Format(GET_IMDB_URI, id.ToString(CultureInfo.InvariantCulture), plotLength, includeTomatoesInfo)) 
                : null;
        }

        /// <summary>Gets the by Imdb movie info by movie title.</summary>
        /// <param name="title">The movie title to search for.</param>
        /// <param name="plotLength">Length of the plot.</param>
        /// <param name="includeTomatoesInfo">if set to <c>true</c> includes RottenTomatoes information.</param>
        /// <returns>Returns an instance of OmdbMovie if successful, otherwise <c>null</c>.</returns>
        /// <exception cref="WebException">Throws when there was an error accessing the web API service.</exception>
        public static OmdbMovie GetByTitle(string title, PlotLength plotLength = PlotLength.Short, bool includeTomatoesInfo = false) {
            return !string.IsNullOrEmpty(title) 
                ? Download<OmdbMovie>(string.Format(GET_TITLE_URI, WebUtility.UrlEncode(title), null, plotLength, includeTomatoesInfo)) 
                : null;
        }

        /// <summary>Gets the by Imdb movie info by movie title.</summary>
        /// <param name="title">The movie title to search for.</param>
        /// <param name="releaseYear">The year the movie was released in.</param>
        /// <param name="plotLength">Length of the plot.</param>
        /// <param name="includeTomatoesInfo">if set to <c>true</c> includes RottenTomatoes information.</param>
        /// <returns>Returns an instance of OmdbMovie if successful, otherwise <c>null</c>.</returns>
        /// <exception cref="WebException">Throws when there was an error accessing the web API service.</exception>
        public static OmdbMovie GetByTitle(string title, int releaseYear, PlotLength plotLength = PlotLength.Short, bool includeTomatoesInfo = false) {
            return !string.IsNullOrEmpty(title) 
                ? Download<OmdbMovie>(string.Format(GET_TITLE_URI, WebUtility.UrlEncode(title), "&y=" + releaseYear.ToString(CultureInfo.InvariantCulture), plotLength, includeTomatoesInfo))
                : null;
        }

        /// <summary>Searches for movies matching the title and year.</summary>
        /// <param name="title">The movie title to search for.</param>
        /// <param name="releaseYear">The year the movie was released in.</param>
        /// <returns>Returns an <see cref="IEnumerable{OmdbSearch}"/> if succesful, otherwise <c>null</c>.</returns>
        /// <exception cref="WebException">Throws when there was an error accessing the web API service.</exception>
        public static IEnumerable<OmdbSearch> Search(string title, int releaseYear = 0) {
            return !string.IsNullOrEmpty(title)
                ? Download<OmdbSearchInfo>(string.Format(SEARCH_URI, WebUtility.UrlEncode(title), releaseYear > 0 ? "&y=" + releaseYear.ToString(CultureInfo.InvariantCulture) : null)).Search
                : null;
        }

        private static T Download<T>(string uri) {
            using (WebClient cli = new WebClient()) {
                string json = cli.DownloadString(uri);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }

}