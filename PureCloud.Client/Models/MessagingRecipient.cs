using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the recipient the message is sent to or received from.
/// </summary>

public partial class MessagingRecipient : IEquatable<MessagingRecipient>
{
    /// <summary>
    /// The recipient ID type. This is used to indicate the format used for the ID.
    /// </summary>
    /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
    
    public enum IdTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Phone for "Phone"
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Enum Opaque for "Opaque"
        /// </summary>
        [EnumMember(Value = "Opaque")]
        Opaque,

        /// <summary>
        /// Enum Topic for "Topic"
        /// </summary>
        [EnumMember(Value = "Topic")]
        Topic
    }
    /// <summary>
    /// The recipient ID type. This is used to indicate the format used for the ID.
    /// </summary>
    /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
    [JsonPropertyName("idType")]
    public IdTypeEnum? IdType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingRecipient" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingRecipient() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingRecipient" /> class.
    /// </summary>
    /// <param name="Id">The recipient ID specific to the provider. (required).</param>
    /// <param name="IdType">The recipient ID type. This is used to indicate the format used for the ID..</param>
    /// <param name="ExternalContactId">The identifier of the external contact..</param>
    /// <param name="AdditionalIds">List of recipient additional identifiers.</param>
    public MessagingRecipient(string Id = null, IdTypeEnum? IdType = null, string ExternalContactId = null, List<RecipientAdditionalIdentifier> AdditionalIds = null)
    {
        this.Id = Id;
        this.IdType = IdType;
        this.ExternalContactId = ExternalContactId;
        this.AdditionalIds = AdditionalIds;

    }



    /// <summary>
    /// Nickname or display name of the recipient.
    /// </summary>
    /// <value>Nickname or display name of the recipient.</value>
    [JsonPropertyName("nickname")]
    public string Nickname { get; private set; }



    /// <summary>
    /// The recipient ID specific to the provider.
    /// </summary>
    /// <value>The recipient ID specific to the provider.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// URL of an image that represents the recipient.
    /// </summary>
    /// <value>URL of an image that represents the recipient.</value>
    [JsonPropertyName("image")]
    public string Image { get; private set; }



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
    /// E-mail address of the recipient.
    /// </summary>
    /// <value>E-mail address of the recipient.</value>
    [JsonPropertyName("email")]
    public string Email { get; private set; }



    /// <summary>
    /// The identifier of the external contact.
    /// </summary>
    /// <value>The identifier of the external contact.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// List of recipient additional identifiers
    /// </summary>
    /// <value>List of recipient additional identifiers</value>
    [JsonPropertyName("additionalIds")]
    public List<RecipientAdditionalIdentifier> AdditionalIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingRecipient {\n");

        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IdType: ").Append(IdType).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
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
        return Equals(obj as MessagingRecipient);
    }

    /// <summary>
    /// Returns true if MessagingRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingRecipient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Nickname == other.Nickname ||
                Nickname != null &&
                Nickname.Equals(other.Nickname)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                IdType == other.IdType ||
                IdType != null &&
                IdType.Equals(other.IdType)
            ) &&
            (
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
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
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
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
            if (Nickname != null)
            {
                hash = hash * 59 + Nickname.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (IdType != null)
            {
                hash = hash * 59 + IdType.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
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

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (AdditionalIds != null)
            {
                hash = hash * 59 + AdditionalIds.GetHashCode();
            }

            return hash;
        }
    }
}
