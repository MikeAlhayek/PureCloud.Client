using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ObservationValue
/// </summary>

public partial class ObservationValue : IEquatable<ObservationValue>
{
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    
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
    /// Gets or Sets RequestedRoutings
    /// </summary>
    
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
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [JsonPropertyName("usedRouting")]
    public UsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ObservationValue" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ObservationValue() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ObservationValue" /> class.
    /// </summary>
    /// <param name="ObservationDate">The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">Unique identifier for the conversation.</param>
    /// <param name="SessionId">The unique identifier of this session.</param>
    /// <param name="RequestedRoutingSkillIds">Unique identifier for a skill requested for an interaction.</param>
    /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
    /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
    /// <param name="ParticipantName">A human readable name identifying the participant.</param>
    /// <param name="UserId">Unique identifier for the user.</param>
    /// <param name="Direction">The direction of the communication.</param>
    /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
    /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
    /// <param name="AddressFrom">The address that initiated an action.</param>
    /// <param name="AddressTo">The address receiving an action.</param>
    /// <param name="Ani">Automatic Number Identification (caller&#39;s number).</param>
    /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
    /// <param name="TeamId">The team id the user is a member of.</param>
    /// <param name="RequestedRoutings">All routing types for requested/attempted routing methods.</param>
    /// <param name="UsedRouting">Complete routing method.</param>
    /// <param name="ScoredAgents">ScoredAgents.</param>
    public ObservationValue(DateTime? ObservationDate = null, string ConversationId = null, string SessionId = null, List<string> RequestedRoutingSkillIds = null, string RequestedLanguageId = null, long? RoutingPriority = null, string ParticipantName = null, string UserId = null, DirectionEnum? Direction = null, string ConvertedFrom = null, string ConvertedTo = null, string AddressFrom = null, string AddressTo = null, string Ani = null, string Dnis = null, string TeamId = null, List<RequestedRoutingsEnum> RequestedRoutings = null, UsedRoutingEnum? UsedRouting = null, List<AnalyticsScoredAgent> ScoredAgents = null)
    {
        this.ObservationDate = ObservationDate;
        this.ConversationId = ConversationId;
        this.SessionId = SessionId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RoutingPriority = RoutingPriority;
        this.ParticipantName = ParticipantName;
        this.UserId = UserId;
        this.Direction = Direction;
        this.ConvertedFrom = ConvertedFrom;
        this.ConvertedTo = ConvertedTo;
        this.AddressFrom = AddressFrom;
        this.AddressTo = AddressTo;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.TeamId = TeamId;
        this.RequestedRoutings = RequestedRoutings;
        this.UsedRouting = UsedRouting;
        this.ScoredAgents = ScoredAgents;

    }



    /// <summary>
    /// The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the observation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("observationDate")]
    public DateTime? ObservationDate { get; set; }



    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// Unique identifier for a skill requested for an interaction
    /// </summary>
    /// <value>Unique identifier for a skill requested for an interaction</value>
    [JsonPropertyName("requestedRoutingSkillIds")]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    [JsonPropertyName("requestedLanguageId")]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    [JsonPropertyName("routingPriority")]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    [JsonPropertyName("participantName")]
    public string ParticipantName { get; set; }



    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }





    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    [JsonPropertyName("convertedFrom")]
    public string ConvertedFrom { get; set; }



    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    [JsonPropertyName("convertedTo")]
    public string ConvertedTo { get; set; }



    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    [JsonPropertyName("addressFrom")]
    public string AddressFrom { get; set; }



    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    [JsonPropertyName("addressTo")]
    public string AddressTo { get; set; }



    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// The team id the user is a member of
    /// </summary>
    /// <value>The team id the user is a member of</value>
    [JsonPropertyName("teamId")]
    public string TeamId { get; set; }



    /// <summary>
    /// All routing types for requested/attempted routing methods
    /// </summary>
    /// <value>All routing types for requested/attempted routing methods</value>
    [JsonPropertyName("requestedRoutings")]
    public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }





    /// <summary>
    /// Gets or Sets ScoredAgents
    /// </summary>
    [JsonPropertyName("scoredAgents")]
    public List<AnalyticsScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ObservationValue {\n");

        sb.Append("  ObservationDate: ").Append(ObservationDate).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
        sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
        sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
        sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
        sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
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
        return Equals(obj as ObservationValue);
    }

    /// <summary>
    /// Returns true if ObservationValue instances are equal
    /// </summary>
    /// <param name="other">Instance of ObservationValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ObservationValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ObservationDate == other.ObservationDate ||
                ObservationDate != null &&
                ObservationDate.Equals(other.ObservationDate)
            ) &&
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
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                ParticipantName == other.ParticipantName ||
                ParticipantName != null &&
                ParticipantName.Equals(other.ParticipantName)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
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
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                RequestedRoutings == other.RequestedRoutings ||
                RequestedRoutings != null &&
                RequestedRoutings.SequenceEqual(other.RequestedRoutings)
            ) &&
            (
                UsedRouting == other.UsedRouting ||
                UsedRouting != null &&
                UsedRouting.Equals(other.UsedRouting)
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
            if (ObservationDate != null)
            {
                hash = hash * 59 + ObservationDate.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (ParticipantName != null)
            {
                hash = hash * 59 + ParticipantName.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (ConvertedFrom != null)
            {
                hash = hash * 59 + ConvertedFrom.GetHashCode();
            }

            if (ConvertedTo != null)
            {
                hash = hash * 59 + ConvertedTo.GetHashCode();
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

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (RequestedRoutings != null)
            {
                hash = hash * 59 + RequestedRoutings.GetHashCode();
            }

            if (UsedRouting != null)
            {
                hash = hash * 59 + UsedRouting.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
