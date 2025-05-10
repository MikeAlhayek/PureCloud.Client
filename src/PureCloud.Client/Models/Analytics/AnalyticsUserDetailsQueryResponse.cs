using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsUserDetailsQueryResponse
/// </summary>

public partial class AnalyticsUserDetailsQueryResponse : IEquatable<AnalyticsUserDetailsQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsUserDetailsQueryResponse" /> class.
    /// </summary>
    /// <param name="UserDetails">UserDetails.</param>
    /// <param name="Aggregations">Aggregations.</param>
    /// <param name="TotalHits">TotalHits.</param>
    public AnalyticsUserDetailsQueryResponse(List<AnalyticsUserDetail> UserDetails = null, List<AggregationResult> Aggregations = null, int? TotalHits = null)
    {
        this.UserDetails = UserDetails;
        this.Aggregations = Aggregations;
        this.TotalHits = TotalHits;

    }



    /// <summary>
    /// Gets or Sets UserDetails
    /// </summary>
    [JsonPropertyName("userDetails")]
    public List<AnalyticsUserDetail> UserDetails { get; set; }



    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    [JsonPropertyName("aggregations")]
    public List<AggregationResult> Aggregations { get; set; }



    /// <summary>
    /// Gets or Sets TotalHits
    /// </summary>
    [JsonPropertyName("totalHits")]
    public int? TotalHits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsUserDetailsQueryResponse {\n");

        sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
        sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
        sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
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
        return Equals(obj as AnalyticsUserDetailsQueryResponse);
    }

    /// <summary>
    /// Returns true if AnalyticsUserDetailsQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsUserDetailsQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsUserDetailsQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserDetails == other.UserDetails ||
                UserDetails != null &&
                UserDetails.SequenceEqual(other.UserDetails)
            ) &&
            (
                Aggregations == other.Aggregations ||
                Aggregations != null &&
                Aggregations.SequenceEqual(other.Aggregations)
            ) &&
            (
                TotalHits == other.TotalHits ||
                TotalHits != null &&
                TotalHits.Equals(other.TotalHits)
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
            if (UserDetails != null)
            {
                hash = hash * 59 + UserDetails.GetHashCode();
            }

            if (Aggregations != null)
            {
                hash = hash * 59 + Aggregations.GetHashCode();
            }

            if (TotalHits != null)
            {
                hash = hash * 59 + TotalHits.GetHashCode();
            }

            return hash;
        }
    }
}
