using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailCopyRecord
/// </summary>

public partial class VoicemailCopyRecord : IEquatable<VoicemailCopyRecord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailCopyRecord" /> class.
    /// </summary>
    public VoicemailCopyRecord()
    {

    }



    /// <summary>
    /// The user that the voicemail message was copied to/from
    /// </summary>
    /// <value>The user that the voicemail message was copied to/from</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// The group that the voicemail message was copied to/from
    /// </summary>
    /// <value>The group that the voicemail message was copied to/from</value>
    [JsonPropertyName("group")]
    public Group Group { get; set; }



    /// <summary>
    /// The date when the voicemail was copied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the voicemail was copied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailCopyRecord {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
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
        return Equals(obj as VoicemailCopyRecord);
    }

    /// <summary>
    /// Returns true if VoicemailCopyRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailCopyRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailCopyRecord other)
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
            ) &&
            (
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
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

            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            return hash;
        }
    }
}
