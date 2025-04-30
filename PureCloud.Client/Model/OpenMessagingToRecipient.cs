using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Information about the recipient the message is sent to.
/// </summary>
[DataContract]
public partial class OpenMessagingToRecipient : IEquatable<OpenMessagingToRecipient>
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
    public IdTypeEnum? IdType { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingToRecipient" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenMessagingToRecipient() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingToRecipient" /> class.
    /// </summary>
    /// <param name="Id">The recipient ID specific to the provider. (required).</param>
    /// <param name="Email">E-mail address of the recipient..</param>
    public OpenMessagingToRecipient(string Id = null, string Email = null)
    {
        this.Id = Id;
        this.Email = Email;

    }



    /// <summary>
    /// Nickname or display name of the recipient.
    /// </summary>
    /// <value>Nickname or display name of the recipient.</value>
    [DataMember(Name = "nickname", EmitDefaultValue = false)]
    public string Nickname { get; private set; }



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
    public string FirstName { get; private set; }



    /// <summary>
    /// Last name of the recipient.
    /// </summary>
    /// <value>Last name of the recipient.</value>
    [DataMember(Name = "lastName", EmitDefaultValue = false)]
    public string LastName { get; private set; }



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
        sb.Append("class OpenMessagingToRecipient {\n");

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
        return this.Equals(obj as OpenMessagingToRecipient);
    }

    /// <summary>
    /// Returns true if OpenMessagingToRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenMessagingToRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenMessagingToRecipient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Nickname == other.Nickname ||
                this.Nickname != null &&
                this.Nickname.Equals(other.Nickname)
            ) &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.IdType == other.IdType ||
                this.IdType != null &&
                this.IdType.Equals(other.IdType)
            ) &&
            (
                this.FirstName == other.FirstName ||
                this.FirstName != null &&
                this.FirstName.Equals(other.FirstName)
            ) &&
            (
                this.LastName == other.LastName ||
                this.LastName != null &&
                this.LastName.Equals(other.LastName)
            ) &&
            (
                this.Image == other.Image ||
                this.Image != null &&
                this.Image.Equals(other.Image)
            ) &&
            (
                this.Email == other.Email ||
                this.Email != null &&
                this.Email.Equals(other.Email)
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
            if (this.Nickname != null)
            {
                hash = hash * 59 + this.Nickname.GetHashCode();
            }

            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.IdType != null)
            {
                hash = hash * 59 + this.IdType.GetHashCode();
            }

            if (this.FirstName != null)
            {
                hash = hash * 59 + this.FirstName.GetHashCode();
            }

            if (this.LastName != null)
            {
                hash = hash * 59 + this.LastName.GetHashCode();
            }

            if (this.Image != null)
            {
                hash = hash * 59 + this.Image.GetHashCode();
            }

            if (this.Email != null)
            {
                hash = hash * 59 + this.Email.GetHashCode();
            }

            return hash;
        }
    }
}
