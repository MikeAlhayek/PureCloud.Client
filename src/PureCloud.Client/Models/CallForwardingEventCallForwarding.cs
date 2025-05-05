using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallForwardingEventCallForwarding
/// </summary>

public partial class CallForwardingEventCallForwarding : IEquatable<CallForwardingEventCallForwarding>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallForwardingEventCallForwarding" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="Calls">Calls.</param>
    /// <param name="Voicemail">Voicemail.</param>
    /// <param name="ModifiedDate">ModifiedDate.</param>
    public CallForwardingEventCallForwarding(CallForwardingEventUser User = null, bool? Enabled = null, List<CallForwardingEventCall> Calls = null, string Voicemail = null, DateTime? ModifiedDate = null)
    {
        this.User = User;
        this.Enabled = Enabled;
        this.Calls = Calls;
        this.Voicemail = Voicemail;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public CallForwardingEventUser User { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    [JsonPropertyName("calls")]
    public List<CallForwardingEventCall> Calls { get; set; }



    /// <summary>
    /// Gets or Sets Voicemail
    /// </summary>
    [JsonPropertyName("voicemail")]
    public string Voicemail { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallForwardingEventCallForwarding {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as CallForwardingEventCallForwarding);
    }

    /// <summary>
    /// Returns true if CallForwardingEventCallForwarding instances are equal
    /// </summary>
    /// <param name="other">Instance of CallForwardingEventCallForwarding to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallForwardingEventCallForwarding other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Calls == other.Calls ||
                Calls != null &&
                Calls.SequenceEqual(other.Calls)
            ) &&
            (
                Voicemail == other.Voicemail ||
                Voicemail != null &&
                Voicemail.Equals(other.Voicemail)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Calls != null)
            {
                hash = hash * 59 + Calls.GetHashCode();
            }

            if (Voicemail != null)
            {
                hash = hash * 59 + Voicemail.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
