using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryTopicVirtualAgentsConversationWrapUpCode
/// </summary>
[DataContract]
public partial class ConversationSummaryTopicVirtualAgentsConversationWrapUpCode : IEquatable<ConversationSummaryTopicVirtualAgentsConversationWrapUpCode>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationWrapUpCode" /> class.
    /// </summary>
    /// <param name="WrapUpCodeId">WrapUpCodeId.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Score">Score.</param>
    public ConversationSummaryTopicVirtualAgentsConversationWrapUpCode(string WrapUpCodeId = null, string Name = null, string Description = null, double? Score = null)
    {
        this.WrapUpCodeId = WrapUpCodeId;
        this.Name = Name;
        this.Description = Description;
        this.Score = Score;

    }



    /// <summary>
    /// Gets or Sets WrapUpCodeId
    /// </summary>
    [DataMember(Name = "wrapUpCodeId", EmitDefaultValue = false)]
    public string WrapUpCodeId { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public double? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryTopicVirtualAgentsConversationWrapUpCode {\n");

        sb.Append("  WrapUpCodeId: ").Append(WrapUpCodeId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
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
        return Equals(obj as ConversationSummaryTopicVirtualAgentsConversationWrapUpCode);
    }

    /// <summary>
    /// Returns true if ConversationSummaryTopicVirtualAgentsConversationWrapUpCode instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationWrapUpCode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryTopicVirtualAgentsConversationWrapUpCode other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WrapUpCodeId == other.WrapUpCodeId ||
                WrapUpCodeId != null &&
                WrapUpCodeId.Equals(other.WrapUpCodeId)
            ) &&
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
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
            if (WrapUpCodeId != null)
            {
                hash = hash * 59 + WrapUpCodeId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
