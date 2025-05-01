using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TeamActivityQueryMetric
/// </summary>
[DataContract]
public partial class TeamActivityQueryMetric : IEquatable<TeamActivityQueryMetric>
{
    /// <summary>
    /// The requested metric
    /// </summary>
    /// <value>The requested metric</value>
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
        /// Enum Oteamoffqueueusers for "oTeamOffQueueUsers"
        /// </summary>
        [EnumMember(Value = "oTeamOffQueueUsers")]
        Oteamoffqueueusers,

        /// <summary>
        /// Enum Oteamonqueueusers for "oTeamOnQueueUsers"
        /// </summary>
        [EnumMember(Value = "oTeamOnQueueUsers")]
        Oteamonqueueusers,

        /// <summary>
        /// Enum Oteampresences for "oTeamPresences"
        /// </summary>
        [EnumMember(Value = "oTeamPresences")]
        Oteampresences,

        /// <summary>
        /// Enum Oteamroutingstatuses for "oTeamRoutingStatuses"
        /// </summary>
        [EnumMember(Value = "oTeamRoutingStatuses")]
        Oteamroutingstatuses
    }
    /// <summary>
    /// The requested metric
    /// </summary>
    /// <value>The requested metric</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public MetricEnum? Metric { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TeamActivityQueryMetric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TeamActivityQueryMetric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamActivityQueryMetric" /> class.
    /// </summary>
    /// <param name="Metric">The requested metric (required).</param>
    /// <param name="Details">Flag for including observation details for this metric in the response.</param>
    public TeamActivityQueryMetric(MetricEnum? Metric = null, bool? Details = null)
    {
        this.Metric = Metric;
        this.Details = Details;

    }





    /// <summary>
    /// Flag for including observation details for this metric in the response
    /// </summary>
    /// <value>Flag for including observation details for this metric in the response</value>
    [DataMember(Name = "details", EmitDefaultValue = false)]
    public bool? Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamActivityQueryMetric {\n");

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
        return this.Equals(obj as TeamActivityQueryMetric);
    }

    /// <summary>
    /// Returns true if TeamActivityQueryMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of TeamActivityQueryMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamActivityQueryMetric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Metric == other.Metric ||
                this.Metric != null &&
                this.Metric.Equals(other.Metric)
            ) &&
            (
                this.Details == other.Details ||
                this.Details != null &&
                this.Details.Equals(other.Details)
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
            if (this.Metric != null)
            {
                hash = hash * 59 + this.Metric.GetHashCode();
            }

            if (this.Details != null)
            {
                hash = hash * 59 + this.Details.GetHashCode();
            }

            return hash;
        }
    }
}
