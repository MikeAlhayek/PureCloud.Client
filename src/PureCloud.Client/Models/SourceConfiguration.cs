using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SourceConfiguration
/// </summary>

public partial class SourceConfiguration : IEquatable<SourceConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SourceConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SourceConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceConfiguration" /> class.
    /// </summary>
    /// <param name="SourceId">Identifies the external platform that is the source of the conversation. (required).</param>
    /// <param name="InteractionId">The customer&#39;s unique external identifier associated with the conversation that comes from the external platform. (required).</param>
    /// <param name="TagId">The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation..</param>
    public SourceConfiguration(string SourceId = null, string InteractionId = null, string TagId = null)
    {
        this.SourceId = SourceId;
        this.InteractionId = InteractionId;
        this.TagId = TagId;

    }



    /// <summary>
    /// Identifies the external platform that is the source of the conversation.
    /// </summary>
    /// <value>Identifies the external platform that is the source of the conversation.</value>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }



    /// <summary>
    /// The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.
    /// </summary>
    /// <value>The customer&#39;s unique external identifier associated with the conversation that comes from the external platform.</value>
    [JsonPropertyName("interactionId")]
    public string InteractionId { get; set; }



    /// <summary>
    /// The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.
    /// </summary>
    /// <value>The customer&#39;s external identifier or tag associated with the conversation. If set, it will be used to tag the conversation.</value>
    [JsonPropertyName("tagId")]
    public string TagId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SourceConfiguration {\n");

        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
        sb.Append("  TagId: ").Append(TagId).Append("\n");
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
        return Equals(obj as SourceConfiguration);
    }

    /// <summary>
    /// Returns true if SourceConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of SourceConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SourceConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
            ) &&
            (
                InteractionId == other.InteractionId ||
                InteractionId != null &&
                InteractionId.Equals(other.InteractionId)
            ) &&
            (
                TagId == other.TagId ||
                TagId != null &&
                TagId.Equals(other.TagId)
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
            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (InteractionId != null)
            {
                hash = hash * 59 + InteractionId.GetHashCode();
            }

            if (TagId != null)
            {
                hash = hash * 59 + TagId.GetHashCode();
            }

            return hash;
        }
    }
}
