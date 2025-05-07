using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Objective
/// </summary>

public partial class Objective : IEquatable<Objective>
{
    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    
    public enum MediaTypesEnum
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
    /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
    /// </summary>
    /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
    
    public enum TopicIdsFilterTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum And for "and"
        /// </summary>
        [EnumMember(Value = "and")]
        And,

        /// <summary>
        /// Enum Or for "or"
        /// </summary>
        [EnumMember(Value = "or")]
        Or
    }
    /// <summary>
    /// The initial direction to filter on
    /// </summary>
    /// <value>The initial direction to filter on</value>
    
    public enum InitialDirectionEnum
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
    /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
    /// </summary>
    /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
    [JsonPropertyName("topicIdsFilterType")]
    public TopicIdsFilterTypeEnum? TopicIdsFilterType { get; set; }
    /// <summary>
    /// The initial direction to filter on
    /// </summary>
    /// <value>The initial direction to filter on</value>
    [JsonPropertyName("initialDirection")]
    public InitialDirectionEnum? InitialDirection { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Objective" /> class.
    /// </summary>
    /// <param name="TemplateId">The id of this objective&#39;s base template.</param>
    /// <param name="Zones">Objective zone specifies min,max points and values for the associated metric.</param>
    /// <param name="Enabled">A flag for whether this objective is enabled for the related metric.</param>
    /// <param name="MediaTypes">A list of media types for the metric.</param>
    /// <param name="Queues">A list of queues for the metric.</param>
    /// <param name="Topics">A list of topic ids for detected topic metrics.</param>
    /// <param name="TopicIdsFilterType">A filter type for topic Ids. It&#39;s only used for objectives with topicIds. Default filter behavior is \&quot;or\&quot;..</param>
    /// <param name="EvaluationFormContextIds">The ids of associated evaluation form context, for Quality Evaluation Score metrics.</param>
    /// <param name="InitialDirection">The initial direction to filter on.</param>
    /// <param name="DateStart">start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public Objective(string TemplateId = null, List<ObjectiveZone> Zones = null, bool? Enabled = null, List<MediaTypesEnum> MediaTypes = null, List<AddressableEntityRef> Queues = null, List<AddressableEntityRef> Topics = null, TopicIdsFilterTypeEnum? TopicIdsFilterType = null, List<string> EvaluationFormContextIds = null, InitialDirectionEnum? InitialDirection = null, string DateStart = null)
    {
        this.TemplateId = TemplateId;
        this.Zones = Zones;
        this.Enabled = Enabled;
        this.MediaTypes = MediaTypes;
        this.Queues = Queues;
        this.Topics = Topics;
        this.TopicIdsFilterType = TopicIdsFilterType;
        this.EvaluationFormContextIds = EvaluationFormContextIds;
        this.InitialDirection = InitialDirection;
        this.DateStart = DateStart;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The id of this objective&#39;s base template
    /// </summary>
    /// <value>The id of this objective&#39;s base template</value>
    [JsonPropertyName("templateId")]
    public string TemplateId { get; set; }



    /// <summary>
    /// Objective zone specifies min,max points and values for the associated metric
    /// </summary>
    /// <value>Objective zone specifies min,max points and values for the associated metric</value>
    [JsonPropertyName("zones")]
    public List<ObjectiveZone> Zones { get; set; }



    /// <summary>
    /// A flag for whether this objective is enabled for the related metric
    /// </summary>
    /// <value>A flag for whether this objective is enabled for the related metric</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// A list of media types for the metric
    /// </summary>
    /// <value>A list of media types for the metric</value>
    [JsonPropertyName("mediaTypes")]
    public List<MediaTypesEnum> MediaTypes { get; set; }



    /// <summary>
    /// A list of queues for the metric
    /// </summary>
    /// <value>A list of queues for the metric</value>
    [JsonPropertyName("queues")]
    public List<AddressableEntityRef> Queues { get; set; }



    /// <summary>
    /// A list of topic ids for detected topic metrics
    /// </summary>
    /// <value>A list of topic ids for detected topic metrics</value>
    [JsonPropertyName("topics")]
    public List<AddressableEntityRef> Topics { get; set; }





    /// <summary>
    /// The ids of associated evaluation form context, for Quality Evaluation Score metrics
    /// </summary>
    /// <value>The ids of associated evaluation form context, for Quality Evaluation Score metrics</value>
    [JsonPropertyName("evaluationFormContextIds")]
    public List<string> EvaluationFormContextIds { get; set; }





    /// <summary>
    /// start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStart")]
    public string DateStart { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Objective {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
        sb.Append("  Zones: ").Append(Zones).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  Topics: ").Append(Topics).Append("\n");
        sb.Append("  TopicIdsFilterType: ").Append(TopicIdsFilterType).Append("\n");
        sb.Append("  EvaluationFormContextIds: ").Append(EvaluationFormContextIds).Append("\n");
        sb.Append("  InitialDirection: ").Append(InitialDirection).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
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
        return Equals(obj as Objective);
    }

    /// <summary>
    /// Returns true if Objective instances are equal
    /// </summary>
    /// <param name="other">Instance of Objective to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Objective other)
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
                TemplateId == other.TemplateId ||
                TemplateId != null &&
                TemplateId.Equals(other.TemplateId)
            ) &&
            (
                Zones == other.Zones ||
                Zones != null &&
                Zones.SequenceEqual(other.Zones)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
            ) &&
            (
                Topics == other.Topics ||
                Topics != null &&
                Topics.SequenceEqual(other.Topics)
            ) &&
            (
                TopicIdsFilterType == other.TopicIdsFilterType ||
                TopicIdsFilterType != null &&
                TopicIdsFilterType.Equals(other.TopicIdsFilterType)
            ) &&
            (
                EvaluationFormContextIds == other.EvaluationFormContextIds ||
                EvaluationFormContextIds != null &&
                EvaluationFormContextIds.SequenceEqual(other.EvaluationFormContextIds)
            ) &&
            (
                InitialDirection == other.InitialDirection ||
                InitialDirection != null &&
                InitialDirection.Equals(other.InitialDirection)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
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

            if (TemplateId != null)
            {
                hash = hash * 59 + TemplateId.GetHashCode();
            }

            if (Zones != null)
            {
                hash = hash * 59 + Zones.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (Topics != null)
            {
                hash = hash * 59 + Topics.GetHashCode();
            }

            if (TopicIdsFilterType != null)
            {
                hash = hash * 59 + TopicIdsFilterType.GetHashCode();
            }

            if (EvaluationFormContextIds != null)
            {
                hash = hash * 59 + EvaluationFormContextIds.GetHashCode();
            }

            if (InitialDirection != null)
            {
                hash = hash * 59 + InitialDirection.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            return hash;
        }
    }
}
