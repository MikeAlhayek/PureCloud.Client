using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneStatus
/// </summary>
[DataContract]
public partial class PhoneStatus : IEquatable<PhoneStatus>
{
    /// <summary>
    /// The Operational Status of this phone
    /// </summary>
    /// <value>The Operational Status of this phone</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationalStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Operational for "OPERATIONAL"
        /// </summary>
        [EnumMember(Value = "OPERATIONAL")]
        Operational,

        /// <summary>
        /// Enum Degraded for "DEGRADED"
        /// </summary>
        [EnumMember(Value = "DEGRADED")]
        Degraded,

        /// <summary>
        /// Enum Offline for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        Offline,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
    /// <summary>
    /// The status of the primary or secondary Edges assigned to the phone lines.
    /// </summary>
    /// <value>The status of the primary or secondary Edges assigned to the phone lines.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EdgesStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum InService for "IN_SERVICE"
        /// </summary>
        [EnumMember(Value = "IN_SERVICE")]
        InService,

        /// <summary>
        /// Enum MixedService for "MIXED_SERVICE"
        /// </summary>
        [EnumMember(Value = "MIXED_SERVICE")]
        MixedService,

        /// <summary>
        /// Enum OutOfService for "OUT_OF_SERVICE"
        /// </summary>
        [EnumMember(Value = "OUT_OF_SERVICE")]
        OutOfService,

