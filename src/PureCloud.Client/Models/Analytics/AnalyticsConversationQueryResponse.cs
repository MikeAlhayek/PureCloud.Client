using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsConversationQueryResponse
/// </summary>

public partial class AnalyticsConversationQueryResponse : IEquatable<AnalyticsConversationQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsConversationQueryResponse" /> class.
    /// </summary>
    /// <param name="Conversations">Conversations.</param>
    /// <param name="Aggregations">Aggregations.</param>
    /// <param name="TotalHits">TotalHits.</param>
    public AnalyticsConversationQueryResponse(List<AnalyticsConversationWithoutAttributes> Conversations = null, List<AggregationResult> Aggregations = null, int? TotalHits = null)
    {
        this.Conversations = Conversations;
        this.Aggregations = Aggregations;
        this.TotalHits = TotalHits;

    }



    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    [JsonPropertyName("conversations")]
    public List<AnalyticsConversationWithoutAttributes> Conversations { get; set; }



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
        sb.Append("class AnalyticsConversationQueryResponse {\n");

        sb.Append("  Conversations: ").Append(Conversations).Append("\n");
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
        return Equals(obj as AnalyticsConversationQueryResponse);
    }

    /// <summary>
    /// Returns true if AnalyticsConversationQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsConversationQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsConversationQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversations == other.Conversations ||
                Conversations != null &&
                Conversations.SequenceEqual(other.Conversations)
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
            if (Conversations != null)
            {
                hash = hash * 59 + Conversations.GetHashCode();
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
