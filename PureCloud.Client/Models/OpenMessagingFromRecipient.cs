using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the recipient the message is received from.
/// </summary>
[DataContract]
public partial class OpenMessagingFromRecipient : IEquatable<OpenMessagingFromRecipient>
{
    /// <summary>
    /// The recipient ID type. This is used to indicate the format used for the ID.
    /// </summary>
    /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
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
    /// The recipient ID type. This is used to indicate the format used for the ID.
    /// </summary>
    /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
    [DataMember(Name = "idType", EmitDefaultValue = false)]
    public IdTypeEnum? IdType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingFromRecipient" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenMessagingFromRecipient() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingFromRecipient" /> class.
    /// </summary>
    /// <param name="Nickname">Nickname or display name of the recipient..</param>
    /// <param name="Id">The recipient ID specific to the provider. (required).</param>
    /// <param name="IdType">The recipient ID type. This is used to indicate the format used for the ID. (required).</param>
    /// <param name="FirstName">First name of the recipient..</param>
    /// <param name="LastName">Last name of the recipient..</param>
    /// <param name="Email">E-mail address of the recipient..</param>
    public OpenMessagingFromRecipient(string Nickname = null, string Id = null, IdTypeEnum? IdType = null, string FirstName = null, string LastName = null, string Email = null)
    {
        this.Nickname = Nickname;
        this.Id = Id;
        this.IdType = IdType;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;

    }



    /// <summary>
    /// Nickname or display name of the recipient.
    /// </summary>
    /// <value>Nickname or display name of the recipient.</value>
    [DataMember(Name = "nickname", EmitDefaultValue = false)]
    public string Nickname { get; set; }



    /// <summary>
    /// The recipient ID specific to the provider.
    /// </summary>
    /// <value>The recipient ID specific to the provider.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// First name of the recipient.
    /// </summary>
    /// <value>First name of the recipient.</value>
    [DataMember(Name = "firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }



    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    /// <value>Last name of the recipient.</value>
    [DataMember(Name = "lastName", EmitDefaultValue = false)]
    public string LastName { get; set; }



    /// <summary>
    /// URL of an image that represents the recipient.
    /// </summary>
    /// <value>URL of an image that represents the recipient.</value>
    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; private set; }



    /// <summary>
    /// E-mail address of the recipient.
    /// </summary>
    /// <value>E-mail address of the recipient.</value>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenMessagingFromRecipient {\n");

        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IdType: ").Append(IdType).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
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
        return Equals(obj as OpenMessagingFromRecipient);
    }

    /// <summary>
    /// Returns true if OpenMessagingFromRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenMessagingFromRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenMessagingFromRecipient other)
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
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
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

            if (FirstName != null)
            {
                hash = hash * 59 + FirstName.GetHashCode();
            }

            if (LastName != null)
            {
                hash = hash * 59 + LastName.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            return hash;
        }
    }
}
