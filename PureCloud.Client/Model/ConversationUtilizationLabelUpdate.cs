using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// ConversationUtilizationLabelUpdate
/// </summary>
[DataContract]
public partial class ConversationUtilizationLabelUpdate : IEquatable<ConversationUtilizationLabelUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationUtilizationLabelUpdate" /> class.
    /// </summary>
    /// <param name="UtilizationLabelId">The utilization label associated with the conversation..</param>
    public ConversationUtilizationLabelUpdate(string UtilizationLabelId = null)
    {
        this.UtilizationLabelId = UtilizationLabelId;

    }



    /// <summary>
    /// The utilization label associated with the conversation.
    /// </summary>
    /// <value>The utilization label associated with the conversation.</value>
    [DataMember(Name = "utilizationLabelId", EmitDefaultValue = false)]
    public string UtilizationLabelId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationUtilizationLabelUpdate {\n");

        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
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
        return this.Equals(obj as ConversationUtilizationLabelUpdate);
    }

    /// <summary>
    /// Returns true if ConversationUtilizationLabelUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationUtilizationLabelUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationUtilizationLabelUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.UtilizationLabelId == other.UtilizationLabelId ||
                this.UtilizationLabelId != null &&
                this.UtilizationLabelId.Equals(other.UtilizationLabelId)
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
            if (this.UtilizationLabelId != null)
            {
                hash = hash * 59 + this.UtilizationLabelId.GetHashCode();
            }

            return hash;
        }
    }
}
