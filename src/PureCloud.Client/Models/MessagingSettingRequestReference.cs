using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Messaging Setting for messaging platform integrations
/// </summary>

public partial class MessagingSettingRequestReference : IEquatable<MessagingSettingRequestReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingRequestReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingSettingRequestReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingRequestReference" /> class.
    /// </summary>
    /// <param name="Id">The messaging Setting unique identifier associated with this integration (required).</param>
    public MessagingSettingRequestReference(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The messaging Setting unique identifier associated with this integration
    /// </summary>
    /// <value>The messaging Setting unique identifier associated with this integration</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingSettingRequestReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as MessagingSettingRequestReference);
    }

    /// <summary>
    /// Returns true if MessagingSettingRequestReference instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingSettingRequestReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingSettingRequestReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
