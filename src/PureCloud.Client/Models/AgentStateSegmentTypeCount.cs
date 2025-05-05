using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentStateSegmentTypeCount
/// </summary>

public partial class AgentStateSegmentTypeCount : IEquatable<AgentStateSegmentTypeCount>
{
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    
    public enum SegmentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alert for "alert"
        /// </summary>
        [EnumMember(Value = "alert")]
        Alert,

        /// <summary>
        /// Enum Barging for "barging"
        /// </summary>
        [EnumMember(Value = "barging")]
        Barging,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Coaching for "coaching"
        /// </summary>
        [EnumMember(Value = "coaching")]
        Coaching,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Delay for "delay"
        /// </summary>
        [EnumMember(Value = "delay")]
        Delay,

        /// <summary>
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Hold for "hold"
        /// </summary>
        [EnumMember(Value = "hold")]
        Hold,

        /// <summary>
        /// Enum Interact for "interact"
        /// </summary>
        [EnumMember(Value = "interact")]
        Interact,

        /// <summary>
        /// Enum Ivr for "ivr"
        /// </summary>
        [EnumMember(Value = "ivr")]
        Ivr,

        /// <summary>
        /// Enum Monitoring for "monitoring"
        /// </summary>
        [EnumMember(Value = "monitoring")]
        Monitoring,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked,

        /// <summary>
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Sharing for "sharing"
        /// </summary>
        [EnumMember(Value = "sharing")]
        Sharing,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Wrapup for "wrapup"
        /// </summary>
        [EnumMember(Value = "wrapup")]
        Wrapup
    }
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    [JsonPropertyName("segmentType")]
    public SegmentTypeEnum? SegmentType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentStateSegmentTypeCount" /> class.
    /// </summary>
    /// <param name="SegmentType">Segment type.</param>
    /// <param name="Count">Count of segment type.</param>
    public AgentStateSegmentTypeCount(SegmentTypeEnum? SegmentType = null, int? Count = null)
    {
        this.SegmentType = SegmentType;
        this.Count = Count;

    }





    /// <summary>
    /// Count of segment type
    /// </summary>
    /// <value>Count of segment type</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentStateSegmentTypeCount {\n");

        sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as AgentStateSegmentTypeCount);
    }

    /// <summary>
    /// Returns true if AgentStateSegmentTypeCount instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentStateSegmentTypeCount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentStateSegmentTypeCount other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SegmentType == other.SegmentType ||
                SegmentType != null &&
                SegmentType.Equals(other.SegmentType)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (SegmentType != null)
            {
                hash = hash * 59 + SegmentType.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
