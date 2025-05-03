using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the recipient the message is sent to or received from.
/// </summary>

public partial class WebMessagingRecipient : IEquatable<WebMessagingRecipient>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebMessagingRecipient" /> class.
    /// </summary>
    public WebMessagingRecipient()
    {

    }



    /// <summary>
    /// First name of the recipient.
    /// </summary>
    /// <value>First name of the recipient.</value>
    [JsonPropertyName("firstName")]
    public string FirstName { get; private set; }



    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    /// <value>Last name of the recipient.</value>
    [JsonPropertyName("lastName")]
    public string LastName { get; private set; }



    /// <summary>
    /// Nickname or display name of the recipient.
    /// </summary>
    /// <value>Nickname or display name of the recipient.</value>
    [JsonPropertyName("nickname")]
    public string Nickname { get; private set; }



    /// <summary>
    /// URL of an image that represents the recipient.
    /// </summary>
    /// <value>URL of an image that represents the recipient.</value>
    [JsonPropertyName("image")]
    public string Image { get; private set; }



    /// <summary>
    /// List of recipient additional identifiers
    /// </summary>
    /// <value>List of recipient additional identifiers</value>
    [JsonPropertyName("additionalIds")]
    public List<RecipientAdditionalIdentifier> AdditionalIds { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebMessagingRecipient {\n");

        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  AdditionalIds: ").Append(AdditionalIds).Append("\n");
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
        return Equals(obj as WebMessagingRecipient);
    }

    /// <summary>
    /// Returns true if WebMessagingRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of WebMessagingRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebMessagingRecipient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FirstName == other.FirstName ||
                FirstName != null &&
                FirstName.Equals(other.FirstName)
            ) &&
            (
                LastName == other.LastName ||
                LastName != null &&
                LastName.Equals(other.LastName)
            ) &&
            (
                Nickname == other.Nickname ||
                Nickname != null &&
                Nickname.Equals(other.Nickname)
            ) &&
            (
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                AdditionalIds == other.AdditionalIds ||
                AdditionalIds != null &&
                AdditionalIds.SequenceEqual(other.AdditionalIds)
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
            if (FirstName != null)
            {
                hash = hash * 59 + FirstName.GetHashCode();
            }

            if (LastName != null)
            {
                hash = hash * 59 + LastName.GetHashCode();
            }

            if (Nickname != null)
            {
                hash = hash * 59 + Nickname.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (AdditionalIds != null)
            {
                hash = hash * 59 + AdditionalIds.GetHashCode();
            }

            return hash;
        }
    }
}
