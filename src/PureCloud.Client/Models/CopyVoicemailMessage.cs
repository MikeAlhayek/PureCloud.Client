using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Used to copy a VoicemailMessage to either a User or a Group
/// </summary>

public partial class CopyVoicemailMessage : IEquatable<CopyVoicemailMessage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyVoicemailMessage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopyVoicemailMessage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyVoicemailMessage" /> class.
    /// </summary>
    /// <param name="VoicemailMessageId">The id of the VoicemailMessage to copy (required).</param>
    /// <param name="UserId">The id of the User to copy the VoicemailMessage to.</param>
    /// <param name="GroupId">The id of the Group to copy the VoicemailMessage to.</param>
    public CopyVoicemailMessage(string VoicemailMessageId = null, string UserId = null, string GroupId = null)
    {
        this.VoicemailMessageId = VoicemailMessageId;
        this.UserId = UserId;
        this.GroupId = GroupId;

    }



    /// <summary>
    /// The id of the VoicemailMessage to copy
    /// </summary>
    /// <value>The id of the VoicemailMessage to copy</value>
    [JsonPropertyName("voicemailMessageId")]
    public string VoicemailMessageId { get; set; }



    /// <summary>
    /// The id of the User to copy the VoicemailMessage to
    /// </summary>
    /// <value>The id of the User to copy the VoicemailMessage to</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The id of the Group to copy the VoicemailMessage to
    /// </summary>
    /// <value>The id of the Group to copy the VoicemailMessage to</value>
    [JsonPropertyName("groupId")]
    public string GroupId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopyVoicemailMessage {\n");

        sb.Append("  VoicemailMessageId: ").Append(VoicemailMessageId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
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
        return Equals(obj as CopyVoicemailMessage);
    }

    /// <summary>
    /// Returns true if CopyVoicemailMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of CopyVoicemailMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopyVoicemailMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VoicemailMessageId == other.VoicemailMessageId ||
                VoicemailMessageId != null &&
                VoicemailMessageId.Equals(other.VoicemailMessageId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                GroupId == other.GroupId ||
                GroupId != null &&
                GroupId.Equals(other.GroupId)
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
            if (VoicemailMessageId != null)
            {
                hash = hash * 59 + VoicemailMessageId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (GroupId != null)
            {
                hash = hash * 59 + GroupId.GetHashCode();
            }

            return hash;
        }
    }
}
