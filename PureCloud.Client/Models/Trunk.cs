using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Trunk
/// </summary>

public partial class Trunk : IEquatable<Trunk>
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    
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
    /// The type of this trunk.
    /// </summary>
    /// <value>The type of this trunk.</value>
    
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
    /// Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.
    /// </summary>
    /// <value>Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.</value>
    
    public enum OptionsEnabledStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "ENABLED"
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        Disabled,

        /// <summary>
        /// Enum NotSupported for "NOT_SUPPORTED"
        /// </summary>
        [EnumMember(Value = "NOT_SUPPORTED")]
        NotSupported
    }
    /// <summary>
    /// Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.
    /// </summary>
    /// <value>Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.</value>
    
    public enum RegistersEnabledStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enabled for "ENABLED"
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        Disabled,

        /// <summary>
        /// Enum NotSupported for "NOT_SUPPORTED"
        /// </summary>
        [EnumMember(Value = "NOT_SUPPORTED")]
        NotSupported
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// The type of this trunk.
    /// </summary>
    /// <value>The type of this trunk.</value>
    [JsonPropertyName("trunkType")]
    public TrunkTypeEnum? TrunkType { get; set; }
    /// <summary>
    /// Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.
    /// </summary>
    /// <value>Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.</value>
    [JsonPropertyName("optionsEnabledStatus")]
    public OptionsEnabledStatusEnum? OptionsEnabledStatus { get; private set; }
    /// <summary>
    /// Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.
    /// </summary>
    /// <value>Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.</value>
    [JsonPropertyName("registersEnabledStatus")]
    public RegistersEnabledStatusEnum? RegistersEnabledStatus { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Trunk" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Trunk() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Trunk" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="TrunkType">The type of this trunk..</param>
    /// <param name="Edge">The Edge using this trunk..</param>
    /// <param name="TrunkBase">The trunk base configuration used on this trunk..</param>
    /// <param name="TrunkMetabase">The metabase used to create this trunk..</param>
    /// <param name="EdgeGroup">The edge group associated with this trunk..</param>
    /// <param name="Enabled">True if the Edge used by this trunk is in-service.</param>
    public Trunk(string Name = null, Division Division = null, string Description = null, int? Version = null, TrunkTypeEnum? TrunkType = null, DomainEntityRef Edge = null, DomainEntityRef TrunkBase = null, DomainEntityRef TrunkMetabase = null, DomainEntityRef EdgeGroup = null, bool? Enabled = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.TrunkType = TrunkType;
        this.Edge = Edge;
        this.TrunkBase = TrunkBase;
        this.TrunkMetabase = TrunkMetabase;
        this.EdgeGroup = EdgeGroup;
        this.Enabled = Enabled;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; private set; }



    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; private set; }





    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    [JsonPropertyName("modifiedByApp")]
    public string ModifiedByApp { get; private set; }



    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    [JsonPropertyName("createdByApp")]
    public string CreatedByApp { get; private set; }





    /// <summary>
    /// The Edge using this trunk.
    /// </summary>
    /// <value>The Edge using this trunk.</value>
    [JsonPropertyName("edge")]
    public DomainEntityRef Edge { get; set; }



    /// <summary>
    /// The trunk base configuration used on this trunk.
    /// </summary>
    /// <value>The trunk base configuration used on this trunk.</value>
    [JsonPropertyName("trunkBase")]
    public DomainEntityRef TrunkBase { get; set; }



    /// <summary>
    /// The metabase used to create this trunk.
    /// </summary>
    /// <value>The metabase used to create this trunk.</value>
    [JsonPropertyName("trunkMetabase")]
    public DomainEntityRef TrunkMetabase { get; set; }



    /// <summary>
    /// The edge group associated with this trunk.
    /// </summary>
    /// <value>The edge group associated with this trunk.</value>
    [JsonPropertyName("edgeGroup")]
    public DomainEntityRef EdgeGroup { get; set; }



    /// <summary>
    /// True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base.
    /// </summary>
    /// <value>True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base.</value>
    [JsonPropertyName("inService")]
    public bool? InService { get; private set; }



    /// <summary>
    /// True if the Edge used by this trunk is in-service
    /// </summary>
    /// <value>True if the Edge used by this trunk is in-service</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The Logical Interface on the Edge to which the trunk is assigned.
    /// </summary>
    /// <value>The Logical Interface on the Edge to which the trunk is assigned.</value>
    [JsonPropertyName("logicalInterface")]
    public DomainEntityRef LogicalInterface { get; private set; }



    /// <summary>
    /// The connected status of the trunk
    /// </summary>
    /// <value>The connected status of the trunk</value>
    [JsonPropertyName("connectedStatus")]
    public TrunkConnectedStatus ConnectedStatus { get; private set; }



    /// <summary>
    /// The trunk optionsStatus
    /// </summary>
    /// <value>The trunk optionsStatus</value>
    [JsonPropertyName("optionsStatus")]
    public List<TrunkMetricsOptions> OptionsStatus { get; private set; }



    /// <summary>
    /// The trunk registersStatus
    /// </summary>
    /// <value>The trunk registersStatus</value>
    [JsonPropertyName("registersStatus")]
    public List<TrunkMetricsRegisters> RegistersStatus { get; private set; }



    /// <summary>
    /// The trunk ipStatus
    /// </summary>
    /// <value>The trunk ipStatus</value>
    [JsonPropertyName("ipStatus")]
    public TrunkMetricsNetworkTypeIp IpStatus { get; private set; }







    /// <summary>
    /// The IP Network Family of the trunk
    /// </summary>
    /// <value>The IP Network Family of the trunk</value>
    [JsonPropertyName("family")]
    public int? Family { get; private set; }



    /// <summary>
    /// The list of proxy addresses (ports if provided) for the trunk
    /// </summary>
    /// <value>The list of proxy addresses (ports if provided) for the trunk</value>
    [JsonPropertyName("proxyAddressList")]
    public List<string> ProxyAddressList { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Trunk {\n");

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
        sb.Append("  TrunkType: ").Append(TrunkType).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  TrunkBase: ").Append(TrunkBase).Append("\n");
        sb.Append("  TrunkMetabase: ").Append(TrunkMetabase).Append("\n");
        sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
        sb.Append("  InService: ").Append(InService).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  LogicalInterface: ").Append(LogicalInterface).Append("\n");
        sb.Append("  ConnectedStatus: ").Append(ConnectedStatus).Append("\n");
        sb.Append("  OptionsStatus: ").Append(OptionsStatus).Append("\n");
        sb.Append("  RegistersStatus: ").Append(RegistersStatus).Append("\n");
        sb.Append("  IpStatus: ").Append(IpStatus).Append("\n");
        sb.Append("  OptionsEnabledStatus: ").Append(OptionsEnabledStatus).Append("\n");
        sb.Append("  RegistersEnabledStatus: ").Append(RegistersEnabledStatus).Append("\n");
        sb.Append("  Family: ").Append(Family).Append("\n");
        sb.Append("  ProxyAddressList: ").Append(ProxyAddressList).Append("\n");
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
        return Equals(obj as Trunk);
    }

    /// <summary>
    /// Returns true if Trunk instances are equal
    /// </summary>
    /// <param name="other">Instance of Trunk to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Trunk other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ModifiedByApp == other.ModifiedByApp ||
                ModifiedByApp != null &&
                ModifiedByApp.Equals(other.ModifiedByApp)
            ) &&
            (
                CreatedByApp == other.CreatedByApp ||
                CreatedByApp != null &&
                CreatedByApp.Equals(other.CreatedByApp)
            ) &&
            (
                TrunkType == other.TrunkType ||
                TrunkType != null &&
                TrunkType.Equals(other.TrunkType)
            ) &&
            (
                Edge == other.Edge ||
                Edge != null &&
                Edge.Equals(other.Edge)
            ) &&
            (
                TrunkBase == other.TrunkBase ||
                TrunkBase != null &&
                TrunkBase.Equals(other.TrunkBase)
            ) &&
            (
                TrunkMetabase == other.TrunkMetabase ||
                TrunkMetabase != null &&
                TrunkMetabase.Equals(other.TrunkMetabase)
            ) &&
            (
                EdgeGroup == other.EdgeGroup ||
                EdgeGroup != null &&
                EdgeGroup.Equals(other.EdgeGroup)
            ) &&
            (
                InService == other.InService ||
                InService != null &&
                InService.Equals(other.InService)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                LogicalInterface == other.LogicalInterface ||
                LogicalInterface != null &&
                LogicalInterface.Equals(other.LogicalInterface)
            ) &&
            (
                ConnectedStatus == other.ConnectedStatus ||
                ConnectedStatus != null &&
                ConnectedStatus.Equals(other.ConnectedStatus)
            ) &&
            (
                OptionsStatus == other.OptionsStatus ||
                OptionsStatus != null &&
                OptionsStatus.SequenceEqual(other.OptionsStatus)
            ) &&
            (
                RegistersStatus == other.RegistersStatus ||
                RegistersStatus != null &&
                RegistersStatus.SequenceEqual(other.RegistersStatus)
            ) &&
            (
                IpStatus == other.IpStatus ||
                IpStatus != null &&
                IpStatus.Equals(other.IpStatus)
            ) &&
            (
                OptionsEnabledStatus == other.OptionsEnabledStatus ||
                OptionsEnabledStatus != null &&
                OptionsEnabledStatus.Equals(other.OptionsEnabledStatus)
            ) &&
            (
                RegistersEnabledStatus == other.RegistersEnabledStatus ||
                RegistersEnabledStatus != null &&
                RegistersEnabledStatus.Equals(other.RegistersEnabledStatus)
            ) &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
            ) &&
            (
                ProxyAddressList == other.ProxyAddressList ||
                ProxyAddressList != null &&
                ProxyAddressList.SequenceEqual(other.ProxyAddressList)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ModifiedByApp != null)
            {
                hash = hash * 59 + ModifiedByApp.GetHashCode();
            }

            if (CreatedByApp != null)
            {
                hash = hash * 59 + CreatedByApp.GetHashCode();
            }

            if (TrunkType != null)
            {
                hash = hash * 59 + TrunkType.GetHashCode();
            }

            if (Edge != null)
            {
                hash = hash * 59 + Edge.GetHashCode();
            }

            if (TrunkBase != null)
            {
                hash = hash * 59 + TrunkBase.GetHashCode();
            }

            if (TrunkMetabase != null)
            {
                hash = hash * 59 + TrunkMetabase.GetHashCode();
            }

            if (EdgeGroup != null)
            {
                hash = hash * 59 + EdgeGroup.GetHashCode();
            }

            if (InService != null)
            {
                hash = hash * 59 + InService.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (LogicalInterface != null)
            {
                hash = hash * 59 + LogicalInterface.GetHashCode();
            }

            if (ConnectedStatus != null)
            {
                hash = hash * 59 + ConnectedStatus.GetHashCode();
            }

            if (OptionsStatus != null)
            {
                hash = hash * 59 + OptionsStatus.GetHashCode();
            }

            if (RegistersStatus != null)
            {
                hash = hash * 59 + RegistersStatus.GetHashCode();
            }

            if (IpStatus != null)
            {
                hash = hash * 59 + IpStatus.GetHashCode();
            }

            if (OptionsEnabledStatus != null)
            {
                hash = hash * 59 + OptionsEnabledStatus.GetHashCode();
            }

            if (RegistersEnabledStatus != null)
            {
                hash = hash * 59 + RegistersEnabledStatus.GetHashCode();
            }

            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            if (ProxyAddressList != null)
            {
                hash = hash * 59 + ProxyAddressList.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
