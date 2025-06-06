using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlertSummary
/// </summary>

public partial class AlertSummary : IEquatable<AlertSummary>
{
    /// <summary>
    /// The metric type that is monitored.
    /// </summary>
    /// <value>The metric type that is monitored.</value>
    
    public enum MetricTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Interval for "Interval"
        /// </summary>
        [EnumMember(Value = "Interval")]
        Interval,

        /// <summary>
        /// Enum Instance for "Instance"
        /// </summary>
        [EnumMember(Value = "Instance")]
        Instance
    }
    /// <summary>
    /// The metric type that is monitored.
    /// </summary>
    /// <value>The metric type that is monitored.</value>
    [JsonPropertyName("metricType")]
    public MetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlertSummary" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlertSummary() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlertSummary" /> class.
    /// </summary>
    /// <param name="Entities">The entities who violated the rule condition over the duration of the alert. (required).</param>
    /// <param name="Conversation">The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics..</param>
    /// <param name="MetricType">The metric type that is monitored. (required).</param>
    /// <param name="EntitiesAreTeamMembers">Flag that indicated whether or not the alert is for a rule with a condition for all members of a team. (required).</param>
    public AlertSummary(List<AlertSummaryEntity> Entities = null, AddressableEntityRef Conversation = null, MetricTypeEnum? MetricType = null, bool? EntitiesAreTeamMembers = null)
    {
        this.Entities = Entities;
        this.Conversation = Conversation;
        this.MetricType = MetricType;
        this.EntitiesAreTeamMembers = EntitiesAreTeamMembers;

    }



    /// <summary>
    /// The entities who violated the rule condition over the duration of the alert.
    /// </summary>
    /// <value>The entities who violated the rule condition over the duration of the alert.</value>
    [JsonPropertyName("entities")]
    public List<AlertSummaryEntity> Entities { get; set; }



    /// <summary>
    /// The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics.
    /// </summary>
    /// <value>The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics.</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }





    /// <summary>
    /// Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.
    /// </summary>
    /// <value>Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.</value>
    [JsonPropertyName("entitiesAreTeamMembers")]
    public bool? EntitiesAreTeamMembers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlertSummary {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  MetricType: ").Append(MetricType).Append("\n");
        sb.Append("  EntitiesAreTeamMembers: ").Append(EntitiesAreTeamMembers).Append("\n");
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
        return Equals(obj as AlertSummary);
    }

    /// <summary>
    /// Returns true if AlertSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of AlertSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlertSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                MetricType == other.MetricType ||
                MetricType != null &&
                MetricType.Equals(other.MetricType)
            ) &&
            (
                EntitiesAreTeamMembers == other.EntitiesAreTeamMembers ||
                EntitiesAreTeamMembers != null &&
                EntitiesAreTeamMembers.Equals(other.EntitiesAreTeamMembers)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (MetricType != null)
            {
                hash = hash * 59 + MetricType.GetHashCode();
            }

            if (EntitiesAreTeamMembers != null)
            {
                hash = hash * 59 + EntitiesAreTeamMembers.GetHashCode();
            }

            return hash;
        }
    }
}
