using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailMessagesTopicVoicemailCopyRecord
/// </summary>

public partial class VoicemailMessagesTopicVoicemailCopyRecord : IEquatable<VoicemailMessagesTopicVoicemailCopyRecord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailMessagesTopicVoicemailCopyRecord" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="Group">Group.</param>
    public VoicemailMessagesTopicVoicemailCopyRecord(VoicemailMessagesTopicOwner User = null, VoicemailMessagesTopicOwner Group = null)
    {
        this.User = User;
        this.Group = Group;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public VoicemailMessagesTopicOwner User { get; set; }



    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [JsonPropertyName("group")]
    public VoicemailMessagesTopicOwner Group { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailMessagesTopicVoicemailCopyRecord {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
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
        return Equals(obj as VoicemailMessagesTopicVoicemailCopyRecord);
    }

    /// <summary>
    /// Returns true if VoicemailMessagesTopicVoicemailCopyRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailMessagesTopicVoicemailCopyRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailMessagesTopicVoicemailCopyRecord other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            return hash;
        }
    }
}
