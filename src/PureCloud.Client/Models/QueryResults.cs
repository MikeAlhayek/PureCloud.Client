using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryResults
/// </summary>

public partial class QueryResults : IEquatable<QueryResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryResults" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    /// <param name="FacetInfo">FacetInfo.</param>
    public QueryResults(DomainEntityListingQueryResult Results = null, QueryFacetInfo FacetInfo = null)
    {
        this.Results = Results;
        this.FacetInfo = FacetInfo;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [JsonPropertyName("results")]
    public DomainEntityListingQueryResult Results { get; set; }



    /// <summary>
    /// Gets or Sets FacetInfo
    /// </summary>
    [JsonPropertyName("facetInfo")]
    public QueryFacetInfo FacetInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryResults {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  FacetInfo: ").Append(FacetInfo).Append("\n");
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
        return Equals(obj as QueryResults);
    }

    /// <summary>
    /// Returns true if QueryResults instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.Equals(other.Results)
            ) &&
            (
                FacetInfo == other.FacetInfo ||
                FacetInfo != null &&
                FacetInfo.Equals(other.FacetInfo)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (FacetInfo != null)
            {
                hash = hash * 59 + FacetInfo.GetHashCode();
            }

            return hash;
        }
    }
}
