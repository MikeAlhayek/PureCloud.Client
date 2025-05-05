using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsConversationSegment
/// </summary>

public partial class AnalyticsConversationSegment : IEquatable<AnalyticsConversationSegment>
{
    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    
    public enum DisconnectTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Client for "client"
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// Enum Conferencetransfer for "conferenceTransfer"
        /// </summary>
        [EnumMember(Value = "conferenceTransfer")]
        Conferencetransfer,

        /// <summary>
        /// Enum Consulttransfer for "consultTransfer"
        /// </summary>
        [EnumMember(Value = "consultTransfer")]
        Consulttransfer,

        /// <summary>
        /// Enum Dndendpoint for "dndEndpoint"
        /// </summary>
        [EnumMember(Value = "dndEndpoint")]
        Dndendpoint,

        /// <summary>
        /// Enum Dndtransfer for "dndTransfer"
        /// </summary>
        [EnumMember(Value = "dndTransfer")]
        Dndtransfer,

        /// <summary>
        /// Enum Endpoint for "endpoint"
        /// </summary>
        [EnumMember(Value = "endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Forwardtransfer for "forwardTransfer"
        /// </summary>
        [EnumMember(Value = "forwardTransfer")]
        Forwardtransfer,

        /// <summary>
        /// Enum Noanswertransfer for "noAnswerTransfer"
        /// </summary>
        [EnumMember(Value = "noAnswerTransfer")]
        Noanswertransfer,

        /// <summary>
        /// Enum Notavailabletransfer for "notAvailableTransfer"
        /// </summary>
        [EnumMember(Value = "notAvailableTransfer")]
        Notavailabletransfer,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Spam for "spam"
        /// </summary>
        [EnumMember(Value = "spam")]
        Spam,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum Transportfailure for "transportFailure"
        /// </summary>
        [EnumMember(Value = "transportFailure")]
        Transportfailure,

        /// <summary>
        /// Enum Uncallable for "uncallable"
        /// </summary>
        [EnumMember(Value = "uncallable")]
        Uncallable
    }
    /// <summary>
    /// The activity that takes place in the segment, such as hold or interact
    /// </summary>
    /// <value>The activity that takes place in the segment, such as hold or interact</value>
    
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
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// The activity that takes place in the segment, such as hold or interact
    /// </summary>
    /// <value>The activity that takes place in the segment, such as hold or interact</value>
    [JsonPropertyName("segmentType")]
    public SegmentTypeEnum? SegmentType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsConversationSegment" /> class.
    /// </summary>
    /// <param name="AudioMuted">Flag indicating if audio is muted or not (true/false).</param>
    /// <param name="Conference">Indicates whether the segment was a conference.</param>
    /// <param name="DestinationConversationId">The unique identifier of a new conversation when a conversation is ended for a conference.</param>
    /// <param name="DestinationSessionId">The unique identifier of a new session when a session is ended for a conference.</param>
    /// <param name="DisconnectType">The session disconnect type.</param>
    /// <param name="ErrorCode">A code corresponding to the error that occurred.</param>
    /// <param name="GroupId">Unique identifier for a Genesys Cloud group.</param>
    /// <param name="Q850ResponseCodes">Q.850 response code(s).</param>
    /// <param name="QueueId">Queue identifier.</param>
    /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
    /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
    /// <param name="RequestedRoutingUserIds">Unique identifier(s) for agent(s) requested for an interaction.</param>
    /// <param name="SegmentEnd">The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SegmentStart">The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SegmentType">The activity that takes place in the segment, such as hold or interact.</param>
    /// <param name="SipResponseCodes">SIP response code(s).</param>
    /// <param name="SourceConversationId">The unique identifier of the previous conversation when a new conversation is created for a conference.</param>
    /// <param name="SourceSessionId">The unique identifier of the previous session when a new session is created for a conference.</param>
    /// <param name="Subject">The subject for the initial email that started this conversation.</param>
    /// <param name="VideoMuted">Flag indicating if video is muted/paused or not (true/false).</param>
    /// <param name="WrapUpCode">Wrap up code.</param>
    /// <param name="WrapUpNote">Note entered by an agent during after-call work.</param>
    /// <param name="WrapUpTags">Tag(s) assigned during after-call work.</param>
    /// <param name="ScoredAgents">Scored agents.</param>
    /// <param name="Properties">Additional segment properties.</param>
    public AnalyticsConversationSegment(bool? AudioMuted = null, bool? Conference = null, string DestinationConversationId = null, string DestinationSessionId = null, DisconnectTypeEnum? DisconnectType = null, string ErrorCode = null, string GroupId = null, List<long?> Q850ResponseCodes = null, string QueueId = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<string> RequestedRoutingUserIds = null, DateTime? SegmentEnd = null, DateTime? SegmentStart = null, SegmentTypeEnum? SegmentType = null, List<long?> SipResponseCodes = null, string SourceConversationId = null, string SourceSessionId = null, string Subject = null, bool? VideoMuted = null, string WrapUpCode = null, string WrapUpNote = null, List<string> WrapUpTags = null, List<AnalyticsScoredAgent> ScoredAgents = null, List<AnalyticsProperty> Properties = null)
    {
        this.AudioMuted = AudioMuted;
        this.Conference = Conference;
        this.DestinationConversationId = DestinationConversationId;
        this.DestinationSessionId = DestinationSessionId;
        this.DisconnectType = DisconnectType;
        this.ErrorCode = ErrorCode;
        this.GroupId = GroupId;
        this.Q850ResponseCodes = Q850ResponseCodes;
        this.QueueId = QueueId;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedRoutingUserIds = RequestedRoutingUserIds;
        this.SegmentEnd = SegmentEnd;
        this.SegmentStart = SegmentStart;
        this.SegmentType = SegmentType;
        this.SipResponseCodes = SipResponseCodes;
        this.SourceConversationId = SourceConversationId;
        this.SourceSessionId = SourceSessionId;
        this.Subject = Subject;
        this.VideoMuted = VideoMuted;
        this.WrapUpCode = WrapUpCode;
        this.WrapUpNote = WrapUpNote;
        this.WrapUpTags = WrapUpTags;
        this.ScoredAgents = ScoredAgents;
        this.Properties = Properties;

    }



    /// <summary>
    /// Flag indicating if audio is muted or not (true/false)
    /// </summary>
    /// <value>Flag indicating if audio is muted or not (true/false)</value>
    [JsonPropertyName("audioMuted")]
    public bool? AudioMuted { get; set; }



    /// <summary>
    /// Indicates whether the segment was a conference
    /// </summary>
    /// <value>Indicates whether the segment was a conference</value>
    [JsonPropertyName("conference")]
    public bool? Conference { get; set; }



    /// <summary>
    /// The unique identifier of a new conversation when a conversation is ended for a conference
    /// </summary>
    /// <value>The unique identifier of a new conversation when a conversation is ended for a conference</value>
    [JsonPropertyName("destinationConversationId")]
    public string DestinationConversationId { get; set; }



    /// <summary>
    /// The unique identifier of a new session when a session is ended for a conference
    /// </summary>
    /// <value>The unique identifier of a new session when a session is ended for a conference</value>
    [JsonPropertyName("destinationSessionId")]
    public string DestinationSessionId { get; set; }





    /// <summary>
    /// A code corresponding to the error that occurred
    /// </summary>
    /// <value>A code corresponding to the error that occurred</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Unique identifier for a Genesys Cloud group
    /// </summary>
    /// <value>Unique identifier for a Genesys Cloud group</value>
    [JsonPropertyName("groupId")]
    public string GroupId { get; set; }



    /// <summary>
    /// Q.850 response code(s)
    /// </summary>
    /// <value>Q.850 response code(s)</value>
    [JsonPropertyName("q850ResponseCodes")]
    public List<long?> Q850ResponseCodes { get; set; }



    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    [JsonPropertyName("requestedLanguageId")]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    [JsonPropertyName("requestedRoutingSkillIds")]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Unique identifier(s) for agent(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for agent(s) requested for an interaction</value>
    [JsonPropertyName("requestedRoutingUserIds")]
    public List<string> RequestedRoutingUserIds { get; set; }



    /// <summary>
    /// The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("segmentEnd")]
    public DateTime? SegmentEnd { get; set; }



    /// <summary>
    /// The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of a segment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("segmentStart")]
    public DateTime? SegmentStart { get; set; }





    /// <summary>
    /// SIP response code(s)
    /// </summary>
    /// <value>SIP response code(s)</value>
    [JsonPropertyName("sipResponseCodes")]
    public List<long?> SipResponseCodes { get; set; }



    /// <summary>
    /// The unique identifier of the previous conversation when a new conversation is created for a conference
    /// </summary>
    /// <value>The unique identifier of the previous conversation when a new conversation is created for a conference</value>
    [JsonPropertyName("sourceConversationId")]
    public string SourceConversationId { get; set; }



    /// <summary>
    /// The unique identifier of the previous session when a new session is created for a conference
    /// </summary>
    /// <value>The unique identifier of the previous session when a new session is created for a conference</value>
    [JsonPropertyName("sourceSessionId")]
    public string SourceSessionId { get; set; }



    /// <summary>
    /// The subject for the initial email that started this conversation
    /// </summary>
    /// <value>The subject for the initial email that started this conversation</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// Flag indicating if video is muted/paused or not (true/false)
    /// </summary>
    /// <value>Flag indicating if video is muted/paused or not (true/false)</value>
    [JsonPropertyName("videoMuted")]
    public bool? VideoMuted { get; set; }



    /// <summary>
    /// Wrap up code
    /// </summary>
    /// <value>Wrap up code</value>
    [JsonPropertyName("wrapUpCode")]
    public string WrapUpCode { get; set; }



    /// <summary>
    /// Note entered by an agent during after-call work
    /// </summary>
    /// <value>Note entered by an agent during after-call work</value>
    [JsonPropertyName("wrapUpNote")]
    public string WrapUpNote { get; set; }



    /// <summary>
    /// Tag(s) assigned during after-call work
    /// </summary>
    /// <value>Tag(s) assigned during after-call work</value>
    [JsonPropertyName("wrapUpTags")]
    public List<string> WrapUpTags { get; set; }



    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    [JsonPropertyName("scoredAgents")]
    public List<AnalyticsScoredAgent> ScoredAgents { get; set; }



    /// <summary>
    /// Additional segment properties
    /// </summary>
    /// <value>Additional segment properties</value>
    [JsonPropertyName("properties")]
    public List<AnalyticsProperty> Properties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsConversationSegment {\n");

        sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
        sb.Append("  Conference: ").Append(Conference).Append("\n");
        sb.Append("  DestinationConversationId: ").Append(DestinationConversationId).Append("\n");
        sb.Append("  DestinationSessionId: ").Append(DestinationSessionId).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  Q850ResponseCodes: ").Append(Q850ResponseCodes).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedRoutingUserIds: ").Append(RequestedRoutingUserIds).Append("\n");
        sb.Append("  SegmentEnd: ").Append(SegmentEnd).Append("\n");
        sb.Append("  SegmentStart: ").Append(SegmentStart).Append("\n");
        sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
        sb.Append("  SipResponseCodes: ").Append(SipResponseCodes).Append("\n");
        sb.Append("  SourceConversationId: ").Append(SourceConversationId).Append("\n");
        sb.Append("  SourceSessionId: ").Append(SourceSessionId).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
        sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
        sb.Append("  WrapUpNote: ").Append(WrapUpNote).Append("\n");
        sb.Append("  WrapUpTags: ").Append(WrapUpTags).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
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
        return Equals(obj as AnalyticsConversationSegment);
    }

    /// <summary>
    /// Returns true if AnalyticsConversationSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsConversationSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsConversationSegment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AudioMuted == other.AudioMuted ||
                AudioMuted != null &&
                AudioMuted.Equals(other.AudioMuted)
            ) &&
            (
                Conference == other.Conference ||
                Conference != null &&
                Conference.Equals(other.Conference)
            ) &&
            (
                DestinationConversationId == other.DestinationConversationId ||
                DestinationConversationId != null &&
                DestinationConversationId.Equals(other.DestinationConversationId)
            ) &&
            (
                DestinationSessionId == other.DestinationSessionId ||
                DestinationSessionId != null &&
                DestinationSessionId.Equals(other.DestinationSessionId)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                GroupId == other.GroupId ||
                GroupId != null &&
                GroupId.Equals(other.GroupId)
            ) &&
            (
                Q850ResponseCodes == other.Q850ResponseCodes ||
                Q850ResponseCodes != null &&
                Q850ResponseCodes.SequenceEqual(other.Q850ResponseCodes)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                RequestedLanguageId == other.RequestedLanguageId ||
                RequestedLanguageId != null &&
                RequestedLanguageId.Equals(other.RequestedLanguageId)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
            ) &&
            (
                RequestedRoutingUserIds == other.RequestedRoutingUserIds ||
                RequestedRoutingUserIds != null &&
                RequestedRoutingUserIds.SequenceEqual(other.RequestedRoutingUserIds)
            ) &&
            (
                SegmentEnd == other.SegmentEnd ||
                SegmentEnd != null &&
                SegmentEnd.Equals(other.SegmentEnd)
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
                SipResponseCodes == other.SipResponseCodes ||
                SipResponseCodes != null &&
                SipResponseCodes.SequenceEqual(other.SipResponseCodes)
            ) &&
            (
                SourceConversationId == other.SourceConversationId ||
                SourceConversationId != null &&
                SourceConversationId.Equals(other.SourceConversationId)
            ) &&
            (
                SourceSessionId == other.SourceSessionId ||
                SourceSessionId != null &&
                SourceSessionId.Equals(other.SourceSessionId)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                VideoMuted == other.VideoMuted ||
                VideoMuted != null &&
                VideoMuted.Equals(other.VideoMuted)
            ) &&
            (
                WrapUpCode == other.WrapUpCode ||
                WrapUpCode != null &&
                WrapUpCode.Equals(other.WrapUpCode)
            ) &&
            (
                WrapUpNote == other.WrapUpNote ||
                WrapUpNote != null &&
                WrapUpNote.Equals(other.WrapUpNote)
            ) &&
            (
                WrapUpTags == other.WrapUpTags ||
                WrapUpTags != null &&
                WrapUpTags.SequenceEqual(other.WrapUpTags)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
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
            if (AudioMuted != null)
            {
                hash = hash * 59 + AudioMuted.GetHashCode();
            }

            if (Conference != null)
            {
                hash = hash * 59 + Conference.GetHashCode();
            }

            if (DestinationConversationId != null)
            {
                hash = hash * 59 + DestinationConversationId.GetHashCode();
            }

            if (DestinationSessionId != null)
            {
                hash = hash * 59 + DestinationSessionId.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (GroupId != null)
            {
                hash = hash * 59 + GroupId.GetHashCode();
            }

            if (Q850ResponseCodes != null)
            {
                hash = hash * 59 + Q850ResponseCodes.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedRoutingUserIds != null)
            {
                hash = hash * 59 + RequestedRoutingUserIds.GetHashCode();
            }

            if (SegmentEnd != null)
            {
                hash = hash * 59 + SegmentEnd.GetHashCode();
            }

            if (SegmentStart != null)
            {
                hash = hash * 59 + SegmentStart.GetHashCode();
            }

            if (SegmentType != null)
            {
                hash = hash * 59 + SegmentType.GetHashCode();
            }

            if (SipResponseCodes != null)
            {
                hash = hash * 59 + SipResponseCodes.GetHashCode();
            }

            if (SourceConversationId != null)
            {
                hash = hash * 59 + SourceConversationId.GetHashCode();
            }

            if (SourceSessionId != null)
            {
                hash = hash * 59 + SourceSessionId.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (VideoMuted != null)
            {
                hash = hash * 59 + VideoMuted.GetHashCode();
            }

            if (WrapUpCode != null)
            {
                hash = hash * 59 + WrapUpCode.GetHashCode();
            }

            if (WrapUpNote != null)
            {
                hash = hash * 59 + WrapUpNote.GetHashCode();
            }

            if (WrapUpTags != null)
            {
                hash = hash * 59 + WrapUpTags.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            return hash;
        }
    }
}
