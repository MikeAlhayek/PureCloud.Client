using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterDataIngestionRuleRequest
/// </summary>

public partial class TwitterDataIngestionRuleRequest : IEquatable<TwitterDataIngestionRuleRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterDataIngestionRuleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TwitterDataIngestionRuleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterDataIngestionRuleRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the data ingestion rule. (required).</param>
    /// <param name="Description">A description of the data ingestion rule..</param>
    /// <param name="SearchTerms">Search terms for X (formally Twitter). (required).</param>
    /// <param name="Countries">ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide..</param>
    public TwitterDataIngestionRuleRequest(string Name = null, string Description = null, string SearchTerms = null, List<string> Countries = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.SearchTerms = SearchTerms;
        this.Countries = Countries;

    }



    /// <summary>
    /// The name of the data ingestion rule.
    /// </summary>
    /// <value>The name of the data ingestion rule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the data ingestion rule.
    /// </summary>
    /// <value>A description of the data ingestion rule.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Search terms for X (formally Twitter).
    /// </summary>
    /// <value>Search terms for X (formally Twitter).</value>
    [JsonPropertyName("searchTerms")]
    public string SearchTerms { get; set; }



    /// <summary>
    /// ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide.
    /// </summary>
    /// <value>ISO 3166-1 alpha-2 country codes. Ingestion of matching tweets will be restricted to tweets posted in the countries specified here. Defaults to worldwide.</value>
    [JsonPropertyName("countries")]
    public List<string> Countries { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TwitterDataIngestionRuleRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
        sb.Append("  Countries: ").Append(Countries).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as TwitterDataIngestionRuleRequest);
    }

    /// <summary>
    /// Returns true if TwitterDataIngestionRuleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterDataIngestionRuleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterDataIngestionRuleRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                SearchTerms == other.SearchTerms ||
                SearchTerms != null &&
                SearchTerms.Equals(other.SearchTerms)
            ) &&
            (
                Countries == other.Countries ||
                Countries != null &&
                Countries.SequenceEqual(other.Countries)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SearchTerms != null)
            {
                hash = hash * 59 + SearchTerms.GetHashCode();
            }

            if (Countries != null)
            {
                hash = hash * 59 + Countries.GetHashCode();
            }

            return hash;
        }
    }
}
