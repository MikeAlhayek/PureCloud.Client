using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Edge
/// </summary>

public partial class Edge : IEquatable<Edge>
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
    /// The current status of the Edge.
    /// </summary>
    /// <value>The current status of the Edge.</value>
    
    public enum StatusCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum New for "NEW"
        /// </summary>
        [EnumMember(Value = "NEW")]
        New,

        /// <summary>
        /// Enum AwaitingConnection for "AWAITING_CONNECTION"
        /// </summary>
        [EnumMember(Value = "AWAITING_CONNECTION")]
        AwaitingConnection,

        /// <summary>
        /// Enum AwaitingFingerprint for "AWAITING_FINGERPRINT"
        /// </summary>
        [EnumMember(Value = "AWAITING_FINGERPRINT")]
        AwaitingFingerprint,

        /// <summary>
        /// Enum AwaitingFingerprintVerification for "AWAITING_FINGERPRINT_VERIFICATION"
        /// </summary>
        [EnumMember(Value = "AWAITING_FINGERPRINT_VERIFICATION")]
        AwaitingFingerprintVerification,

        /// <summary>
        /// Enum FingerprintVerified for "FINGERPRINT_VERIFIED"
        /// </summary>
        [EnumMember(Value = "FINGERPRINT_VERIFIED")]
        FingerprintVerified,

        /// <summary>
        /// Enum AwaitingBootstrap for "AWAITING_BOOTSTRAP"
        /// </summary>
        [EnumMember(Value = "AWAITING_BOOTSTRAP")]
        AwaitingBootstrap,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Inactive for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        Inactive,

        /// <summary>
        /// Enum Rma for "RMA"
        /// </summary>
        [EnumMember(Value = "RMA")]
        Rma,

        /// <summary>
        /// Enum Unpairing for "UNPAIRING"
        /// </summary>
        [EnumMember(Value = "UNPAIRING")]
        Unpairing,

        /// <summary>
        /// Enum Unpaired for "UNPAIRED"
        /// </summary>
        [EnumMember(Value = "UNPAIRED")]
        Unpaired,

        /// <summary>
        /// Enum Initializing for "INITIALIZING"
        /// </summary>
        [EnumMember(Value = "INITIALIZING")]
        Initializing
    }
    /// <summary>
    /// Gets or Sets OnlineStatus
    /// </summary>
    
    public enum OnlineStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Online for "ONLINE"
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        Online,

        /// <summary>
        /// Enum Offline for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        Offline
    }
    /// <summary>
    /// Gets or Sets EdgeDeploymentType
    /// </summary>
    
    public enum EdgeDeploymentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hardware for "HARDWARE"
        /// </summary>
        [EnumMember(Value = "HARDWARE")]
        Hardware,

        /// <summary>
        /// Enum Ldm for "LDM"
        /// </summary>
        [EnumMember(Value = "LDM")]
        Ldm,

        /// <summary>
        /// Enum Cdm for "CDM"
        /// </summary>
        [EnumMember(Value = "CDM")]
        Cdm,

        /// <summary>
        /// Enum Chs for "CHS"
        /// </summary>
        [EnumMember(Value = "CHS")]
        Chs,

        /// <summary>
        /// Enum Invalid for "INVALID"
        /// </summary>
        [EnumMember(Value = "INVALID")]
        Invalid
    }
    /// <summary>
    /// The type of certificate used to communicate with edge-proxy.
    /// </summary>
    /// <value>The type of certificate used to communicate with edge-proxy.</value>
    
    public enum CertTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum PureCloudEnvironment for "PureCloud"
        /// </summary>
        [EnumMember(Value = "PureCloud")]
        Purecloud,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum China for "China"
        /// </summary>
        [EnumMember(Value = "China")]
        China,

        /// <summary>
        /// Enum Notrequested for "NotRequested"
        /// </summary>
        [EnumMember(Value = "NotRequested")]
        Notrequested
    }
    /// <summary>
    /// The current state of the Edge's call draining process before it can be safely rebooted or updated.
    /// </summary>
    /// <value>The current state of the Edge's call draining process before it can be safely rebooted or updated.</value>
    
    public enum CallDrainingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Wait for "WAIT"
        /// </summary>
        [EnumMember(Value = "WAIT")]
        Wait,

        /// <summary>
        /// Enum WaitTimeout for "WAIT_TIMEOUT"
        /// </summary>
        [EnumMember(Value = "WAIT_TIMEOUT")]
        WaitTimeout,

        /// <summary>
        /// Enum Terminate for "TERMINATE"
        /// </summary>
        [EnumMember(Value = "TERMINATE")]
        Terminate,

        /// <summary>
        /// Enum Complete for "COMPLETE"
        /// </summary>
        [EnumMember(Value = "COMPLETE")]
        Complete
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// The current status of the Edge.
    /// </summary>
    /// <value>The current status of the Edge.</value>
    [JsonPropertyName("statusCode")]
    public StatusCodeEnum? StatusCode { get; set; }
    /// <summary>
    /// Gets or Sets OnlineStatus
    /// </summary>
    [JsonPropertyName("onlineStatus")]
    public OnlineStatusEnum? OnlineStatus { get; set; }
    /// <summary>
    /// Gets or Sets EdgeDeploymentType
    /// </summary>
    [JsonPropertyName("edgeDeploymentType")]
    public EdgeDeploymentTypeEnum? EdgeDeploymentType { get; set; }
    /// <summary>
    /// The type of certificate used to communicate with edge-proxy.
    /// </summary>
    /// <value>The type of certificate used to communicate with edge-proxy.</value>
    [JsonPropertyName("certType")]
    public CertTypeEnum? CertType { get; set; }
    /// <summary>
    /// The current state of the Edge's call draining process before it can be safely rebooted or updated.
    /// </summary>
    /// <value>The current state of the Edge's call draining process before it can be safely rebooted or updated.</value>
    [JsonPropertyName("callDrainingState")]
    public CallDrainingStateEnum? CallDrainingState { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Edge" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Edge() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Edge" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Interfaces">The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead.</param>
    /// <param name="Make">Make.</param>
    /// <param name="Model">Model.</param>
    /// <param name="ApiVersion">ApiVersion.</param>
    /// <param name="SoftwareVersion">SoftwareVersion.</param>
    /// <param name="SoftwareVersionTimestamp">SoftwareVersionTimestamp.</param>
    /// <param name="SoftwareVersionPlatform">SoftwareVersionPlatform.</param>
    /// <param name="SoftwareVersionConfiguration">SoftwareVersionConfiguration.</param>
    /// <param name="FullSoftwareVersion">FullSoftwareVersion.</param>
    /// <param name="PairingId">The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE..</param>
    /// <param name="Fingerprint">Fingerprint.</param>
    /// <param name="FingerprintHint">FingerprintHint.</param>
    /// <param name="CurrentVersion">CurrentVersion.</param>
    /// <param name="StagedVersion">StagedVersion.</param>
    /// <param name="Patch">Patch.</param>
    /// <param name="StatusCode">The current status of the Edge..</param>
    /// <param name="EdgeGroup">EdgeGroup.</param>
    /// <param name="Site">The Site to which the Edge is assigned..</param>
    /// <param name="SoftwareStatus">Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge..</param>
    /// <param name="OnlineStatus">OnlineStatus.</param>
    /// <param name="SerialNumber">SerialNumber.</param>
    /// <param name="PhysicalEdge">PhysicalEdge.</param>
    /// <param name="Managed">Managed.</param>
    /// <param name="EdgeDeploymentType">EdgeDeploymentType.</param>
    /// <param name="CertType">The type of certificate used to communicate with edge-proxy..</param>
    /// <param name="Proxy">Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed..</param>
    public Edge(string Name = null, Division Division = null, string Description = null, int? Version = null, List<EdgeInterface> Interfaces = null, string Make = null, string Model = null, string ApiVersion = null, string SoftwareVersion = null, string SoftwareVersionTimestamp = null, string SoftwareVersionPlatform = null, string SoftwareVersionConfiguration = null, string FullSoftwareVersion = null, string PairingId = null, string Fingerprint = null, string FingerprintHint = null, string CurrentVersion = null, string StagedVersion = null, string Patch = null, StatusCodeEnum? StatusCode = null, EdgeGroup EdgeGroup = null, Site Site = null, DomainEdgeSoftwareUpdateDto SoftwareStatus = null, OnlineStatusEnum? OnlineStatus = null, string SerialNumber = null, bool? PhysicalEdge = null, bool? Managed = null, EdgeDeploymentTypeEnum? EdgeDeploymentType = null, CertTypeEnum? CertType = null, string Proxy = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Interfaces = Interfaces;
        this.Make = Make;
        this.Model = Model;
        this.ApiVersion = ApiVersion;
        this.SoftwareVersion = SoftwareVersion;
        this.SoftwareVersionTimestamp = SoftwareVersionTimestamp;
        this.SoftwareVersionPlatform = SoftwareVersionPlatform;
        this.SoftwareVersionConfiguration = SoftwareVersionConfiguration;
        this.FullSoftwareVersion = FullSoftwareVersion;
        this.PairingId = PairingId;
        this.Fingerprint = Fingerprint;
        this.FingerprintHint = FingerprintHint;
        this.CurrentVersion = CurrentVersion;
        this.StagedVersion = StagedVersion;
        this.Patch = Patch;
        this.StatusCode = StatusCode;
        this.EdgeGroup = EdgeGroup;
        this.Site = Site;
        this.SoftwareStatus = SoftwareStatus;
        this.OnlineStatus = OnlineStatus;
        this.SerialNumber = SerialNumber;
        this.PhysicalEdge = PhysicalEdge;
        this.Managed = Managed;
        this.EdgeDeploymentType = EdgeDeploymentType;
        this.CertType = CertType;
        this.Proxy = Proxy;

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
    /// The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead
    /// </summary>
    /// <value>The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead</value>
    [JsonPropertyName("interfaces")]
    public List<EdgeInterface> Interfaces { get; set; }



    /// <summary>
    /// Gets or Sets Make
    /// </summary>
    [JsonPropertyName("make")]
    public string Make { get; set; }



    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; set; }



    /// <summary>
    /// Gets or Sets ApiVersion
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }



    /// <summary>
    /// Gets or Sets SoftwareVersion
    /// </summary>
    [JsonPropertyName("softwareVersion")]
    public string SoftwareVersion { get; set; }



    /// <summary>
    /// Gets or Sets SoftwareVersionTimestamp
    /// </summary>
    [JsonPropertyName("softwareVersionTimestamp")]
    public string SoftwareVersionTimestamp { get; set; }



    /// <summary>
    /// Gets or Sets SoftwareVersionPlatform
    /// </summary>
    [JsonPropertyName("softwareVersionPlatform")]
    public string SoftwareVersionPlatform { get; set; }



    /// <summary>
    /// Gets or Sets SoftwareVersionConfiguration
    /// </summary>
    [JsonPropertyName("softwareVersionConfiguration")]
    public string SoftwareVersionConfiguration { get; set; }



    /// <summary>
    /// Gets or Sets FullSoftwareVersion
    /// </summary>
    [JsonPropertyName("fullSoftwareVersion")]
    public string FullSoftwareVersion { get; set; }



    /// <summary>
    /// The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE.
    /// </summary>
    /// <value>The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE.</value>
    [JsonPropertyName("pairingId")]
    public string PairingId { get; set; }



    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string Fingerprint { get; set; }



    /// <summary>
    /// Gets or Sets FingerprintHint
    /// </summary>
    [JsonPropertyName("fingerprintHint")]
    public string FingerprintHint { get; set; }



    /// <summary>
    /// Gets or Sets CurrentVersion
    /// </summary>
    [JsonPropertyName("currentVersion")]
    public string CurrentVersion { get; set; }



    /// <summary>
    /// Gets or Sets StagedVersion
    /// </summary>
    [JsonPropertyName("stagedVersion")]
    public string StagedVersion { get; set; }



    /// <summary>
    /// Gets or Sets Patch
    /// </summary>
    [JsonPropertyName("patch")]
    public string Patch { get; set; }





    /// <summary>
    /// Gets or Sets EdgeGroup
    /// </summary>
    [JsonPropertyName("edgeGroup")]
    public EdgeGroup EdgeGroup { get; set; }



    /// <summary>
    /// The Site to which the Edge is assigned.
    /// </summary>
    /// <value>The Site to which the Edge is assigned.</value>
    [JsonPropertyName("site")]
    public Site Site { get; set; }



    /// <summary>
    /// Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge.
    /// </summary>
    /// <value>Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge.</value>
    [JsonPropertyName("softwareStatus")]
    public DomainEdgeSoftwareUpdateDto SoftwareStatus { get; set; }





    /// <summary>
    /// Gets or Sets SerialNumber
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string SerialNumber { get; set; }



    /// <summary>
    /// Gets or Sets PhysicalEdge
    /// </summary>
    [JsonPropertyName("physicalEdge")]
    public bool? PhysicalEdge { get; set; }



    /// <summary>
    /// Gets or Sets Managed
    /// </summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }









    /// <summary>
    /// The remaining number of conversations the Edge has to drain before it can be safely rebooted or updated. When an Edge is not draining conversations, this will be NULL or 0.
    /// </summary>
    /// <value>The remaining number of conversations the Edge has to drain before it can be safely rebooted or updated. When an Edge is not draining conversations, this will be NULL or 0.</value>
    [JsonPropertyName("conversationCount")]
    public int? ConversationCount { get; private set; }



    /// <summary>
    /// Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.
    /// </summary>
    /// <value>Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.</value>
    [JsonPropertyName("proxy")]
    public string Proxy { get; set; }



    /// <summary>
    /// True if the offline edge configuration endpoint has been called for this edge.
    /// </summary>
    /// <value>True if the offline edge configuration endpoint has been called for this edge.</value>
    [JsonPropertyName("offlineConfigCalled")]
    public bool? OfflineConfigCalled { get; private set; }



    /// <summary>
    /// The name provided by the operating system of the Edge.
    /// </summary>
    /// <value>The name provided by the operating system of the Edge.</value>
    [JsonPropertyName("osName")]
    public string OsName { get; private set; }



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
        sb.Append("class Edge {\n");

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
        sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
        sb.Append("  Make: ").Append(Make).Append("\n");
        sb.Append("  Model: ").Append(Model).Append("\n");
        sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
        sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
        sb.Append("  SoftwareVersionTimestamp: ").Append(SoftwareVersionTimestamp).Append("\n");
        sb.Append("  SoftwareVersionPlatform: ").Append(SoftwareVersionPlatform).Append("\n");
        sb.Append("  SoftwareVersionConfiguration: ").Append(SoftwareVersionConfiguration).Append("\n");
        sb.Append("  FullSoftwareVersion: ").Append(FullSoftwareVersion).Append("\n");
        sb.Append("  PairingId: ").Append(PairingId).Append("\n");
        sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
        sb.Append("  FingerprintHint: ").Append(FingerprintHint).Append("\n");
        sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
        sb.Append("  StagedVersion: ").Append(StagedVersion).Append("\n");
        sb.Append("  Patch: ").Append(Patch).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  SoftwareStatus: ").Append(SoftwareStatus).Append("\n");
        sb.Append("  OnlineStatus: ").Append(OnlineStatus).Append("\n");
        sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
        sb.Append("  PhysicalEdge: ").Append(PhysicalEdge).Append("\n");
        sb.Append("  Managed: ").Append(Managed).Append("\n");
        sb.Append("  EdgeDeploymentType: ").Append(EdgeDeploymentType).Append("\n");
        sb.Append("  CertType: ").Append(CertType).Append("\n");
        sb.Append("  CallDrainingState: ").Append(CallDrainingState).Append("\n");
        sb.Append("  ConversationCount: ").Append(ConversationCount).Append("\n");
        sb.Append("  Proxy: ").Append(Proxy).Append("\n");
        sb.Append("  OfflineConfigCalled: ").Append(OfflineConfigCalled).Append("\n");
        sb.Append("  OsName: ").Append(OsName).Append("\n");
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
        return Equals(obj as Edge);
    }

    /// <summary>
    /// Returns true if Edge instances are equal
    /// </summary>
    /// <param name="other">Instance of Edge to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Edge other)
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
                Interfaces == other.Interfaces ||
                Interfaces != null &&
                Interfaces.SequenceEqual(other.Interfaces)
            ) &&
            (
                Make == other.Make ||
                Make != null &&
                Make.Equals(other.Make)
            ) &&
            (
                Model == other.Model ||
                Model != null &&
                Model.Equals(other.Model)
            ) &&
            (
                ApiVersion == other.ApiVersion ||
                ApiVersion != null &&
                ApiVersion.Equals(other.ApiVersion)
            ) &&
            (
                SoftwareVersion == other.SoftwareVersion ||
                SoftwareVersion != null &&
                SoftwareVersion.Equals(other.SoftwareVersion)
            ) &&
            (
                SoftwareVersionTimestamp == other.SoftwareVersionTimestamp ||
                SoftwareVersionTimestamp != null &&
                SoftwareVersionTimestamp.Equals(other.SoftwareVersionTimestamp)
            ) &&
            (
                SoftwareVersionPlatform == other.SoftwareVersionPlatform ||
                SoftwareVersionPlatform != null &&
                SoftwareVersionPlatform.Equals(other.SoftwareVersionPlatform)
            ) &&
            (
                SoftwareVersionConfiguration == other.SoftwareVersionConfiguration ||
                SoftwareVersionConfiguration != null &&
                SoftwareVersionConfiguration.Equals(other.SoftwareVersionConfiguration)
            ) &&
            (
                FullSoftwareVersion == other.FullSoftwareVersion ||
                FullSoftwareVersion != null &&
                FullSoftwareVersion.Equals(other.FullSoftwareVersion)
            ) &&
            (
                PairingId == other.PairingId ||
                PairingId != null &&
                PairingId.Equals(other.PairingId)
            ) &&
            (
                Fingerprint == other.Fingerprint ||
                Fingerprint != null &&
                Fingerprint.Equals(other.Fingerprint)
            ) &&
            (
                FingerprintHint == other.FingerprintHint ||
                FingerprintHint != null &&
                FingerprintHint.Equals(other.FingerprintHint)
            ) &&
            (
                CurrentVersion == other.CurrentVersion ||
                CurrentVersion != null &&
                CurrentVersion.Equals(other.CurrentVersion)
            ) &&
            (
                StagedVersion == other.StagedVersion ||
                StagedVersion != null &&
                StagedVersion.Equals(other.StagedVersion)
            ) &&
            (
                Patch == other.Patch ||
                Patch != null &&
                Patch.Equals(other.Patch)
            ) &&
            (
                StatusCode == other.StatusCode ||
                StatusCode != null &&
                StatusCode.Equals(other.StatusCode)
            ) &&
            (
                EdgeGroup == other.EdgeGroup ||
                EdgeGroup != null &&
                EdgeGroup.Equals(other.EdgeGroup)
            ) &&
            (
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                SoftwareStatus == other.SoftwareStatus ||
                SoftwareStatus != null &&
                SoftwareStatus.Equals(other.SoftwareStatus)
            ) &&
            (
                OnlineStatus == other.OnlineStatus ||
                OnlineStatus != null &&
                OnlineStatus.Equals(other.OnlineStatus)
            ) &&
            (
                SerialNumber == other.SerialNumber ||
                SerialNumber != null &&
                SerialNumber.Equals(other.SerialNumber)
            ) &&
            (
                PhysicalEdge == other.PhysicalEdge ||
                PhysicalEdge != null &&
                PhysicalEdge.Equals(other.PhysicalEdge)
            ) &&
            (
                Managed == other.Managed ||
                Managed != null &&
                Managed.Equals(other.Managed)
            ) &&
            (
                EdgeDeploymentType == other.EdgeDeploymentType ||
                EdgeDeploymentType != null &&
                EdgeDeploymentType.Equals(other.EdgeDeploymentType)
            ) &&
            (
                CertType == other.CertType ||
                CertType != null &&
                CertType.Equals(other.CertType)
            ) &&
            (
                CallDrainingState == other.CallDrainingState ||
                CallDrainingState != null &&
                CallDrainingState.Equals(other.CallDrainingState)
            ) &&
            (
                ConversationCount == other.ConversationCount ||
                ConversationCount != null &&
                ConversationCount.Equals(other.ConversationCount)
            ) &&
            (
                Proxy == other.Proxy ||
                Proxy != null &&
                Proxy.Equals(other.Proxy)
            ) &&
            (
                OfflineConfigCalled == other.OfflineConfigCalled ||
                OfflineConfigCalled != null &&
                OfflineConfigCalled.Equals(other.OfflineConfigCalled)
            ) &&
            (
                OsName == other.OsName ||
                OsName != null &&
                OsName.Equals(other.OsName)
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

            if (Interfaces != null)
            {
                hash = hash * 59 + Interfaces.GetHashCode();
            }

            if (Make != null)
            {
                hash = hash * 59 + Make.GetHashCode();
            }

            if (Model != null)
            {
                hash = hash * 59 + Model.GetHashCode();
            }

            if (ApiVersion != null)
            {
                hash = hash * 59 + ApiVersion.GetHashCode();
            }

            if (SoftwareVersion != null)
            {
                hash = hash * 59 + SoftwareVersion.GetHashCode();
            }

            if (SoftwareVersionTimestamp != null)
            {
                hash = hash * 59 + SoftwareVersionTimestamp.GetHashCode();
            }

            if (SoftwareVersionPlatform != null)
            {
                hash = hash * 59 + SoftwareVersionPlatform.GetHashCode();
            }

            if (SoftwareVersionConfiguration != null)
            {
                hash = hash * 59 + SoftwareVersionConfiguration.GetHashCode();
            }

            if (FullSoftwareVersion != null)
            {
                hash = hash * 59 + FullSoftwareVersion.GetHashCode();
            }

            if (PairingId != null)
            {
                hash = hash * 59 + PairingId.GetHashCode();
            }

            if (Fingerprint != null)
            {
                hash = hash * 59 + Fingerprint.GetHashCode();
            }

            if (FingerprintHint != null)
            {
                hash = hash * 59 + FingerprintHint.GetHashCode();
            }

            if (CurrentVersion != null)
            {
                hash = hash * 59 + CurrentVersion.GetHashCode();
            }

            if (StagedVersion != null)
            {
                hash = hash * 59 + StagedVersion.GetHashCode();
            }

            if (Patch != null)
            {
                hash = hash * 59 + Patch.GetHashCode();
            }

            if (StatusCode != null)
            {
                hash = hash * 59 + StatusCode.GetHashCode();
            }

            if (EdgeGroup != null)
            {
                hash = hash * 59 + EdgeGroup.GetHashCode();
            }

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (SoftwareStatus != null)
            {
                hash = hash * 59 + SoftwareStatus.GetHashCode();
            }

            if (OnlineStatus != null)
            {
                hash = hash * 59 + OnlineStatus.GetHashCode();
            }

            if (SerialNumber != null)
            {
                hash = hash * 59 + SerialNumber.GetHashCode();
            }

            if (PhysicalEdge != null)
            {
                hash = hash * 59 + PhysicalEdge.GetHashCode();
            }

            if (Managed != null)
            {
                hash = hash * 59 + Managed.GetHashCode();
            }

            if (EdgeDeploymentType != null)
            {
                hash = hash * 59 + EdgeDeploymentType.GetHashCode();
            }

            if (CertType != null)
            {
                hash = hash * 59 + CertType.GetHashCode();
            }

            if (CallDrainingState != null)
            {
                hash = hash * 59 + CallDrainingState.GetHashCode();
            }

            if (ConversationCount != null)
            {
                hash = hash * 59 + ConversationCount.GetHashCode();
            }

            if (Proxy != null)
            {
                hash = hash * 59 + Proxy.GetHashCode();
            }

            if (OfflineConfigCalled != null)
            {
                hash = hash * 59 + OfflineConfigCalled.GetHashCode();
            }

            if (OsName != null)
            {
                hash = hash * 59 + OsName.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
