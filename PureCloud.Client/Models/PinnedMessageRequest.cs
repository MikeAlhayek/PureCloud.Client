using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PinnedMessageRequest
/// </summary>
[DataContract]
public partial class PinnedMessageRequest : IEquatable<PinnedMessageRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PinnedMessageRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PinnedMessageRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PinnedMessageRequest" /> class.
    /// </summary>
    /// <param name="PinnedMessageIds">Ids of the messages to pin (required).</param>
    public PinnedMessageRequest(List<string> PinnedMessageIds = null)
    {
        this.PinnedMessageIds = PinnedMessageIds;

    }



    /// <summary>
    /// Ids of the messages to pin
    /// </summary>
    /// <value>Ids of the messages to pin</value>
    [DataMember(Name = "pinnedMessageIds", EmitDefaultValue = false)]
    public List<string> PinnedMessageIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PinnedMessageRequest {\n");

        sb.Append("  PinnedMessageIds: ").Append(PinnedMessageIds).Append("\n");
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
        return this.Equals(obj as PinnedMessageRequest);
    }

    /// <summary>
    /// Returns true if PinnedMessageRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PinnedMessageRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PinnedMessageRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.PinnedMessageIds == other.PinnedMessageIds ||
                this.PinnedMessageIds != null &&
                this.PinnedMessageIds.SequenceEqual(other.PinnedMessageIds)
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
            if (this.PinnedMessageIds != null)
            {
                hash = hash * 59 + this.PinnedMessageIds.GetHashCode();
            }

            return hash;
        }
    }
}
