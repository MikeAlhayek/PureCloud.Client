using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient
/// </summary>
[DataContract]
public partial class V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient : IEquatable<V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient>
{
    /// <summary>
    /// Gets or Sets IdType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        Opaque
    }
    /// <summary>
    /// Gets or Sets IdType
    /// </summary>
    [DataMember(Name = "idType", EmitDefaultValue = false)]
    public IdTypeEnum? IdType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient" /> class.
    /// </summary>
    /// <param name="Nickname">Nickname.</param>
    /// <param name="Id">Id.</param>
    /// <param name="IdType">IdType.</param>
    /// <param name="Image">Image.</param>
    /// <param name="FirstName">FirstName.</param>
    /// <param name="LastName">LastName.</param>
    /// <param name="Email">Email.</param>
    /// <param name="AdditionalIds">AdditionalIds.</param>
    public V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient(string Nickname = null, string Id = null, IdTypeEnum? IdType = null, string Image = null, string FirstName = null, string LastName = null, string Email = null, List<V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifier> AdditionalIds = null)
    {
        this.Nickname = Nickname;
        this.Id = Id;
        this.IdType = IdType;
        this.Image = Image;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.AdditionalIds = AdditionalIds;

    }



    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    [DataMember(Name = "nickname", EmitDefaultValue = false)]
    public string Nickname { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }



    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name = "firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }



    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name = "lastName", EmitDefaultValue = false)]
    public string LastName { get; set; }



    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalIds
    /// </summary>
    [DataMember(Name = "additionalIds", EmitDefaultValue = false)]
    public List<V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifier> AdditionalIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient {\n");

        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IdType: ").Append(IdType).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
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
        return Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient);
    }

    /// <summary>
    /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient other)
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

            if (AdditionalIds != null)
            {
                hash = hash * 59 + AdditionalIds.GetHashCode();
            }

            return hash;
        }
    }
}
