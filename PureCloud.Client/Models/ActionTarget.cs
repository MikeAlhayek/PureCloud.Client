using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActionTarget
/// </summary>
[DataContract]
public partial class ActionTarget : IEquatable<ActionTarget>
{
    /// <summary>
    /// Gets or Sets SupportedMediaTypes
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SupportedMediaTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Call for "call"
        /// </summary>
        [EnumMember(Value = "call")]
        Call,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Generic for "generic"
        /// </summary>
        [EnumMember(Value = "generic")]
        Generic,

        /// <summary>
        /// Enum Messaging for "messaging"
        /// </summary>
        [EnumMember(Value = "messaging")]
        Messaging,

        /// <summary>
        /// Enum Social for "social"
        /// </summary>
        [EnumMember(Value = "social")]
        Social,

        /// <summary>
        /// Enum Webchat for "webchat"
        /// </summary>
        [EnumMember(Value = "webchat")]
        Webchat
    }
    /// <summary>
    /// Indicates the state of the target.
    /// </summary>
    /// <value>Indicates the state of the target.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Indicates the state of the target.
    /// </summary>
    /// <value>Indicates the state of the target.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionTarget" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="UserData">Additional user data associated with the target in key/value format..</param>
    /// <param name="SupportedMediaTypes">Supported media types of the target..</param>
    /// <param name="State">Indicates the state of the target..</param>
    /// <param name="Description">Description of the target..</param>
    /// <param name="ServiceLevel">Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level..</param>
    /// <param name="ShortAbandonThreshold">Indicates the non-default short abandon threshold.</param>
    /// <param name="CreatedDate">The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedDate">The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ActionTarget(string Name = null, List<KeyValue> UserData = null, List<SupportedMediaTypesEnum> SupportedMediaTypes = null, StateEnum? State = null, string Description = null, ServiceLevel ServiceLevel = null, int? ShortAbandonThreshold = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
    {
        this.Name = Name;
        this.UserData = UserData;
        this.SupportedMediaTypes = SupportedMediaTypes;
        this.State = State;
        this.Description = Description;
        this.ServiceLevel = ServiceLevel;
        this.ShortAbandonThreshold = ShortAbandonThreshold;
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;

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
    /// Additional user data associated with the target in key/value format.
    /// </summary>
    /// <value>Additional user data associated with the target in key/value format.</value>
    [DataMember(Name = "userData", EmitDefaultValue = false)]
    public List<KeyValue> UserData { get; set; }



    /// <summary>
    /// Supported media types of the target.
    /// </summary>
    /// <value>Supported media types of the target.</value>
    [DataMember(Name = "supportedMediaTypes", EmitDefaultValue = false)]
    public List<SupportedMediaTypesEnum> SupportedMediaTypes { get; set; }





    /// <summary>
    /// Description of the target.
    /// </summary>
    /// <value>Description of the target.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.
    /// </summary>
    /// <value>Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.</value>
    [DataMember(Name = "serviceLevel", EmitDefaultValue = false)]
    public ServiceLevel ServiceLevel { get; set; }



    /// <summary>
    /// Indicates the non-default short abandon threshold
    /// </summary>
    /// <value>Indicates the non-default short abandon threshold</value>
    [DataMember(Name = "shortAbandonThreshold", EmitDefaultValue = false)]
    public int? ShortAbandonThreshold { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the target was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the target was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionTarget {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserData: ").Append(UserData).Append("\n");
        sb.Append("  SupportedMediaTypes: ").Append(SupportedMediaTypes).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
        sb.Append("  ShortAbandonThreshold: ").Append(ShortAbandonThreshold).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as ActionTarget);
    }

    /// <summary>
    /// Returns true if ActionTarget instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionTarget to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionTarget other)
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
                UserData == other.UserData ||
                UserData != null &&
                UserData.SequenceEqual(other.UserData)
            ) &&
            (
                SupportedMediaTypes == other.SupportedMediaTypes ||
                SupportedMediaTypes != null &&
                SupportedMediaTypes.SequenceEqual(other.SupportedMediaTypes)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ServiceLevel == other.ServiceLevel ||
                ServiceLevel != null &&
                ServiceLevel.Equals(other.ServiceLevel)
            ) &&
            (
                ShortAbandonThreshold == other.ShortAbandonThreshold ||
                ShortAbandonThreshold != null &&
                ShortAbandonThreshold.Equals(other.ShortAbandonThreshold)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (UserData != null)
            {
                hash = hash * 59 + UserData.GetHashCode();
            }

            if (SupportedMediaTypes != null)
            {
                hash = hash * 59 + SupportedMediaTypes.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ServiceLevel != null)
            {
                hash = hash * 59 + ServiceLevel.GetHashCode();
            }

            if (ShortAbandonThreshold != null)
            {
                hash = hash * 59 + ShortAbandonThreshold.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
