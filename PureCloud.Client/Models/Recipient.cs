using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Recipient
/// </summary>
[DataContract]
public partial class Recipient : IEquatable<Recipient>
{
    /// <summary>
    /// The messenger type for this recipient
    /// </summary>
    /// <value>The messenger type for this recipient</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessengerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Facebook for "facebook"
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "webmessaging"
        /// </summary>
        [EnumMember(Value = "webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Instagram for "instagram"
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Enum Apple for "apple"
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple
    }
    /// <summary>
    /// The messenger type for this recipient
    /// </summary>
    /// <value>The messenger type for this recipient</value>
    [DataMember(Name = "messengerType", EmitDefaultValue = false)]
    public MessengerTypeEnum? MessengerType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Recipient" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Flow">An automate flow object which defines the set of actions to be taken, when a message is received by this recipient..</param>
    /// <param name="DateCreated">Date this recipient was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date this recipient was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">User that created this recipient.</param>
    /// <param name="ModifiedBy">User that modified this recipient.</param>
    /// <param name="MessengerType">The messenger type for this recipient.</param>
    public Recipient(string Name = null, Flow Flow = null, DateTime? DateCreated = null, DateTime? DateModified = null, User CreatedBy = null, User ModifiedBy = null, MessengerTypeEnum? MessengerType = null)
    {
        this.Name = Name;
        this.Flow = Flow;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;
        this.MessengerType = MessengerType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.
    /// </summary>
    /// <value>An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.</value>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public Flow Flow { get; set; }



    /// <summary>
    /// Date this recipient was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this recipient was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date this recipient was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this recipient was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// User that created this recipient
    /// </summary>
    /// <value>User that created this recipient</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; set; }



    /// <summary>
    /// User that modified this recipient
    /// </summary>
    /// <value>User that modified this recipient</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public User ModifiedBy { get; set; }





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
        sb.Append("class Recipient {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
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
        return Equals(obj as Recipient);
    }

    /// <summary>
    /// Returns true if Recipient instances are equal
    /// </summary>
    /// <param name="other">Instance of Recipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Recipient other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                MessengerType == other.MessengerType ||
                MessengerType != null &&
                MessengerType.Equals(other.MessengerType)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (MessengerType != null)
            {
                hash = hash * 59 + MessengerType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
