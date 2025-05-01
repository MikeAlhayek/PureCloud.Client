using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactIdentifier
/// </summary>
[DataContract]
public partial class ContactIdentifier : IEquatable<ContactIdentifier>
{
    /// <summary>
    /// The type of this identifier
    /// </summary>
    /// <value>The type of this identifier</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Socialline for "SocialLine"
        /// </summary>
        [EnumMember(Value = "SocialLine")]
        Socialline,

        /// <summary>
        /// Enum Socialfacebook for "SocialFacebook"
        /// </summary>
        [EnumMember(Value = "SocialFacebook")]
        Socialfacebook,

        /// <summary>
        /// Enum Socialtwitter for "SocialTwitter"
        /// </summary>
        [EnumMember(Value = "SocialTwitter")]
        Socialtwitter,

        /// <summary>
        /// Enum Socialwhatsapp for "SocialWhatsapp"
        /// </summary>
        [EnumMember(Value = "SocialWhatsapp")]
        Socialwhatsapp,

        /// <summary>
        /// Enum Socialinstagram for "SocialInstagram"
        /// </summary>
        [EnumMember(Value = "SocialInstagram")]
        Socialinstagram,

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
        /// Enum Cookie for "Cookie"
        /// </summary>
        [EnumMember(Value = "Cookie")]
        Cookie,

        /// <summary>
        /// Enum Externalid for "ExternalId"
        /// </summary>
        [EnumMember(Value = "ExternalId")]
        Externalid
    }
    /// <summary>
    /// The type of this identifier
    /// </summary>
    /// <value>The type of this identifier</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactIdentifier" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactIdentifier() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactIdentifier" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Type">The type of this identifier (required).</param>
    /// <param name="Value">The string value of the identifier. Will vary in syntax by type. (required).</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExternalSource">The External Source ID of the identifier.</param>
    public ContactIdentifier(WritableStarrableDivision Division = null, TypeEnum? Type = null, string Value = null, DateTime? DateCreated = null, ExternalSource ExternalSource = null)
    {
        this.Division = Division;
        this.Type = Type;
        this.Value = Value;
        this.DateCreated = DateCreated;
        this.ExternalSource = ExternalSource;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public WritableStarrableDivision Division { get; set; }





    /// <summary>
    /// The string value of the identifier. Will vary in syntax by type.
    /// </summary>
    /// <value>The string value of the identifier. Will vary in syntax by type.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The External Source ID of the identifier
    /// </summary>
    /// <value>The External Source ID of the identifier</value>
    [DataMember(Name = "externalSource", EmitDefaultValue = false)]
    public ExternalSource ExternalSource { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactIdentifier {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ContactIdentifier);
    }

    /// <summary>
    /// Returns true if ContactIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactIdentifier other)
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
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ExternalSource == other.ExternalSource ||
                ExternalSource != null &&
                ExternalSource.Equals(other.ExternalSource)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ExternalSource != null)
            {
                hash = hash * 59 + ExternalSource.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
