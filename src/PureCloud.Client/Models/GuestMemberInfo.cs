using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GuestMemberInfo
/// </summary>

public partial class GuestMemberInfo : IEquatable<GuestMemberInfo>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GuestMemberInfo" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GuestMemberInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GuestMemberInfo" /> class.
    /// </summary>
    /// <param name="DisplayName">The display name to use for the guest member in the conversation. (required).</param>
    /// <param name="FirstName">The first name to use for the guest member in the conversation..</param>
    /// <param name="LastName">The last name to use for the guest member in the conversation..</param>
    /// <param name="Email">The email address to use for the guest member in the conversation..</param>
    /// <param name="PhoneNumber">The phone number to use for the guest member in the conversation..</param>
    /// <param name="AvatarImageUrl">The URL to the avatar image to use for the guest member in the conversation, if any..</param>
    /// <param name="CustomFields">Any custom fields of information, in key-value format, to attach to the guest member in the conversation..</param>
    public GuestMemberInfo(string DisplayName = null, string FirstName = null, string LastName = null, string Email = null, string PhoneNumber = null, string AvatarImageUrl = null, Dictionary<string, string> CustomFields = null)
    {
        this.DisplayName = DisplayName;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.AvatarImageUrl = AvatarImageUrl;
        this.CustomFields = CustomFields;

    }



    /// <summary>
    /// The display name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The display name to use for the guest member in the conversation.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// The first name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The first name to use for the guest member in the conversation.</value>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }



    /// <summary>
    /// The last name to use for the guest member in the conversation.
    /// </summary>
    /// <value>The last name to use for the guest member in the conversation.</value>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }



    /// <summary>
    /// The email address to use for the guest member in the conversation.
    /// </summary>
    /// <value>The email address to use for the guest member in the conversation.</value>
    [JsonPropertyName("email")]
    public string Email { get; set; }



    /// <summary>
    /// The phone number to use for the guest member in the conversation.
    /// </summary>
    /// <value>The phone number to use for the guest member in the conversation.</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The URL to the avatar image to use for the guest member in the conversation, if any.
    /// </summary>
    /// <value>The URL to the avatar image to use for the guest member in the conversation, if any.</value>
    [JsonPropertyName("avatarImageUrl")]
    public string AvatarImageUrl { get; set; }



    /// <summary>
    /// Any custom fields of information, in key-value format, to attach to the guest member in the conversation.
    /// </summary>
    /// <value>Any custom fields of information, in key-value format, to attach to the guest member in the conversation.</value>
    [JsonPropertyName("customFields")]
    public Dictionary<string, string> CustomFields { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GuestMemberInfo {\n");

        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
        return Equals(obj as GuestMemberInfo);
    }

    /// <summary>
    /// Returns true if GuestMemberInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of GuestMemberInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GuestMemberInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
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
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                AvatarImageUrl == other.AvatarImageUrl ||
                AvatarImageUrl != null &&
                AvatarImageUrl.Equals(other.AvatarImageUrl)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
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
            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (FirstName != null)
            {
                hash = hash * 59 + FirstName.GetHashCode();
            }

            if (LastName != null)
            {
                hash = hash * 59 + LastName.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (AvatarImageUrl != null)
            {
                hash = hash * 59 + AvatarImageUrl.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            return hash;
        }
    }
}
