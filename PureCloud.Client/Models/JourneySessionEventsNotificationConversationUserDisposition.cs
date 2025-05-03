using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationConversationUserDisposition
/// </summary>

public partial class JourneySessionEventsNotificationConversationUserDisposition : IEquatable<JourneySessionEventsNotificationConversationUserDisposition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationConversationUserDisposition" /> class.
    /// </summary>
    /// <param name="Code">Code.</param>
    /// <param name="Notes">Notes.</param>
    /// <param name="User">User.</param>
    public JourneySessionEventsNotificationConversationUserDisposition(string Code = null, string Notes = null, JourneySessionEventsNotificationUser User = null)
    {
        this.Code = Code;
        this.Notes = Notes;
        this.User = User;

    }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public JourneySessionEventsNotificationUser User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationConversationUserDisposition {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as JourneySessionEventsNotificationConversationUserDisposition);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationConversationUserDisposition instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationConversationUserDisposition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationConversationUserDisposition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