        /// <summary>
        /// Enum NoEdges for "NO_EDGES"
        /// </summary>
        [EnumMember(Value = "NO_EDGES")]
        NoEdges
    }
    /// <summary>
    /// The phone status's edge assignment type.
    /// </summary>
    /// <value>The phone status's edge assignment type.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneAssignmentToEdgeTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Primary for "PRIMARY"
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        Primary,

        /// <summary>
        /// Enum Secondary for "SECONDARY"
        /// </summary>
        [EnumMember(Value = "SECONDARY")]
        Secondary
    }
    /// <summary>
    /// The Operational Status of this phone
    /// </summary>
    /// <value>The Operational Status of this phone</value>
    [DataMember(Name = "operationalStatus", EmitDefaultValue = false)]
    public OperationalStatusEnum? OperationalStatus { get; set; }
    /// <summary>
    /// The status of the primary or secondary Edges assigned to the phone lines.
    /// </summary>
    /// <value>The status of the primary or secondary Edges assigned to the phone lines.</value>
    [DataMember(Name = "edgesStatus", EmitDefaultValue = false)]
    public EdgesStatusEnum? EdgesStatus { get; set; }
    /// <summary>
    /// The phone status's edge assignment type.
    /// </summary>
    /// <value>The phone status's edge assignment type.</value>
    [DataMember(Name = "phoneAssignmentToEdgeType", EmitDefaultValue = false)]
    public PhoneAssignmentToEdgeTypeEnum? PhoneAssignmentToEdgeType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneStatus" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="OperationalStatus">The Operational Status of this phone.</param>
    /// <param name="EdgesStatus">The status of the primary or secondary Edges assigned to the phone lines..</param>
    /// <param name="EventCreationTime">Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London.</param>
    /// <param name="Provision">Provision information for this phone.</param>
    /// <param name="LineStatuses">A list of LineStatus information for each of the lines of this phone.</param>
    /// <param name="PhoneAssignmentToEdgeType">The phone status&#39;s edge assignment type..</param>
    /// <param name="Edge">The URI of the edge that provided this status information..</param>
    /// <param name="SelfUri">The URI for this object. Deprecated. Do not use..</param>
    public PhoneStatus(string Id = null, OperationalStatusEnum? OperationalStatus = null, EdgesStatusEnum? EdgesStatus = null, string EventCreationTime = null, ProvisionInfo Provision = null, List<LineStatus> LineStatuses = null, PhoneAssignmentToEdgeTypeEnum? PhoneAssignmentToEdgeType = null, DomainEntityRef Edge = null, string SelfUri = null)
    {
        this.Id = Id;
        this.OperationalStatus = OperationalStatus;
        this.EdgesStatus = EdgesStatus;
        this.EventCreationTime = EventCreationTime;
        this.Provision = Provision;
        this.LineStatuses = LineStatuses;
        this.PhoneAssignmentToEdgeType = PhoneAssignmentToEdgeType;
        this.Edge = Edge;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }







    /// <summary>
    /// Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London
    /// </summary>
    /// <value>Event Creation Time represents an ISO-8601 string. For example: UTC, UTC+01:00, or Europe/London</value>
    [DataMember(Name = "eventCreationTime", EmitDefaultValue = false)]
    public string EventCreationTime { get; set; }



    /// <summary>
    /// Provision information for this phone
    /// </summary>
    /// <value>Provision information for this phone</value>
    [DataMember(Name = "provision", EmitDefaultValue = false)]
    public ProvisionInfo Provision { get; set; }



    /// <summary>
    /// A list of LineStatus information for each of the lines of this phone
    /// </summary>
    /// <value>A list of LineStatus information for each of the lines of this phone</value>
    [DataMember(Name = "lineStatuses", EmitDefaultValue = false)]
    public List<LineStatus> LineStatuses { get; set; }





    /// <summary>
    /// The URI of the edge that provided this status information.
    /// </summary>
    /// <value>The URI of the edge that provided this status information.</value>
    [DataMember(Name = "edge", EmitDefaultValue = false)]
    public DomainEntityRef Edge { get; set; }



    /// <summary>
    /// The URI for this object. Deprecated. Do not use.
    /// </summary>
    /// <value>The URI for this object. Deprecated. Do not use.</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
        sb.Append("  EdgesStatus: ").Append(EdgesStatus).Append("\n");
        sb.Append("  EventCreationTime: ").Append(EventCreationTime).Append("\n");
        sb.Append("  Provision: ").Append(Provision).Append("\n");
        sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
        sb.Append("  PhoneAssignmentToEdgeType: ").Append(PhoneAssignmentToEdgeType).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
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
        return Equals(obj as PhoneStatus);
    }

    /// <summary>
    /// Returns true if PhoneStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneStatus other)
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
                OperationalStatus == other.OperationalStatus ||
                OperationalStatus != null &&
                OperationalStatus.Equals(other.OperationalStatus)
            ) &&
            (
                EdgesStatus == other.EdgesStatus ||
                EdgesStatus != null &&
                EdgesStatus.Equals(other.EdgesStatus)
            ) &&
            (
                EventCreationTime == other.EventCreationTime ||
                EventCreationTime != null &&
                EventCreationTime.Equals(other.EventCreationTime)
            ) &&
            (
                Provision == other.Provision ||
                Provision != null &&
                Provision.Equals(other.Provision)
            ) &&
            (
                LineStatuses == other.LineStatuses ||
                LineStatuses != null &&
                LineStatuses.SequenceEqual(other.LineStatuses)
            ) &&
            (
                PhoneAssignmentToEdgeType == other.PhoneAssignmentToEdgeType ||
                PhoneAssignmentToEdgeType != null &&
                PhoneAssignmentToEdgeType.Equals(other.PhoneAssignmentToEdgeType)
            ) &&
            (
                Edge == other.Edge ||
                Edge != null &&
                Edge.Equals(other.Edge)
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

            if (OperationalStatus != null)
            {
                hash = hash * 59 + OperationalStatus.GetHashCode();
            }

            if (EdgesStatus != null)
            {
                hash = hash * 59 + EdgesStatus.GetHashCode();
            }

            if (EventCreationTime != null)
            {
                hash = hash * 59 + EventCreationTime.GetHashCode();
            }

            if (Provision != null)
            {
                hash = hash * 59 + Provision.GetHashCode();
            }

            if (LineStatuses != null)
            {
                hash = hash * 59 + LineStatuses.GetHashCode();
            }

            if (PhoneAssignmentToEdgeType != null)
            {
                hash = hash * 59 + PhoneAssignmentToEdgeType.GetHashCode();
            }

            if (Edge != null)
            {
                hash = hash * 59 + Edge.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
