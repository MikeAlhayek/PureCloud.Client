using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonRulePredicate
/// </summary>

public partial class CommonRulePredicate : IEquatable<CommonRulePredicate>
{
    /// <summary>
    /// The type of metric being evaluated.
    /// </summary>
    /// <value>The type of metric being evaluated.</value>
    
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
    /// The type of metric value being evaluated.
    /// </summary>
    /// <value>The type of metric value being evaluated.</value>
    
    public enum MetricValueTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Count for "Count"
        /// </summary>
        [EnumMember(Value = "Count")]
        Count,

        /// <summary>
        /// Enum Min for "Min"
        /// </summary>
        [EnumMember(Value = "Min")]
        Min,

        /// <summary>
        /// Enum Timer for "Timer"
        /// </summary>
        [EnumMember(Value = "Timer")]
        Timer,

        /// <summary>
        /// Enum Max for "Max"
        /// </summary>
        [EnumMember(Value = "Max")]
        Max,

        /// <summary>
        /// Enum Percentage for "Percentage"
        /// </summary>
        [EnumMember(Value = "Percentage")]
        Percentage,

        /// <summary>
        /// Enum Average for "Average"
        /// </summary>
        [EnumMember(Value = "Average")]
        Average,

        /// <summary>
        /// Enum Observation for "Observation"
        /// </summary>
        [EnumMember(Value = "Observation")]
        Observation
    }
    /// <summary>
    /// The comparison operator being performed on the metric.
    /// </summary>
    /// <value>The comparison operator being performed on the metric.</value>
    
    public enum ComparisonOperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Gt for "Gt"
        /// </summary>
        [EnumMember(Value = "Gt")]
        Gt,

        /// <summary>
        /// Enum Gte for "Gte"
        /// </summary>
        [EnumMember(Value = "Gte")]
        Gte,

        /// <summary>
        /// Enum Lt for "Lt"
        /// </summary>
        [EnumMember(Value = "Lt")]
        Lt,

        /// <summary>
        /// Enum Lte for "Lte"
        /// </summary>
        [EnumMember(Value = "Lte")]
        Lte,

        /// <summary>
        /// Enum Eq for "Eq"
        /// </summary>
        [EnumMember(Value = "Eq")]
        Eq,

        /// <summary>
        /// Enum Ne for "Ne"
        /// </summary>
        [EnumMember(Value = "Ne")]
        Ne
    }
    /// <summary>
    /// The media type of the conversation the metric describes.
    /// </summary>
    /// <value>The media type of the conversation the metric describes.</value>
    
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
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message
    }
    /// <summary>
    /// The metric being evaluated.
    /// </summary>
    /// <value>The metric being evaluated.</value>
    
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
        /// Enum Nabandon for "nAbandon"
        /// </summary>
        [EnumMember(Value = "nAbandon")]
        Nabandon,

        /// <summary>
        /// Enum Nconnected for "nConnected"
        /// </summary>
        [EnumMember(Value = "nConnected")]
        Nconnected,

        /// <summary>
        /// Enum Ninteractions for "nInteractions"
        /// </summary>
        [EnumMember(Value = "nInteractions")]
        Ninteractions,

        /// <summary>
        /// Enum Noffered for "nOffered"
        /// </summary>
        [EnumMember(Value = "nOffered")]
        Noffered,

        /// <summary>
        /// Enum Noutbound for "nOutbound"
        /// </summary>
        [EnumMember(Value = "nOutbound")]
        Noutbound,

        /// <summary>
        /// Enum Ntransferred for "nTransferred"
        /// </summary>
        [EnumMember(Value = "nTransferred")]
        Ntransferred,

        /// <summary>
        /// Enum Servicelevel for "serviceLevel"
        /// </summary>
        [EnumMember(Value = "serviceLevel")]
        Servicelevel,

        /// <summary>
        /// Enum Oservicelevel for "oServiceLevel"
        /// </summary>
        [EnumMember(Value = "oServiceLevel")]
        Oservicelevel,

        /// <summary>
        /// Enum Owaiting for "oWaiting"
        /// </summary>
        [EnumMember(Value = "oWaiting")]
        Owaiting,

        /// <summary>
        /// Enum Tabandon for "tAbandon"
        /// </summary>
        [EnumMember(Value = "tAbandon")]
        Tabandon,

        /// <summary>
        /// Enum Tacw for "tAcw"
        /// </summary>
        [EnumMember(Value = "tAcw")]
        Tacw,

        /// <summary>
        /// Enum Talert for "tAlert"
        /// </summary>
        [EnumMember(Value = "tAlert")]
        Talert,

        /// <summary>
        /// Enum Tanswered for "tAnswered"
        /// </summary>
        [EnumMember(Value = "tAnswered")]
        Tanswered,

        /// <summary>
        /// Enum Thandle for "tHandle"
        /// </summary>
        [EnumMember(Value = "tHandle")]
        Thandle,

        /// <summary>
        /// Enum Theldcomplete for "tHeldComplete"
        /// </summary>
        [EnumMember(Value = "tHeldComplete")]
        Theldcomplete,

        /// <summary>
        /// Enum Ttalkcomplete for "tTalkComplete"
        /// </summary>
        [EnumMember(Value = "tTalkComplete")]
        Ttalkcomplete,

        /// <summary>
        /// Enum Twait for "tWait"
        /// </summary>
        [EnumMember(Value = "tWait")]
        Twait,

        /// <summary>
        /// Enum Ttalk for "tTalk"
        /// </summary>
        [EnumMember(Value = "tTalk")]
        Ttalk,

        /// <summary>
        /// Enum Theld for "tHeld"
        /// </summary>
        [EnumMember(Value = "tHeld")]
        Theld,

        /// <summary>
        /// Enum Torganizationpresence for "tOrganizationPresence"
        /// </summary>
        [EnumMember(Value = "tOrganizationPresence")]
        Torganizationpresence,

        /// <summary>
        /// Enum Tsystempresence for "tSystemPresence"
        /// </summary>
        [EnumMember(Value = "tSystemPresence")]
        Tsystempresence,

        /// <summary>
        /// Enum Tagentroutingstatus for "tAgentRoutingStatus"
        /// </summary>
        [EnumMember(Value = "tAgentRoutingStatus")]
        Tagentroutingstatus,

        /// <summary>
        /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
        /// </summary>
        [EnumMember(Value = "oUserRoutingStatuses")]
        Ouserroutingstatuses,

        /// <summary>
        /// Enum Ouserpresences for "oUserPresences"
        /// </summary>
        [EnumMember(Value = "oUserPresences")]
        Ouserpresences,

        /// <summary>
        /// Enum Ointeracting for "oInteracting"
        /// </summary>
        [EnumMember(Value = "oInteracting")]
        Ointeracting,

        /// <summary>
        /// Enum Tflowout for "tFlowOut"
        /// </summary>
        [EnumMember(Value = "tFlowOut")]
        Tflowout,

        /// <summary>
        /// Enum Tadherencestatus for "tAdherenceStatus"
        /// </summary>
        [EnumMember(Value = "tAdherenceStatus")]
        Tadherencestatus,

        /// <summary>
        /// Enum Nevents for "nEvents"
        /// </summary>
        [EnumMember(Value = "nEvents")]
        Nevents
    }
    /// <summary>
    /// The type of metric being evaluated.
    /// </summary>
    /// <value>The type of metric being evaluated.</value>
    [JsonPropertyName("metricType")]
    public MetricTypeEnum? MetricType { get; set; }
    /// <summary>
    /// The type of metric value being evaluated.
    /// </summary>
    /// <value>The type of metric value being evaluated.</value>
    [JsonPropertyName("metricValueType")]
    public MetricValueTypeEnum? MetricValueType { get; set; }
    /// <summary>
    /// The comparison operator being performed on the metric.
    /// </summary>
    /// <value>The comparison operator being performed on the metric.</value>
    [JsonPropertyName("comparisonOperator")]
    public ComparisonOperatorEnum? ComparisonOperator { get; set; }
    /// <summary>
    /// The media type of the conversation the metric describes.
    /// </summary>
    /// <value>The media type of the conversation the metric describes.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// The metric being evaluated.
    /// </summary>
    /// <value>The metric being evaluated.</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRulePredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonRulePredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRulePredicate" /> class.
    /// </summary>
    /// <param name="MetricType">The type of metric being evaluated. (required).</param>
    /// <param name="MetricValueType">The type of metric value being evaluated. (required).</param>
    /// <param name="ComparisonOperator">The comparison operator being performed on the metric. (required).</param>
    /// <param name="Value">The value the metric will be compared to. (required).</param>
    /// <param name="Status">The status of the entity corresponding to the metric..</param>
    /// <param name="Topic">The operational console topic corresponding to the metric..</param>
    /// <param name="Entity">The entity whose metric is being represented. (required).</param>
    /// <param name="MediaType">The media type of the conversation the metric describes..</param>
    /// <param name="Metric">The metric being evaluated. (required).</param>
    public CommonRulePredicate(MetricTypeEnum? MetricType = null, MetricValueTypeEnum? MetricValueType = null, ComparisonOperatorEnum? ComparisonOperator = null, double? Value = null, string Status = null, string Topic = null, CommonRulePredicateEntity Entity = null, MediaTypeEnum? MediaType = null, MetricEnum? Metric = null)
    {
        this.MetricType = MetricType;
        this.MetricValueType = MetricValueType;
        this.ComparisonOperator = ComparisonOperator;
        this.Value = Value;
        this.Status = Status;
        this.Topic = Topic;
        this.Entity = Entity;
        this.MediaType = MediaType;
        this.Metric = Metric;

    }









    /// <summary>
    /// The value the metric will be compared to.
    /// </summary>
    /// <value>The value the metric will be compared to.</value>
    [JsonPropertyName("value")]
    public double? Value { get; set; }



    /// <summary>
    /// The status of the entity corresponding to the metric.
    /// </summary>
    /// <value>The status of the entity corresponding to the metric.</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }



    /// <summary>
    /// The operational console topic corresponding to the metric.
    /// </summary>
    /// <value>The operational console topic corresponding to the metric.</value>
    [JsonPropertyName("topic")]
    public string Topic { get; set; }



    /// <summary>
    /// The entity whose metric is being represented.
    /// </summary>
    /// <value>The entity whose metric is being represented.</value>
    [JsonPropertyName("entity")]
    public CommonRulePredicateEntity Entity { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonRulePredicate {\n");

        sb.Append("  MetricType: ").Append(MetricType).Append("\n");
        sb.Append("  MetricValueType: ").Append(MetricValueType).Append("\n");
        sb.Append("  ComparisonOperator: ").Append(ComparisonOperator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Topic: ").Append(Topic).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
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
        return Equals(obj as CommonRulePredicate);
    }

    /// <summary>
    /// Returns true if CommonRulePredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonRulePredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonRulePredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MetricType == other.MetricType ||
                MetricType != null &&
                MetricType.Equals(other.MetricType)
            ) &&
            (
                MetricValueType == other.MetricValueType ||
                MetricValueType != null &&
                MetricValueType.Equals(other.MetricValueType)
            ) &&
            (
                ComparisonOperator == other.ComparisonOperator ||
                ComparisonOperator != null &&
                ComparisonOperator.Equals(other.ComparisonOperator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Topic == other.Topic ||
                Topic != null &&
                Topic.Equals(other.Topic)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
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
            if (MetricType != null)
            {
                hash = hash * 59 + MetricType.GetHashCode();
            }

            if (MetricValueType != null)
            {
                hash = hash * 59 + MetricValueType.GetHashCode();
            }

            if (ComparisonOperator != null)
            {
                hash = hash * 59 + ComparisonOperator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Topic != null)
            {
                hash = hash * 59 + Topic.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            return hash;
        }
    }
}
