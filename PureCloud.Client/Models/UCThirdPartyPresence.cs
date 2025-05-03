using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Update a Genesys Cloud user&#39;s presence from a given 3rd-party integration
/// </summary>

public partial class UCThirdPartyPresence : IEquatable<UCThirdPartyPresence>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UCThirdPartyPresence" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UCThirdPartyPresence() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UCThirdPartyPresence" /> class.
    /// </summary>
    /// <param name="Email">Primary Email address of the associated Genesys Cloud user. (required).</param>
    /// <param name="Presence">Integration presence value. (required).</param>
    /// <param name="Message">Integration presence message..</param>
    /// <param name="DateModified">ISO 8601 timestamp of presence value change..</param>
    public UCThirdPartyPresence(string Email = null, string Presence = null, string Message = null, DateTime? DateModified = null)
    {
        this.Email = Email;
        this.Presence = Presence;
        this.Message = Message;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// Primary Email address of the associated Genesys Cloud user.
    /// </summary>
    /// <value>Primary Email address of the associated Genesys Cloud user.</value>
    [JsonPropertyName("email")]
    public string Email { get; set; }



    /// <summary>
    /// Integration presence value.
    /// </summary>
    /// <value>Integration presence value.</value>
    [JsonPropertyName("presence")]
    public string Presence { get; set; }



    /// <summary>
    /// Integration presence message.
    /// </summary>
    /// <value>Integration presence message.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// ISO 8601 timestamp of presence value change.
    /// </summary>
    /// <value>ISO 8601 timestamp of presence value change.</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UCThirdPartyPresence {\n");

        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Presence: ").Append(Presence).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as UCThirdPartyPresence);
    }

    /// <summary>
    /// Returns true if UCThirdPartyPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of UCThirdPartyPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UCThirdPartyPresence other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                Presence == other.Presence ||
                Presence != null &&
                Presence.Equals(other.Presence)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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
            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (Presence != null)
            {
                hash = hash * 59 + Presence.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            return hash;
        }
    }
}
