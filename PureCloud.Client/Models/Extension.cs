using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Extension
/// </summary>
[DataContract]
public partial class Extension : IEquatable<Extension>
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
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
    /// Gets or Sets OwnerType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OwnerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Phone for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone,

        /// <summary>
        /// Enum IvrConfig for "IVR_CONFIG"
        /// </summary>
        [EnumMember(Value = "IVR_CONFIG")]
        IvrConfig,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// Gets or Sets OwnerType
    /// </summary>
    [DataMember(Name = "ownerType", EmitDefaultValue = false)]
    public OwnerTypeEnum? OwnerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Extension" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Extension() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Extension" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Number">Number.</param>
    /// <param name="Owner">A Uri reference to the owner of this extension, which is either a User or an IVR.</param>
    /// <param name="ExtensionPool">ExtensionPool.</param>
    /// <param name="OwnerType">OwnerType.</param>
    public Extension(string Name = null, Division Division = null, string Description = null, int? Version = null, string Number = null, DomainEntityRef Owner = null, DomainEntityRef ExtensionPool = null, OwnerTypeEnum? OwnerType = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Number = Number;
        this.Owner = Owner;
        this.ExtensionPool = ExtensionPool;
        this.OwnerType = OwnerType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; set; }



    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public string ModifiedBy { get; private set; }



    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public string CreatedBy { get; private set; }





    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    [DataMember(Name = "modifiedByApp", EmitDefaultValue = false)]
    public string ModifiedByApp { get; private set; }



    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    [DataMember(Name = "createdByApp", EmitDefaultValue = false)]
    public string CreatedByApp { get; private set; }



    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    public string Number { get; set; }



    /// <summary>
    /// A Uri reference to the owner of this extension, which is either a User or an IVR
    /// </summary>
    /// <value>A Uri reference to the owner of this extension, which is either a User or an IVR</value>
    [DataMember(Name = "owner", EmitDefaultValue = false)]
    public DomainEntityRef Owner { get; set; }



    /// <summary>
    /// Gets or Sets ExtensionPool
    /// </summary>
    [DataMember(Name = "extensionPool", EmitDefaultValue = false)]
    public DomainEntityRef ExtensionPool { get; set; }





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
        sb.Append("class Extension {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
        sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
        sb.Append("  Number: ").Append(Number).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  ExtensionPool: ").Append(ExtensionPool).Append("\n");
        sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
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
        return this.Equals(obj as Extension);
    }

    /// <summary>
    /// Returns true if Extension instances are equal
    /// </summary>
    /// <param name="other">Instance of Extension to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Extension other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Division == other.Division ||
                this.Division != null &&
                this.Division.Equals(other.Division)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.ModifiedByApp == other.ModifiedByApp ||
                this.ModifiedByApp != null &&
                this.ModifiedByApp.Equals(other.ModifiedByApp)
            ) &&
            (
                this.CreatedByApp == other.CreatedByApp ||
                this.CreatedByApp != null &&
                this.CreatedByApp.Equals(other.CreatedByApp)
            ) &&
            (
                this.Number == other.Number ||
                this.Number != null &&
                this.Number.Equals(other.Number)
            ) &&
            (
                this.Owner == other.Owner ||
                this.Owner != null &&
                this.Owner.Equals(other.Owner)
            ) &&
            (
                this.ExtensionPool == other.ExtensionPool ||
                this.ExtensionPool != null &&
                this.ExtensionPool.Equals(other.ExtensionPool)
            ) &&
            (
                this.OwnerType == other.OwnerType ||
                this.OwnerType != null &&
                this.OwnerType.Equals(other.OwnerType)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Division != null)
            {
                hash = hash * 59 + this.Division.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.CreatedBy != null)
            {
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            }

            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.ModifiedByApp != null)
            {
                hash = hash * 59 + this.ModifiedByApp.GetHashCode();
            }

            if (this.CreatedByApp != null)
            {
                hash = hash * 59 + this.CreatedByApp.GetHashCode();
            }

            if (this.Number != null)
            {
                hash = hash * 59 + this.Number.GetHashCode();
            }

            if (this.Owner != null)
            {
                hash = hash * 59 + this.Owner.GetHashCode();
            }

            if (this.ExtensionPool != null)
            {
                hash = hash * 59 + this.ExtensionPool.GetHashCode();
            }

            if (this.OwnerType != null)
            {
                hash = hash * 59 + this.OwnerType.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
