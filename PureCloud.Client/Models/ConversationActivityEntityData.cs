using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationActivityEntityData
/// </summary>
[DataContract]
public partial class ConversationActivityEntityData : IEquatable<ConversationActivityEntityData>
{
    /// <summary>
    /// Activity metric
    /// </summary>
    /// <value>Activity metric</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Oalerting for "oAlerting"
        /// </summary>
        [EnumMember(Value = "oAlerting")]
        Oalerting,

        /// <summary>
        /// Enum Ointeracting for "oInteracting"
        /// </summary>
        [EnumMember(Value = "oInteracting")]
        Ointeracting,

        /// <summary>
        /// Enum Owaiting for "oWaiting"
        /// </summary>
        [EnumMember(Value = "oWaiting")]
        Owaiting
    }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActiveRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DirectionEnum
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
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
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
    /// Gets or Sets RequestedRoutings
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequestedRoutingsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UsedRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Activity metric
    /// </summary>
    /// <value>Activity metric</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    [DataMember(Name = "activeRouting", EmitDefaultValue = false)]
    public ActiveRoutingEnum? ActiveRouting { get; set; }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [DataMember(Name = "usedRouting", EmitDefaultValue = false)]
    public UsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationActivityEntityData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationActivityEntityData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationActivityEntityData" /> class.
    /// </summary>
    /// <param name="ActivityDate">The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Metric">Activity metric.</param>
    /// <param name="ActiveRouting">Active routing method.</param>
    /// <param name="AddressFrom">The address that initiated an action.</param>
    /// <param name="AddressTo">The address receiving an action.</param>
    /// <param name="Ani">Automatic Number Identification (caller&#39;s number).</param>
    /// <param name="ConversationId">Unique identifier for the conversation.</param>
    /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
    /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
    /// <param name="Direction">The direction of the communication.</param>
    /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
    /// <param name="MediaType">The session media type.</param>
    /// <param name="ParticipantName">A human readable name identifying the participant.</param>
    /// <param name="QueueId">Queue identifier.</param>
    /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
    /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
    /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
    /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
    /// <param name="SessionId">The unique identifier of this session.</param>
    /// <param name="TeamId">The team ID the user is a member of.</param>
    /// <param name="UsedRouting">Complete routing method.</param>
    /// <param name="UserId">Unique identifier for the user.</param>
    /// <param name="ScoredAgents">Scored agents.</param>
    public ConversationActivityEntityData(DateTime? ActivityDate = null, MetricEnum? Metric = null, ActiveRoutingEnum? ActiveRouting = null, string AddressFrom = null, string AddressTo = null, string Ani = null, string ConversationId = null, string ConvertedFrom = null, string ConvertedTo = null, DirectionEnum? Direction = null, string Dnis = null, MediaTypeEnum? MediaType = null, string ParticipantName = null, string QueueId = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, long? RoutingPriority = null, string SessionId = null, string TeamId = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, List<ConversationActivityScoredAgent> ScoredAgents = null)
    {
        this.ActivityDate = ActivityDate;
        this.Metric = Metric;
        this.ActiveRouting = ActiveRouting;
        this.AddressFrom = AddressFrom;
        this.AddressTo = AddressTo;
        this.Ani = Ani;
        this.ConversationId = ConversationId;
        this.ConvertedFrom = ConvertedFrom;
        this.ConvertedTo = ConvertedTo;
        this.Direction = Direction;
        this.Dnis = Dnis;
        this.MediaType = MediaType;
        this.ParticipantName = ParticipantName;
        this.QueueId = QueueId;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedRoutings = RequestedRoutings;
        this.RoutingPriority = RoutingPriority;
        this.SessionId = SessionId;
        this.TeamId = TeamId;
        this.UsedRouting = UsedRouting;
        this.UserId = UserId;
        this.ScoredAgents = ScoredAgents;

    }



    /// <summary>
    /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "activityDate", EmitDefaultValue = false)]
    public DateTime? ActivityDate { get; set; }







    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    [DataMember(Name = "addressFrom", EmitDefaultValue = false)]
    public string AddressFrom { get; set; }



    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    [DataMember(Name = "addressTo", EmitDefaultValue = false)]
    public string AddressTo { get; set; }



    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    [DataMember(Name = "convertedFrom", EmitDefaultValue = false)]
    public string ConvertedFrom { get; set; }



    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    [DataMember(Name = "convertedTo", EmitDefaultValue = false)]
    public string ConvertedTo { get; set; }





    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }





    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    [DataMember(Name = "participantName", EmitDefaultValue = false)]
    public string ParticipantName { get; set; }



    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    [DataMember(Name = "requestedLanguageId", EmitDefaultValue = false)]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    [DataMember(Name = "requestedRoutingSkillIds", EmitDefaultValue = false)]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    [DataMember(Name = "requestedRoutings", EmitDefaultValue = false)]
    public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    [DataMember(Name = "routingPriority", EmitDefaultValue = false)]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }





    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<ConversationActivityScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationActivityEntityData {\n");

        sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  ActiveRouting: ").Append(ActiveRouting).Append("\n");
        sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
        sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
        sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
        return Equals(obj as ConversationActivityEntityData);
    }

    /// <summary>
    /// Returns true if ConversationActivityEntityData instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationActivityEntityData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationActivityEntityData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityDate == other.ActivityDate ||
                ActivityDate != null &&
                ActivityDate.Equals(other.ActivityDate)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                ActiveRouting == other.ActiveRouting ||
                ActiveRouting != null &&
                ActiveRouting.Equals(other.ActiveRouting)
            ) &&
            (
                AddressFrom == other.AddressFrom ||
                AddressFrom != null &&
                AddressFrom.Equals(other.AddressFrom)
            ) &&
            (
                AddressTo == other.AddressTo ||
                AddressTo != null &&
                AddressTo.Equals(other.AddressTo)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConvertedFrom == other.ConvertedFrom ||
                ConvertedFrom != null &&
                ConvertedFrom.Equals(other.ConvertedFrom)
            ) &&
            (
                ConvertedTo == other.ConvertedTo ||
                ConvertedTo != null &&
                ConvertedTo.Equals(other.ConvertedTo)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ParticipantName == other.ParticipantName ||
                ParticipantName != null &&
                ParticipantName.Equals(other.ParticipantName)
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
                RequestedRoutings == other.RequestedRoutings ||
                RequestedRoutings != null &&
                RequestedRoutings.SequenceEqual(other.RequestedRoutings)
            ) &&
            (
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                UsedRouting == other.UsedRouting ||
                UsedRouting != null &&
                UsedRouting.Equals(other.UsedRouting)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
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
            if (ActivityDate != null)
            {
                hash = hash * 59 + ActivityDate.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (ActiveRouting != null)
            {
                hash = hash * 59 + ActiveRouting.GetHashCode();
            }

            if (AddressFrom != null)
            {
                hash = hash * 59 + AddressFrom.GetHashCode();
            }

            if (AddressTo != null)
            {
                hash = hash * 59 + AddressTo.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConvertedFrom != null)
            {
                hash = hash * 59 + ConvertedFrom.GetHashCode();
            }

            if (ConvertedTo != null)
            {
                hash = hash * 59 + ConvertedTo.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ParticipantName != null)
            {
                hash = hash * 59 + ParticipantName.GetHashCode();
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

            if (RequestedRoutings != null)
            {
                hash = hash * 59 + RequestedRoutings.GetHashCode();
            }

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (UsedRouting != null)
            {
                hash = hash * 59 + UsedRouting.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
