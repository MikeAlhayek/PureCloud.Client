using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsAgentStateAgentSessionResult
/// </summary>
[DataContract]
public partial class AnalyticsAgentStateAgentSessionResult : IEquatable<AnalyticsAgentStateAgentSessionResult>
{
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Originating direction
    /// </summary>
    /// <value>Originating direction</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OriginatingDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaTypeEnum
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
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "cobrowse"
        /// </summary>
        [EnumMember(Value = "cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Internalmessage for "internalmessage"
        /// </summary>
        [EnumMember(Value = "internalmessage")]
        Internalmessage,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message,

        /// <summary>
        /// Enum Screenshare for "screenshare"
        /// </summary>
        [EnumMember(Value = "screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Video for "video"
        /// </summary>
        [EnumMember(Value = "video")]
        Video,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice
    }
    /// <summary>
    /// Segment type
    /// </summary>
    /// <value>Segment type</value>
    [DataMember(Name = "segmentType", EmitDefaultValue = false)]
    public SegmentTypeEnum? SegmentType { get; set; }
    /// <summary>
    /// Originating direction
    /// </summary>
    /// <value>Originating direction</value>
    [DataMember(Name = "originatingDirection", EmitDefaultValue = false)]
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }
    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsAgentStateAgentSessionResult" /> class.
    /// </summary>
    /// <param name="ConversationId">Conversation Id.</param>
    /// <param name="SessionId">Session Id.</param>
    /// <param name="SessionStart">Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SegmentStart">Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SegmentType">Segment type.</param>
    /// <param name="RoutedQueueId">Routed queue Id.</param>
    /// <param name="RequestedRoutingSkillIds">List of requested routing skill Id.</param>
    /// <param name="RequestedLanguageId">Requested language Id.</param>
    /// <param name="OriginatingDirection">Originating direction.</param>
    /// <param name="MediaType">Media type.</param>
    public AnalyticsAgentStateAgentSessionResult(string ConversationId = null, string SessionId = null, DateTime? SessionStart = null, DateTime? SegmentStart = null, SegmentTypeEnum? SegmentType = null, string RoutedQueueId = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, OriginatingDirectionEnum? OriginatingDirection = null, MediaTypeEnum? MediaType = null)
    {
        this.ConversationId = ConversationId;
        this.SessionId = SessionId;
        this.SessionStart = SessionStart;
        this.SegmentStart = SegmentStart;
        this.SegmentType = SegmentType;
        this.RoutedQueueId = RoutedQueueId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedLanguageId = RequestedLanguageId;
        this.OriginatingDirection = OriginatingDirection;
        this.MediaType = MediaType;

    }



    /// <summary>
    /// Conversation Id
    /// </summary>
    /// <value>Conversation Id</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Session Id
    /// </summary>
    /// <value>Session Id</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Session start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "sessionStart", EmitDefaultValue = false)]
    public DateTime? SessionStart { get; set; }



    /// <summary>
    /// Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Segment start datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "segmentStart", EmitDefaultValue = false)]
    public DateTime? SegmentStart { get; set; }





    /// <summary>
    /// Routed queue Id
    /// </summary>
    /// <value>Routed queue Id</value>
    [DataMember(Name = "routedQueueId", EmitDefaultValue = false)]
    public string RoutedQueueId { get; set; }



    /// <summary>
    /// List of requested routing skill Id
    /// </summary>
    /// <value>List of requested routing skill Id</value>
    [DataMember(Name = "requestedRoutingSkillIds", EmitDefaultValue = false)]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Requested language Id
    /// </summary>
    /// <value>Requested language Id</value>
    [DataMember(Name = "requestedLanguageId", EmitDefaultValue = false)]
    public string RequestedLanguageId { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsAgentStateAgentSessionResult {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  SessionStart: ").Append(SessionStart).Append("\n");
        sb.Append("  SegmentStart: ").Append(SegmentStart).Append("\n");
        sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
        sb.Append("  RoutedQueueId: ").Append(RoutedQueueId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
        return Equals(obj as AnalyticsAgentStateAgentSessionResult);
    }

    /// <summary>
    /// Returns true if AnalyticsAgentStateAgentSessionResult instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsAgentStateAgentSessionResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsAgentStateAgentSessionResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                SessionStart == other.SessionStart ||
                SessionStart != null &&
                SessionStart.Equals(other.SessionStart)
            ) &&
            (
                SegmentStart == other.SegmentStart ||
                SegmentStart != null &&
                SegmentStart.Equals(other.SegmentStart)
            ) &&
            (
                SegmentType == other.SegmentType ||
                SegmentType != null &&
                SegmentType.Equals(other.SegmentType)
            ) &&
            (
                RoutedQueueId == other.RoutedQueueId ||
                RoutedQueueId != null &&
                RoutedQueueId.Equals(other.RoutedQueueId)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
            ) &&
            (
                RequestedLanguageId == other.RequestedLanguageId ||
                RequestedLanguageId != null &&
                RequestedLanguageId.Equals(other.RequestedLanguageId)
            ) &&
            (
                OriginatingDirection == other.OriginatingDirection ||
                OriginatingDirection != null &&
                OriginatingDirection.Equals(other.OriginatingDirection)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (SessionStart != null)
            {
                hash = hash * 59 + SessionStart.GetHashCode();
            }

            if (SegmentStart != null)
            {
                hash = hash * 59 + SegmentStart.GetHashCode();
            }

            if (SegmentType != null)
            {
                hash = hash * 59 + SegmentType.GetHashCode();
            }

            if (RoutedQueueId != null)
            {
                hash = hash * 59 + RoutedQueueId.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (OriginatingDirection != null)
            {
                hash = hash * 59 + OriginatingDirection.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            return hash;
        }
    }
}
