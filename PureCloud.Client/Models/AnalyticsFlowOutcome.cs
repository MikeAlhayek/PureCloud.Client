using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsFlowOutcome
/// </summary>
[DataContract]
public partial class AnalyticsFlowOutcome : IEquatable<AnalyticsFlowOutcome>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsFlowOutcome" /> class.
    /// </summary>
    /// <param name="FlowOutcome">Combination of unique flow outcome identifier and its value separated by colon.</param>
    /// <param name="FlowOutcomeEndTimestamp">The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed..</param>
    /// <param name="FlowOutcomeId">Unique identifier of a flow outcome.</param>
    /// <param name="FlowOutcomeStartTimestamp">The outcome starting timestamp in ISO 8601 format.</param>
    /// <param name="FlowOutcomeValue">Flow outcome value, e.g. SUCCESS.</param>
    public AnalyticsFlowOutcome(string FlowOutcome = null, DateTime? FlowOutcomeEndTimestamp = null, string FlowOutcomeId = null, DateTime? FlowOutcomeStartTimestamp = null, string FlowOutcomeValue = null)
    {
        this.FlowOutcome = FlowOutcome;
        this.FlowOutcomeEndTimestamp = FlowOutcomeEndTimestamp;
        this.FlowOutcomeId = FlowOutcomeId;
        this.FlowOutcomeStartTimestamp = FlowOutcomeStartTimestamp;
        this.FlowOutcomeValue = FlowOutcomeValue;

    }



    /// <summary>
    /// Combination of unique flow outcome identifier and its value separated by colon
    /// </summary>
    /// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
    [DataMember(Name = "flowOutcome", EmitDefaultValue = false)]
    public string FlowOutcome { get; set; }



    /// <summary>
    /// The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.
    /// </summary>
    /// <value>The outcome ending timestamp in ISO 8601 format. This may be null if the outcome did not succeed.</value>
    [DataMember(Name = "flowOutcomeEndTimestamp", EmitDefaultValue = false)]
    public DateTime? FlowOutcomeEndTimestamp { get; set; }



    /// <summary>
    /// Unique identifier of a flow outcome
    /// </summary>
    /// <value>Unique identifier of a flow outcome</value>
    [DataMember(Name = "flowOutcomeId", EmitDefaultValue = false)]
    public string FlowOutcomeId { get; set; }



    /// <summary>
    /// The outcome starting timestamp in ISO 8601 format
    /// </summary>
    /// <value>The outcome starting timestamp in ISO 8601 format</value>
    [DataMember(Name = "flowOutcomeStartTimestamp", EmitDefaultValue = false)]
    public DateTime? FlowOutcomeStartTimestamp { get; set; }



    /// <summary>
    /// Flow outcome value, e.g. SUCCESS
    /// </summary>
    /// <value>Flow outcome value, e.g. SUCCESS</value>
    [DataMember(Name = "flowOutcomeValue", EmitDefaultValue = false)]
    public string FlowOutcomeValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsFlowOutcome {\n");

        sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
        sb.Append("  FlowOutcomeEndTimestamp: ").Append(FlowOutcomeEndTimestamp).Append("\n");
        sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
        sb.Append("  FlowOutcomeStartTimestamp: ").Append(FlowOutcomeStartTimestamp).Append("\n");
        sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
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
        return Equals(obj as AnalyticsFlowOutcome);
    }

    /// <summary>
    /// Returns true if AnalyticsFlowOutcome instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsFlowOutcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsFlowOutcome other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowOutcome == other.FlowOutcome ||
                FlowOutcome != null &&
                FlowOutcome.Equals(other.FlowOutcome)
            ) &&
            (
                FlowOutcomeEndTimestamp == other.FlowOutcomeEndTimestamp ||
                FlowOutcomeEndTimestamp != null &&
                FlowOutcomeEndTimestamp.Equals(other.FlowOutcomeEndTimestamp)
            ) &&
            (
                FlowOutcomeId == other.FlowOutcomeId ||
                FlowOutcomeId != null &&
                FlowOutcomeId.Equals(other.FlowOutcomeId)
            ) &&
            (
                FlowOutcomeStartTimestamp == other.FlowOutcomeStartTimestamp ||
                FlowOutcomeStartTimestamp != null &&
                FlowOutcomeStartTimestamp.Equals(other.FlowOutcomeStartTimestamp)
            ) &&
            (
                FlowOutcomeValue == other.FlowOutcomeValue ||
                FlowOutcomeValue != null &&
                FlowOutcomeValue.Equals(other.FlowOutcomeValue)
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
            if (FlowOutcome != null)
            {
                hash = hash * 59 + FlowOutcome.GetHashCode();
            }

            if (FlowOutcomeEndTimestamp != null)
            {
                hash = hash * 59 + FlowOutcomeEndTimestamp.GetHashCode();
            }

            if (FlowOutcomeId != null)
            {
                hash = hash * 59 + FlowOutcomeId.GetHashCode();
            }

            if (FlowOutcomeStartTimestamp != null)
            {
                hash = hash * 59 + FlowOutcomeStartTimestamp.GetHashCode();
            }

            if (FlowOutcomeValue != null)
            {
                hash = hash * 59 + FlowOutcomeValue.GetHashCode();
            }

            return hash;
        }
    }
}
