using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotification
/// </summary>

public partial class WfmUserNotification : IEquatable<WfmUserNotification>
{
    /// <summary>
    /// The type of this notification
    /// </summary>
    /// <value>The type of this notification</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Adherenceexplanation for "AdherenceExplanation"
        /// </summary>
        [EnumMember(Value = "AdherenceExplanation")]
        Adherenceexplanation,

        /// <summary>
        /// Enum Shifttrade for "ShiftTrade"
        /// </summary>
        [EnumMember(Value = "ShiftTrade")]
        Shifttrade,

        /// <summary>
        /// Enum Timeoffrequest for "TimeOffRequest"
        /// </summary>
        [EnumMember(Value = "TimeOffRequest")]
        Timeoffrequest,

        /// <summary>
        /// Enum Alternativeshift for "AlternativeShift"
        /// </summary>
        [EnumMember(Value = "AlternativeShift")]
        Alternativeshift
    }
    /// <summary>
    /// The type of this notification
    /// </summary>
    /// <value>The type of this notification</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotification" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmUserNotification() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotification" /> class.
    /// </summary>
    /// <param name="Id">The immutable globally unique identifier for the object. (required).</param>
    /// <param name="MutableGroupId">The group ID of the notification (mutable, may change  on update) (required).</param>
    /// <param name="MarkedAsRead">Whether this notification has been marked \&quot;read\&quot; (required).</param>
    public WfmUserNotification(string Id = null, string MutableGroupId = null, bool? MarkedAsRead = null)
    {
        this.Id = Id;
        this.MutableGroupId = MutableGroupId;
        this.MarkedAsRead = MarkedAsRead;

    }



    /// <summary>
    /// The immutable globally unique identifier for the object.
    /// </summary>
    /// <value>The immutable globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The group ID of the notification (mutable, may change  on update)
    /// </summary>
    /// <value>The group ID of the notification (mutable, may change  on update)</value>
    [JsonPropertyName("mutableGroupId")]
    public string MutableGroupId { get; set; }



    /// <summary>
    /// The timestamp for this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp for this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; private set; }





    /// <summary>
    /// A shift trade notification.  Only set if type &#x3D;&#x3D; ShiftTrade
    /// </summary>
    /// <value>A shift trade notification.  Only set if type &#x3D;&#x3D; ShiftTrade</value>
    [JsonPropertyName("shiftTrade")]
    public ShiftTradeNotification ShiftTrade { get; private set; }



    /// <summary>
    /// A time off request notification.  Only set if type &#x3D;&#x3D; TimeOffRequest
    /// </summary>
    /// <value>A time off request notification.  Only set if type &#x3D;&#x3D; TimeOffRequest</value>
    [JsonPropertyName("timeOffRequest")]
    public TimeOffRequestNotification TimeOffRequest { get; private set; }



    /// <summary>
    /// An adherence explanation notification.  Only set if type &#x3D;&#x3D; AdherenceExplanation
    /// </summary>
    /// <value>An adherence explanation notification.  Only set if type &#x3D;&#x3D; AdherenceExplanation</value>
    [JsonPropertyName("adherenceExplanation")]
    public AdherenceExplanationNotification AdherenceExplanation { get; private set; }



    /// <summary>
    /// An alternative shift trade notification.  Only set if type &#x3D;&#x3D; AlternativeShift
    /// </summary>
    /// <value>An alternative shift trade notification.  Only set if type &#x3D;&#x3D; AlternativeShift</value>
    [JsonPropertyName("alternativeShift")]
    public AlternativeShiftNotification AlternativeShift { get; private set; }



    /// <summary>
    /// Whether this notification has been marked \&quot;read\&quot;
    /// </summary>
    /// <value>Whether this notification has been marked \&quot;read\&quot;</value>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }



    /// <summary>
    /// Whether this notification is for an agent
    /// </summary>
    /// <value>Whether this notification is for an agent</value>
    [JsonPropertyName("agentNotification")]
    public bool? AgentNotification { get; private set; }



    /// <summary>
    /// Other notification IDs in group.  This field is only populated in real-time notifications
    /// </summary>
    /// <value>Other notification IDs in group.  This field is only populated in real-time notifications</value>
    [JsonPropertyName("otherNotificationIdsInGroup")]
    public List<string> OtherNotificationIdsInGroup { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MutableGroupId: ").Append(MutableGroupId).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ShiftTrade: ").Append(ShiftTrade).Append("\n");
        sb.Append("  TimeOffRequest: ").Append(TimeOffRequest).Append("\n");
        sb.Append("  AdherenceExplanation: ").Append(AdherenceExplanation).Append("\n");
        sb.Append("  AlternativeShift: ").Append(AlternativeShift).Append("\n");
        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
        sb.Append("  AgentNotification: ").Append(AgentNotification).Append("\n");
        sb.Append("  OtherNotificationIdsInGroup: ").Append(OtherNotificationIdsInGroup).Append("\n");
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
        return Equals(obj as WfmUserNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotification other)
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
                MutableGroupId == other.MutableGroupId ||
                MutableGroupId != null &&
                MutableGroupId.Equals(other.MutableGroupId)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ShiftTrade == other.ShiftTrade ||
                ShiftTrade != null &&
                ShiftTrade.Equals(other.ShiftTrade)
            ) &&
            (
                TimeOffRequest == other.TimeOffRequest ||
                TimeOffRequest != null &&
                TimeOffRequest.Equals(other.TimeOffRequest)
            ) &&
            (
                AdherenceExplanation == other.AdherenceExplanation ||
                AdherenceExplanation != null &&
                AdherenceExplanation.Equals(other.AdherenceExplanation)
            ) &&
            (
                AlternativeShift == other.AlternativeShift ||
                AlternativeShift != null &&
                AlternativeShift.Equals(other.AlternativeShift)
            ) &&
            (
                MarkedAsRead == other.MarkedAsRead ||
                MarkedAsRead != null &&
                MarkedAsRead.Equals(other.MarkedAsRead)
            ) &&
            (
                AgentNotification == other.AgentNotification ||
                AgentNotification != null &&
                AgentNotification.Equals(other.AgentNotification)
            ) &&
            (
                OtherNotificationIdsInGroup == other.OtherNotificationIdsInGroup ||
                OtherNotificationIdsInGroup != null &&
                OtherNotificationIdsInGroup.SequenceEqual(other.OtherNotificationIdsInGroup)
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

            if (MutableGroupId != null)
            {
                hash = hash * 59 + MutableGroupId.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ShiftTrade != null)
            {
                hash = hash * 59 + ShiftTrade.GetHashCode();
            }

            if (TimeOffRequest != null)
            {
                hash = hash * 59 + TimeOffRequest.GetHashCode();
            }

            if (AdherenceExplanation != null)
            {
                hash = hash * 59 + AdherenceExplanation.GetHashCode();
            }

            if (AlternativeShift != null)
            {
                hash = hash * 59 + AlternativeShift.GetHashCode();
            }

            if (MarkedAsRead != null)
            {
                hash = hash * 59 + MarkedAsRead.GetHashCode();
            }

            if (AgentNotification != null)
            {
                hash = hash * 59 + AgentNotification.GetHashCode();
            }

            if (OtherNotificationIdsInGroup != null)
            {
                hash = hash * 59 + OtherNotificationIdsInGroup.GetHashCode();
            }

            return hash;
        }
    }
}
