using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// TrunkBase
/// </summary>
[DataContract]
public partial class TrunkBase : IEquatable<TrunkBase>
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
    /// The type of this trunk base.
    /// </summary>
    /// <value>The type of this trunk base.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TrunkTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum External for "EXTERNAL"
        /// </summary>
        [EnumMember(Value = "EXTERNAL")]
        External,

        /// <summary>
        /// Enum Phone for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone,

        /// <summary>
        /// Enum Edge for "EDGE"
        /// </summary>
        [EnumMember(Value = "EDGE")]
        Edge
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// The type of this trunk base.
    /// </summary>
    /// <value>The type of this trunk base.</value>
    [DataMember(Name = "trunkType", EmitDefaultValue = false)]
    public TrunkTypeEnum? TrunkType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkBase" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrunkBase() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkBase" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="TrunkMetabase">The meta-base this trunk is based on. (required).</param>
    /// <param name="Properties">Properties.</param>
    /// <param name="TrunkType">The type of this trunk base. (required).</param>
    /// <param name="Managed">Is this trunk being managed remotely. This property is synchronized with the managed property of the Edge Group to which it is assigned..</param>
    /// <param name="Site">Used to determine the media regions for inbound and outbound calls through a trunk. Also determines the dial plan to use for calls that came in on a trunk and have to be sent out on it as well..</param>
    /// <param name="InboundSite">Allows a customer to set the site to which inbound calls will be routed.</param>
    public TrunkBase(string Name = null, Division Division = null, string Description = null, int? Version = null, DomainEntityRef TrunkMetabase = null, Dictionary<string, Object> Properties = null, TrunkTypeEnum? TrunkType = null, bool? Managed = null, DomainEntityRef Site = null, DomainEntityRef InboundSite = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.TrunkMetabase = TrunkMetabase;
        this.Properties = Properties;
        this.TrunkType = TrunkType;
        this.Managed = Managed;
        this.Site = Site;
        this.InboundSite = InboundSite;

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
    /// The meta-base this trunk is based on.
    /// </summary>
    /// <value>The meta-base this trunk is based on.</value>
    [DataMember(Name = "trunkMetabase", EmitDefaultValue = false)]
    public DomainEntityRef TrunkMetabase { get; set; }



    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public Dictionary<string, Object> Properties { get; set; }





    /// <summary>
    /// Is this trunk being managed remotely. This property is synchronized with the managed property of the Edge Group to which it is assigned.
    /// </summary>
    /// <value>Is this trunk being managed remotely. This property is synchronized with the managed property of the Edge Group to which it is assigned.</value>
    [DataMember(Name = "managed", EmitDefaultValue = false)]
    public bool? Managed { get; set; }



    /// <summary>
    /// Used to determine the media regions for inbound and outbound calls through a trunk. Also determines the dial plan to use for calls that came in on a trunk and have to be sent out on it as well.
    /// </summary>
    /// <value>Used to determine the media regions for inbound and outbound calls through a trunk. Also determines the dial plan to use for calls that came in on a trunk and have to be sent out on it as well.</value>
    [DataMember(Name = "site", EmitDefaultValue = false)]
    public DomainEntityRef Site { get; set; }



    /// <summary>
    /// Allows a customer to set the site to which inbound calls will be routed
    /// </summary>
    /// <value>Allows a customer to set the site to which inbound calls will be routed</value>
    [DataMember(Name = "inboundSite", EmitDefaultValue = false)]
    public DomainEntityRef InboundSite { get; set; }



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
        sb.Append("class TrunkBase {\n");

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
        sb.Append("  TrunkMetabase: ").Append(TrunkMetabase).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  TrunkType: ").Append(TrunkType).Append("\n");
        sb.Append("  Managed: ").Append(Managed).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  InboundSite: ").Append(InboundSite).Append("\n");
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
        return this.Equals(obj as TrunkBase);
    }

    /// <summary>
    /// Returns true if TrunkBase instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkBase to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkBase other)
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
                this.TrunkMetabase == other.TrunkMetabase ||
                this.TrunkMetabase != null &&
                this.TrunkMetabase.Equals(other.TrunkMetabase)
            ) &&
            (
                this.Properties == other.Properties ||
                this.Properties != null &&
                this.Properties.SequenceEqual(other.Properties)
            ) &&
            (
                this.TrunkType == other.TrunkType ||
                this.TrunkType != null &&
                this.TrunkType.Equals(other.TrunkType)
            ) &&
            (
                this.Managed == other.Managed ||
                this.Managed != null &&
                this.Managed.Equals(other.Managed)
            ) &&
            (
                this.Site == other.Site ||
                this.Site != null &&
                this.Site.Equals(other.Site)
            ) &&
            (
                this.InboundSite == other.InboundSite ||
                this.InboundSite != null &&
                this.InboundSite.Equals(other.InboundSite)
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

            if (this.TrunkMetabase != null)
            {
                hash = hash * 59 + this.TrunkMetabase.GetHashCode();
            }

            if (this.Properties != null)
            {
                hash = hash * 59 + this.Properties.GetHashCode();
            }

            if (this.TrunkType != null)
            {
                hash = hash * 59 + this.TrunkType.GetHashCode();
            }

            if (this.Managed != null)
            {
                hash = hash * 59 + this.Managed.GetHashCode();
            }

            if (this.Site != null)
            {
                hash = hash * 59 + this.Site.GetHashCode();
            }

            if (this.InboundSite != null)
            {
                hash = hash * 59 + this.InboundSite.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
