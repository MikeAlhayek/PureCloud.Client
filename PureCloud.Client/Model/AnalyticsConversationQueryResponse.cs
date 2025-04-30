using System.Runtime.Serialization;
using System.Text;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// AnalyticsConversationQueryResponse
/// </summary>
[DataContract]
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
    [DataMember(Name = "conversations", EmitDefaultValue = false)]
    public List<AnalyticsConversationWithoutAttributes> Conversations { get; set; }



    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    [DataMember(Name = "aggregations", EmitDefaultValue = false)]
    public List<AggregationResult> Aggregations { get; set; }



    /// <summary>
    /// Gets or Sets TotalHits
    /// </summary>
    [DataMember(Name = "totalHits", EmitDefaultValue = false)]
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
        return this.Equals(obj as AnalyticsConversationQueryResponse);
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
                this.Conversations == other.Conversations ||
                this.Conversations != null &&
                this.Conversations.SequenceEqual(other.Conversations)
            ) &&
            (
                this.Aggregations == other.Aggregations ||
                this.Aggregations != null &&
                this.Aggregations.SequenceEqual(other.Aggregations)
            ) &&
            (
                this.TotalHits == other.TotalHits ||
                this.TotalHits != null &&
                this.TotalHits.Equals(other.TotalHits)
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
            if (this.Conversations != null)
            {
                hash = hash * 59 + this.Conversations.GetHashCode();
            }

            if (this.Aggregations != null)
            {
                hash = hash * 59 + this.Aggregations.GetHashCode();
            }

            if (this.TotalHits != null)
            {
                hash = hash * 59 + this.TotalHits.GetHashCode();
            }

            return hash;
        }
    }
}
