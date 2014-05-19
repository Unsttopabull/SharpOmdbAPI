namespace Frost.SharpOmdbAPI.Models {

    /// <summary>Represents the OMDB API search results</summary>
    public class OmdbSearchInfo {

        /// <summary>Gets or sets the search matches.</summary>
        /// <value>The search matches</value>
        public OmdbSearch[] Search { get; set; }
    }
}
