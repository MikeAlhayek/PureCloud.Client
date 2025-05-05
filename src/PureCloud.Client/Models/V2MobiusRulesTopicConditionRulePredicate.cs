using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusRulesTopicConditionRulePredicate
/// </summary>

public partial class V2MobiusRulesTopicConditionRulePredicate : IEquatable<V2MobiusRulesTopicConditionRulePredicate>
{
    /// <summary>
    /// Gets or Sets MetricType
    /// </summary>
    
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
        Instance,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets MetricValueType
    /// </summary>
    
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
        /// Enum Timer for "Timer"
        /// </summary>
        [EnumMember(Value = "Timer")]
        Timer,

        /// <summary>
        /// Enum Observation for "Observation"
        /// </summary>
        [EnumMember(Value = "Observation")]
        Observation,

        /// <summary>
        /// Enum Min for "Min"
        /// </summary>
        [EnumMember(Value = "Min")]
        Min,

        /// <summary>
        /// Enum Max for "Max"
        /// </summary>
        [EnumMember(Value = "Max")]
        Max,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
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
        Message,

        /// <summary>
        /// Enum Screenshare for "Screenshare"
        /// </summary>
        [EnumMember(Value = "Screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Cobrowse for "Cobrowse"
        /// </summary>
        [EnumMember(Value = "Cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets ComparisonOperator
    /// </summary>
    
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
        Ne,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets MetricType
    /// </summary>
    [JsonPropertyName("metricType")]
    public MetricTypeEnum? MetricType { get; set; }
    /// <summary>
    /// Gets or Sets MetricValueType
    /// </summary>
    [JsonPropertyName("metricValueType")]
    public MetricValueTypeEnum? MetricValueType { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Gets or Sets ComparisonOperator
    /// </summary>
    [JsonPropertyName("comparisonOperator")]
    public ComparisonOperatorEnum? ComparisonOperator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusRulesTopicConditionRulePredicate" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Entity">Entity.</param>
    /// <param name="Metric">Metric.</param>
    /// <param name="MetricType">MetricType.</param>
    /// <param name="MetricValueType">MetricValueType.</param>
    /// <param name="Value">Value.</param>
    /// <param name="Status">Status.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="Topic">Topic.</param>
    /// <param name="ComparisonOperator">ComparisonOperator.</param>
    public V2MobiusRulesTopicConditionRulePredicate(Guid? Id = null, V2MobiusRulesTopicEntityProperties Entity = null, string Metric = null, MetricTypeEnum? MetricType = null, MetricValueTypeEnum? MetricValueType = null, double? Value = null, string Status = null, MediaTypeEnum? MediaType = null, string Topic = null, ComparisonOperatorEnum? ComparisonOperator = null)
    {
        this.Id = Id;
        this.Entity = Entity;
        this.Metric = Metric;
        this.MetricType = MetricType;
        this.MetricValueType = MetricValueType;
        this.Value = Value;
        this.Status = Status;
        this.MediaType = MediaType;
        this.Topic = Topic;
        this.ComparisonOperator = ComparisonOperator;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets Entity
    /// </summary>
    [JsonPropertyName("entity")]
    public V2MobiusRulesTopicEntityProperties Entity { get; set; }



    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [JsonPropertyName("metric")]
    public string Metric { get; set; }







    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }





    /// <summary>
    /// Gets or Sets Topic
    /// </summary>
    [JsonPropertyName("topic")]
    public string Topic { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusRulesTopicConditionRulePredicate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  MetricType: ").Append(MetricType).Append("\n");
        sb.Append("  MetricValueType: ").Append(MetricValueType).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Topic: ").Append(Topic).Append("\n");
        sb.Append("  ComparisonOperator: ").Append(ComparisonOperator).Append("\n");
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
        return Equals(obj as V2MobiusRulesTopicConditionRulePredicate);
    }

    /// <summary>
    /// Returns true if V2MobiusRulesTopicConditionRulePredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusRulesTopicConditionRulePredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusRulesTopicConditionRulePredicate other)
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
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
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
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Topic == other.Topic ||
                Topic != null &&
                Topic.Equals(other.Topic)
            ) &&
            (
                ComparisonOperator == other.ComparisonOperator ||
                ComparisonOperator != null &&
                ComparisonOperator.Equals(other.ComparisonOperator)
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

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (MetricType != null)
            {
                hash = hash * 59 + MetricType.GetHashCode();
            }

            if (MetricValueType != null)
            {
                hash = hash * 59 + MetricValueType.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Topic != null)
            {
                hash = hash * 59 + Topic.GetHashCode();
            }

            if (ComparisonOperator != null)
            {
                hash = hash * 59 + ComparisonOperator.GetHashCode();
            }

            return hash;
        }
    }
}
