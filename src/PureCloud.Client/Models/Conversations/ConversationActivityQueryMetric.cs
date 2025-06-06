using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationActivityQueryMetric
/// </summary>

public partial class ConversationActivityQueryMetric : IEquatable<ConversationActivityQueryMetric>
{
    /// <summary>
    /// The requested metric
    /// </summary>
    /// <value>The requested metric</value>
    
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
    /// The requested metric
    /// </summary>
    /// <value>The requested metric</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationActivityQueryMetric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationActivityQueryMetric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationActivityQueryMetric" /> class.
    /// </summary>
    /// <param name="Metric">The requested metric (required).</param>
    /// <param name="Details">Flag for including observation details for this metric in the response.</param>
    public ConversationActivityQueryMetric(MetricEnum? Metric = null, bool? Details = null)
    {
        this.Metric = Metric;
        this.Details = Details;

    }





    /// <summary>
    /// Flag for including observation details for this metric in the response
    /// </summary>
    /// <value>Flag for including observation details for this metric in the response</value>
    [JsonPropertyName("details")]
    public bool? Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationActivityQueryMetric {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
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
        return Equals(obj as ConversationActivityQueryMetric);
    }

    /// <summary>
    /// Returns true if ConversationActivityQueryMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationActivityQueryMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationActivityQueryMetric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.Equals(other.Details)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            return hash;
        }
    }
}
