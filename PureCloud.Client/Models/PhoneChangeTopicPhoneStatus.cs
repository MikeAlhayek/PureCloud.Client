using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneChangeTopicPhoneStatus
/// </summary>

public partial class PhoneChangeTopicPhoneStatus : IEquatable<PhoneChangeTopicPhoneStatus>
{
    /// <summary>
    /// Gets or Sets OperationalStatus
    /// </summary>
    
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
        Offline
    }
    /// <summary>
    /// Gets or Sets OperationalStatus
    /// </summary>
    [JsonPropertyName("operationalStatus")]
    public OperationalStatusEnum? OperationalStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneChangeTopicPhoneStatus" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="OperationalStatus">OperationalStatus.</param>
    /// <param name="Edge">Edge.</param>
    /// <param name="Provision">Provision.</param>
    /// <param name="LineStatuses">LineStatuses.</param>
    /// <param name="EventCreationTime">EventCreationTime.</param>
    public PhoneChangeTopicPhoneStatus(string Id = null, OperationalStatusEnum? OperationalStatus = null, PhoneChangeTopicEdgeReference Edge = null, PhoneChangeTopicProvisionInfo Provision = null, List<PhoneChangeTopicLineStatus> LineStatuses = null, DateTime? EventCreationTime = null)
    {
        this.Id = Id;
        this.OperationalStatus = OperationalStatus;
        this.Edge = Edge;
        this.Provision = Provision;
        this.LineStatuses = LineStatuses;
        this.EventCreationTime = EventCreationTime;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    [JsonPropertyName("edge")]
    public PhoneChangeTopicEdgeReference Edge { get; set; }



    /// <summary>
    /// Gets or Sets Provision
    /// </summary>
    [JsonPropertyName("provision")]
    public PhoneChangeTopicProvisionInfo Provision { get; set; }



    /// <summary>
    /// Gets or Sets LineStatuses
    /// </summary>
    [JsonPropertyName("lineStatuses")]
    public List<PhoneChangeTopicLineStatus> LineStatuses { get; set; }



    /// <summary>
    /// Gets or Sets EventCreationTime
    /// </summary>
    [JsonPropertyName("eventCreationTime")]
    public DateTime? EventCreationTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneChangeTopicPhoneStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  Provision: ").Append(Provision).Append("\n");
        sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
        sb.Append("  EventCreationTime: ").Append(EventCreationTime).Append("\n");
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
        return Equals(obj as PhoneChangeTopicPhoneStatus);
    }

    /// <summary>
    /// Returns true if PhoneChangeTopicPhoneStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneChangeTopicPhoneStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneChangeTopicPhoneStatus other)
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
                Edge == other.Edge ||
                Edge != null &&
                Edge.Equals(other.Edge)
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
                EventCreationTime == other.EventCreationTime ||
                EventCreationTime != null &&
                EventCreationTime.Equals(other.EventCreationTime)
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

            if (Edge != null)
            {
                hash = hash * 59 + Edge.GetHashCode();
            }

            if (Provision != null)
            {
                hash = hash * 59 + Provision.GetHashCode();
            }

            if (LineStatuses != null)
            {
                hash = hash * 59 + LineStatuses.GetHashCode();
            }

            if (EventCreationTime != null)
            {
                hash = hash * 59 + EventCreationTime.GetHashCode();
            }

            return hash;
        }
    }
}
