using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainLogicalInterface
/// </summary>

public partial class DomainLogicalInterface : IEquatable<DomainLogicalInterface>
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
    /// The type of this network interface.
    /// </summary>
    /// <value>The type of this network interface.</value>
    
    public enum InterfaceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Diagnostic for "DIAGNOSTIC"
        /// </summary>
        [EnumMember(Value = "DIAGNOSTIC")]
        Diagnostic,

        /// <summary>
        /// Enum System for "SYSTEM"
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        System
    }
    /// <summary>
    /// Gets or Sets CurrentState
    /// </summary>
    
    public enum CurrentStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Init for "INIT"
        /// </summary>
        [EnumMember(Value = "INIT")]
        Init,

        /// <summary>
        /// Enum Creating for "CREATING"
        /// </summary>
        [EnumMember(Value = "CREATING")]
        Creating,

        /// <summary>
        /// Enum Updating for "UPDATING"
        /// </summary>
        [EnumMember(Value = "UPDATING")]
        Updating,

        /// <summary>
        /// Enum Ok for "OK"
        /// </summary>
        [EnumMember(Value = "OK")]
        Ok,

        /// <summary>
        /// Enum Exception for "EXCEPTION"
        /// </summary>
        [EnumMember(Value = "EXCEPTION")]
        Exception,

        /// <summary>
        /// Enum Deleting for "DELETING"
        /// </summary>
        [EnumMember(Value = "DELETING")]
        Deleting
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// The type of this network interface.
    /// </summary>
    /// <value>The type of this network interface.</value>
    [JsonPropertyName("interfaceType")]
    public InterfaceTypeEnum? InterfaceType { get; private set; }
    /// <summary>
    /// Gets or Sets CurrentState
    /// </summary>
    [JsonPropertyName("currentState")]
    public CurrentStateEnum? CurrentState { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DomainLogicalInterface" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DomainLogicalInterface() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainLogicalInterface" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="EdgeUri">EdgeUri.</param>
    /// <param name="EdgeAssignedId">EdgeAssignedId.</param>
    /// <param name="FriendlyName">Friendly Name (required).</param>
    /// <param name="VlanTagId">VlanTagId.</param>
    /// <param name="HardwareAddress">Hardware Address (required).</param>
    /// <param name="PhysicalAdapterId">Physical Adapter Id (required).</param>
    /// <param name="IfStatus">IfStatus.</param>
    /// <param name="PublicNatAddressIpV4">IPv4 NENT IP Address.</param>
    /// <param name="PublicNatAddressIpV6">IPv6 NENT IP Address.</param>
    /// <param name="Routes">The list of routes assigned to this interface..</param>
    /// <param name="Addresses">The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list..</param>
    /// <param name="Ipv4Capabilities">IPv4 interface settings..</param>
    /// <param name="Ipv6Capabilities">IPv6 interface settings..</param>
    /// <param name="CurrentState">CurrentState.</param>
    /// <param name="LastModifiedUserId">LastModifiedUserId.</param>
    /// <param name="LastModifiedCorrelationId">LastModifiedCorrelationId.</param>
    /// <param name="CommandResponses">CommandResponses.</param>
    /// <param name="InheritPhoneTrunkBasesIPv4">The IPv4 phone trunk base assignment will be inherited from the Edge Group..</param>
    /// <param name="InheritPhoneTrunkBasesIPv6">The IPv6 phone trunk base assignment will be inherited from the Edge Group..</param>
    /// <param name="UseForInternalEdgeCommunication">This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group..</param>
    /// <param name="UseForIndirectEdgeCommunication">Site Interconnects using the \&quot;Indirect\&quot; method will communicate using the Public IP Address specified on the interface. Use this option when a NAT enabled firewall is between the Edge and the far end..</param>
    /// <param name="UseForCloudProxyEdgeCommunication">Site Interconnects using the \&quot;Cloud Proxy\&quot; method will broker the connection between them with a Cloud Proxy. This method is required for connections between one or more Sites using Cloud Media, but can optionally be used between two premises Sites if Direct or Indirect are not an option..</param>
    /// <param name="ExternalTrunkBaseAssignments">External trunk base settings to use for external communication from this interface..</param>
    /// <param name="PhoneTrunkBaseAssignments">Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true..</param>
    /// <param name="TraceEnabled">TraceEnabled.</param>
    /// <param name="StartDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public DomainLogicalInterface(string Name = null, Division Division = null, string Description = null, int? Version = null, string EdgeUri = null, string EdgeAssignedId = null, string FriendlyName = null, int? VlanTagId = null, string HardwareAddress = null, string PhysicalAdapterId = null, string IfStatus = null, string PublicNatAddressIpV4 = null, string PublicNatAddressIpV6 = null, List<DomainNetworkRoute> Routes = null, List<DomainNetworkAddress> Addresses = null, DomainCapabilities Ipv4Capabilities = null, DomainCapabilities Ipv6Capabilities = null, CurrentStateEnum? CurrentState = null, string LastModifiedUserId = null, string LastModifiedCorrelationId = null, List<DomainNetworkCommandResponse> CommandResponses = null, bool? InheritPhoneTrunkBasesIPv4 = null, bool? InheritPhoneTrunkBasesIPv6 = null, bool? UseForInternalEdgeCommunication = null, bool? UseForIndirectEdgeCommunication = null, bool? UseForCloudProxyEdgeCommunication = null, List<TrunkBaseAssignment> ExternalTrunkBaseAssignments = null, List<TrunkBaseAssignment> PhoneTrunkBaseAssignments = null, bool? TraceEnabled = null, DateTime? StartDate = null, DateTime? EndDate = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.EdgeUri = EdgeUri;
        this.EdgeAssignedId = EdgeAssignedId;
        this.FriendlyName = FriendlyName;
        this.VlanTagId = VlanTagId;
        this.HardwareAddress = HardwareAddress;
        this.PhysicalAdapterId = PhysicalAdapterId;
        this.IfStatus = IfStatus;
        this.PublicNatAddressIpV4 = PublicNatAddressIpV4;
        this.PublicNatAddressIpV6 = PublicNatAddressIpV6;
        this.Routes = Routes;
        this.Addresses = Addresses;
        this.Ipv4Capabilities = Ipv4Capabilities;
        this.Ipv6Capabilities = Ipv6Capabilities;
        this.CurrentState = CurrentState;
        this.LastModifiedUserId = LastModifiedUserId;
        this.LastModifiedCorrelationId = LastModifiedCorrelationId;
        this.CommandResponses = CommandResponses;
        this.InheritPhoneTrunkBasesIPv4 = InheritPhoneTrunkBasesIPv4;
        this.InheritPhoneTrunkBasesIPv6 = InheritPhoneTrunkBasesIPv6;
        this.UseForInternalEdgeCommunication = UseForInternalEdgeCommunication;
        this.UseForIndirectEdgeCommunication = UseForIndirectEdgeCommunication;
        this.UseForCloudProxyEdgeCommunication = UseForCloudProxyEdgeCommunication;
        this.ExternalTrunkBaseAssignments = ExternalTrunkBaseAssignments;
        this.PhoneTrunkBaseAssignments = PhoneTrunkBaseAssignments;
        this.TraceEnabled = TraceEnabled;
        this.StartDate = StartDate;
        this.EndDate = EndDate;

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
    /// Gets or Sets EdgeUri
    /// </summary>
    [JsonPropertyName("edgeUri")]
    public string EdgeUri { get; set; }



    /// <summary>
    /// Gets or Sets EdgeAssignedId
    /// </summary>
    [JsonPropertyName("edgeAssignedId")]
    public string EdgeAssignedId { get; set; }



    /// <summary>
    /// Friendly Name
    /// </summary>
    /// <value>Friendly Name</value>
    [JsonPropertyName("friendlyName")]
    public string FriendlyName { get; set; }



    /// <summary>
    /// Gets or Sets VlanTagId
    /// </summary>
    [JsonPropertyName("vlanTagId")]
    public int? VlanTagId { get; set; }



    /// <summary>
    /// Hardware Address
    /// </summary>
    /// <value>Hardware Address</value>
    [JsonPropertyName("hardwareAddress")]
    public string HardwareAddress { get; set; }



    /// <summary>
    /// Physical Adapter Id
    /// </summary>
    /// <value>Physical Adapter Id</value>
    [JsonPropertyName("physicalAdapterId")]
    public string PhysicalAdapterId { get; set; }



    /// <summary>
    /// Gets or Sets IfStatus
    /// </summary>
    [JsonPropertyName("ifStatus")]
    public string IfStatus { get; set; }





    /// <summary>
    /// IPv4 NENT IP Address
    /// </summary>
    /// <value>IPv4 NENT IP Address</value>
    [JsonPropertyName("publicNatAddressIpV4")]
    public string PublicNatAddressIpV4 { get; set; }



    /// <summary>
    /// IPv6 NENT IP Address
    /// </summary>
    /// <value>IPv6 NENT IP Address</value>
    [JsonPropertyName("publicNatAddressIpV6")]
    public string PublicNatAddressIpV6 { get; set; }



    /// <summary>
    /// The list of routes assigned to this interface.
    /// </summary>
    /// <value>The list of routes assigned to this interface.</value>
    [JsonPropertyName("routes")]
    public List<DomainNetworkRoute> Routes { get; set; }



    /// <summary>
    /// The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.
    /// </summary>
    /// <value>The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list.</value>
    [JsonPropertyName("addresses")]
    public List<DomainNetworkAddress> Addresses { get; set; }



    /// <summary>
    /// IPv4 interface settings.
    /// </summary>
    /// <value>IPv4 interface settings.</value>
    [JsonPropertyName("ipv4Capabilities")]
    public DomainCapabilities Ipv4Capabilities { get; set; }



    /// <summary>
    /// IPv6 interface settings.
    /// </summary>
    /// <value>IPv6 interface settings.</value>
    [JsonPropertyName("ipv6Capabilities")]
    public DomainCapabilities Ipv6Capabilities { get; set; }





    /// <summary>
    /// Gets or Sets LastModifiedUserId
    /// </summary>
    [JsonPropertyName("lastModifiedUserId")]
    public string LastModifiedUserId { get; set; }



    /// <summary>
    /// Gets or Sets LastModifiedCorrelationId
    /// </summary>
    [JsonPropertyName("lastModifiedCorrelationId")]
    public string LastModifiedCorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets CommandResponses
    /// </summary>
    [JsonPropertyName("commandResponses")]
    public List<DomainNetworkCommandResponse> CommandResponses { get; set; }



    /// <summary>
    /// The IPv4 phone trunk base assignment will be inherited from the Edge Group.
    /// </summary>
    /// <value>The IPv4 phone trunk base assignment will be inherited from the Edge Group.</value>
    [JsonPropertyName("inheritPhoneTrunkBasesIPv4")]
    public bool? InheritPhoneTrunkBasesIPv4 { get; set; }



    /// <summary>
    /// The IPv6 phone trunk base assignment will be inherited from the Edge Group.
    /// </summary>
    /// <value>The IPv6 phone trunk base assignment will be inherited from the Edge Group.</value>
    [JsonPropertyName("inheritPhoneTrunkBasesIPv6")]
    public bool? InheritPhoneTrunkBasesIPv6 { get; set; }



    /// <summary>
    /// This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group.
    /// </summary>
    /// <value>This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group.</value>
    [JsonPropertyName("useForInternalEdgeCommunication")]
    public bool? UseForInternalEdgeCommunication { get; set; }



    /// <summary>
    /// Site Interconnects using the \&quot;Indirect\&quot; method will communicate using the Public IP Address specified on the interface. Use this option when a NAT enabled firewall is between the Edge and the far end.
    /// </summary>
    /// <value>Site Interconnects using the \&quot;Indirect\&quot; method will communicate using the Public IP Address specified on the interface. Use this option when a NAT enabled firewall is between the Edge and the far end.</value>
    [JsonPropertyName("useForIndirectEdgeCommunication")]
    public bool? UseForIndirectEdgeCommunication { get; set; }



    /// <summary>
    /// Site Interconnects using the \&quot;Cloud Proxy\&quot; method will broker the connection between them with a Cloud Proxy. This method is required for connections between one or more Sites using Cloud Media, but can optionally be used between two premises Sites if Direct or Indirect are not an option.
    /// </summary>
    /// <value>Site Interconnects using the \&quot;Cloud Proxy\&quot; method will broker the connection between them with a Cloud Proxy. This method is required for connections between one or more Sites using Cloud Media, but can optionally be used between two premises Sites if Direct or Indirect are not an option.</value>
    [JsonPropertyName("useForCloudProxyEdgeCommunication")]
    public bool? UseForCloudProxyEdgeCommunication { get; set; }



    /// <summary>
    /// This interface will be used for all communication with the internet.
    /// </summary>
    /// <value>This interface will be used for all communication with the internet.</value>
    [JsonPropertyName("useForWanInterface")]
    public bool? UseForWanInterface { get; private set; }



    /// <summary>
    /// External trunk base settings to use for external communication from this interface.
    /// </summary>
    /// <value>External trunk base settings to use for external communication from this interface.</value>
    [JsonPropertyName("externalTrunkBaseAssignments")]
    public List<TrunkBaseAssignment> ExternalTrunkBaseAssignments { get; set; }



    /// <summary>
    /// Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true.
    /// </summary>
    /// <value>Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true.</value>
    [JsonPropertyName("phoneTrunkBaseAssignments")]
    public List<TrunkBaseAssignment> PhoneTrunkBaseAssignments { get; set; }



    /// <summary>
    /// Gets or Sets TraceEnabled
    /// </summary>
    [JsonPropertyName("traceEnabled")]
    public bool? TraceEnabled { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



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
        sb.Append("class DomainLogicalInterface {\n");

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
        sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
        sb.Append("  EdgeAssignedId: ").Append(EdgeAssignedId).Append("\n");
        sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
        sb.Append("  VlanTagId: ").Append(VlanTagId).Append("\n");
        sb.Append("  HardwareAddress: ").Append(HardwareAddress).Append("\n");
        sb.Append("  PhysicalAdapterId: ").Append(PhysicalAdapterId).Append("\n");
        sb.Append("  IfStatus: ").Append(IfStatus).Append("\n");
        sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
        sb.Append("  PublicNatAddressIpV4: ").Append(PublicNatAddressIpV4).Append("\n");
        sb.Append("  PublicNatAddressIpV6: ").Append(PublicNatAddressIpV6).Append("\n");
        sb.Append("  Routes: ").Append(Routes).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  Ipv4Capabilities: ").Append(Ipv4Capabilities).Append("\n");
        sb.Append("  Ipv6Capabilities: ").Append(Ipv6Capabilities).Append("\n");
        sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
        sb.Append("  LastModifiedUserId: ").Append(LastModifiedUserId).Append("\n");
        sb.Append("  LastModifiedCorrelationId: ").Append(LastModifiedCorrelationId).Append("\n");
        sb.Append("  CommandResponses: ").Append(CommandResponses).Append("\n");
        sb.Append("  InheritPhoneTrunkBasesIPv4: ").Append(InheritPhoneTrunkBasesIPv4).Append("\n");
        sb.Append("  InheritPhoneTrunkBasesIPv6: ").Append(InheritPhoneTrunkBasesIPv6).Append("\n");
        sb.Append("  UseForInternalEdgeCommunication: ").Append(UseForInternalEdgeCommunication).Append("\n");
        sb.Append("  UseForIndirectEdgeCommunication: ").Append(UseForIndirectEdgeCommunication).Append("\n");
        sb.Append("  UseForCloudProxyEdgeCommunication: ").Append(UseForCloudProxyEdgeCommunication).Append("\n");
        sb.Append("  UseForWanInterface: ").Append(UseForWanInterface).Append("\n");
        sb.Append("  ExternalTrunkBaseAssignments: ").Append(ExternalTrunkBaseAssignments).Append("\n");
        sb.Append("  PhoneTrunkBaseAssignments: ").Append(PhoneTrunkBaseAssignments).Append("\n");
        sb.Append("  TraceEnabled: ").Append(TraceEnabled).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
        return Equals(obj as DomainLogicalInterface);
    }

    /// <summary>
    /// Returns true if DomainLogicalInterface instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainLogicalInterface to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainLogicalInterface other)
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
                EdgeUri == other.EdgeUri ||
                EdgeUri != null &&
                EdgeUri.Equals(other.EdgeUri)
            ) &&
            (
                EdgeAssignedId == other.EdgeAssignedId ||
                EdgeAssignedId != null &&
                EdgeAssignedId.Equals(other.EdgeAssignedId)
            ) &&
            (
                FriendlyName == other.FriendlyName ||
                FriendlyName != null &&
                FriendlyName.Equals(other.FriendlyName)
            ) &&
            (
                VlanTagId == other.VlanTagId ||
                VlanTagId != null &&
                VlanTagId.Equals(other.VlanTagId)
            ) &&
            (
                HardwareAddress == other.HardwareAddress ||
                HardwareAddress != null &&
                HardwareAddress.Equals(other.HardwareAddress)
            ) &&
            (
                PhysicalAdapterId == other.PhysicalAdapterId ||
                PhysicalAdapterId != null &&
                PhysicalAdapterId.Equals(other.PhysicalAdapterId)
            ) &&
            (
                IfStatus == other.IfStatus ||
                IfStatus != null &&
                IfStatus.Equals(other.IfStatus)
            ) &&
            (
                InterfaceType == other.InterfaceType ||
                InterfaceType != null &&
                InterfaceType.Equals(other.InterfaceType)
            ) &&
            (
                PublicNatAddressIpV4 == other.PublicNatAddressIpV4 ||
                PublicNatAddressIpV4 != null &&
                PublicNatAddressIpV4.Equals(other.PublicNatAddressIpV4)
            ) &&
            (
                PublicNatAddressIpV6 == other.PublicNatAddressIpV6 ||
                PublicNatAddressIpV6 != null &&
                PublicNatAddressIpV6.Equals(other.PublicNatAddressIpV6)
            ) &&
            (
                Routes == other.Routes ||
                Routes != null &&
                Routes.SequenceEqual(other.Routes)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                Ipv4Capabilities == other.Ipv4Capabilities ||
                Ipv4Capabilities != null &&
                Ipv4Capabilities.Equals(other.Ipv4Capabilities)
            ) &&
            (
                Ipv6Capabilities == other.Ipv6Capabilities ||
                Ipv6Capabilities != null &&
                Ipv6Capabilities.Equals(other.Ipv6Capabilities)
            ) &&
            (
                CurrentState == other.CurrentState ||
                CurrentState != null &&
                CurrentState.Equals(other.CurrentState)
            ) &&
            (
                LastModifiedUserId == other.LastModifiedUserId ||
                LastModifiedUserId != null &&
                LastModifiedUserId.Equals(other.LastModifiedUserId)
            ) &&
            (
                LastModifiedCorrelationId == other.LastModifiedCorrelationId ||
                LastModifiedCorrelationId != null &&
                LastModifiedCorrelationId.Equals(other.LastModifiedCorrelationId)
            ) &&
            (
                CommandResponses == other.CommandResponses ||
                CommandResponses != null &&
                CommandResponses.SequenceEqual(other.CommandResponses)
            ) &&
            (
                InheritPhoneTrunkBasesIPv4 == other.InheritPhoneTrunkBasesIPv4 ||
                InheritPhoneTrunkBasesIPv4 != null &&
                InheritPhoneTrunkBasesIPv4.Equals(other.InheritPhoneTrunkBasesIPv4)
            ) &&
            (
                InheritPhoneTrunkBasesIPv6 == other.InheritPhoneTrunkBasesIPv6 ||
                InheritPhoneTrunkBasesIPv6 != null &&
                InheritPhoneTrunkBasesIPv6.Equals(other.InheritPhoneTrunkBasesIPv6)
            ) &&
            (
                UseForInternalEdgeCommunication == other.UseForInternalEdgeCommunication ||
                UseForInternalEdgeCommunication != null &&
                UseForInternalEdgeCommunication.Equals(other.UseForInternalEdgeCommunication)
            ) &&
            (
                UseForIndirectEdgeCommunication == other.UseForIndirectEdgeCommunication ||
                UseForIndirectEdgeCommunication != null &&
                UseForIndirectEdgeCommunication.Equals(other.UseForIndirectEdgeCommunication)
            ) &&
            (
                UseForCloudProxyEdgeCommunication == other.UseForCloudProxyEdgeCommunication ||
                UseForCloudProxyEdgeCommunication != null &&
                UseForCloudProxyEdgeCommunication.Equals(other.UseForCloudProxyEdgeCommunication)
            ) &&
            (
                UseForWanInterface == other.UseForWanInterface ||
                UseForWanInterface != null &&
                UseForWanInterface.Equals(other.UseForWanInterface)
            ) &&
            (
                ExternalTrunkBaseAssignments == other.ExternalTrunkBaseAssignments ||
                ExternalTrunkBaseAssignments != null &&
                ExternalTrunkBaseAssignments.SequenceEqual(other.ExternalTrunkBaseAssignments)
            ) &&
            (
                PhoneTrunkBaseAssignments == other.PhoneTrunkBaseAssignments ||
                PhoneTrunkBaseAssignments != null &&
                PhoneTrunkBaseAssignments.SequenceEqual(other.PhoneTrunkBaseAssignments)
            ) &&
            (
                TraceEnabled == other.TraceEnabled ||
                TraceEnabled != null &&
                TraceEnabled.Equals(other.TraceEnabled)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
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

            if (EdgeUri != null)
            {
                hash = hash * 59 + EdgeUri.GetHashCode();
            }

            if (EdgeAssignedId != null)
            {
                hash = hash * 59 + EdgeAssignedId.GetHashCode();
            }

            if (FriendlyName != null)
            {
                hash = hash * 59 + FriendlyName.GetHashCode();
            }

            if (VlanTagId != null)
            {
                hash = hash * 59 + VlanTagId.GetHashCode();
            }

            if (HardwareAddress != null)
            {
                hash = hash * 59 + HardwareAddress.GetHashCode();
            }

            if (PhysicalAdapterId != null)
            {
                hash = hash * 59 + PhysicalAdapterId.GetHashCode();
            }

            if (IfStatus != null)
            {
                hash = hash * 59 + IfStatus.GetHashCode();
            }

            if (InterfaceType != null)
            {
                hash = hash * 59 + InterfaceType.GetHashCode();
            }

            if (PublicNatAddressIpV4 != null)
            {
                hash = hash * 59 + PublicNatAddressIpV4.GetHashCode();
            }

            if (PublicNatAddressIpV6 != null)
            {
                hash = hash * 59 + PublicNatAddressIpV6.GetHashCode();
            }

            if (Routes != null)
            {
                hash = hash * 59 + Routes.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (Ipv4Capabilities != null)
            {
                hash = hash * 59 + Ipv4Capabilities.GetHashCode();
            }

            if (Ipv6Capabilities != null)
            {
                hash = hash * 59 + Ipv6Capabilities.GetHashCode();
            }

            if (CurrentState != null)
            {
                hash = hash * 59 + CurrentState.GetHashCode();
            }

            if (LastModifiedUserId != null)
            {
                hash = hash * 59 + LastModifiedUserId.GetHashCode();
            }

            if (LastModifiedCorrelationId != null)
            {
                hash = hash * 59 + LastModifiedCorrelationId.GetHashCode();
            }

            if (CommandResponses != null)
            {
                hash = hash * 59 + CommandResponses.GetHashCode();
            }

            if (InheritPhoneTrunkBasesIPv4 != null)
            {
                hash = hash * 59 + InheritPhoneTrunkBasesIPv4.GetHashCode();
            }

            if (InheritPhoneTrunkBasesIPv6 != null)
            {
                hash = hash * 59 + InheritPhoneTrunkBasesIPv6.GetHashCode();
            }

            if (UseForInternalEdgeCommunication != null)
            {
                hash = hash * 59 + UseForInternalEdgeCommunication.GetHashCode();
            }

            if (UseForIndirectEdgeCommunication != null)
            {
                hash = hash * 59 + UseForIndirectEdgeCommunication.GetHashCode();
            }

            if (UseForCloudProxyEdgeCommunication != null)
            {
                hash = hash * 59 + UseForCloudProxyEdgeCommunication.GetHashCode();
            }

            if (UseForWanInterface != null)
            {
                hash = hash * 59 + UseForWanInterface.GetHashCode();
            }

            if (ExternalTrunkBaseAssignments != null)
            {
                hash = hash * 59 + ExternalTrunkBaseAssignments.GetHashCode();
            }

            if (PhoneTrunkBaseAssignments != null)
            {
                hash = hash * 59 + PhoneTrunkBaseAssignments.GetHashCode();
            }

            if (TraceEnabled != null)
            {
                hash = hash * 59 + TraceEnabled.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
