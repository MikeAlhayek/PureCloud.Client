using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowMetricsTopicFlowOutcome
/// </summary>
[DataContract]
public partial class FlowMetricsTopicFlowOutcome : IEquatable<FlowMetricsTopicFlowOutcome>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowMetricsTopicFlowOutcome" /> class.
    /// </summary>
    /// <param name="FlowOutcome">Combination of unique flow outcome identifier and its value separated by colon.</param>
    /// <param name="FlowOutcomeId">Unique identifier of a flow outcome.</param>
    /// <param name="FlowOutcomeValue">Flow outcome value, e.g. SUCCESS.</param>
    public FlowMetricsTopicFlowOutcome(string FlowOutcome = null, string FlowOutcomeId = null, string FlowOutcomeValue = null)
    {
        this.FlowOutcome = FlowOutcome;
        this.FlowOutcomeId = FlowOutcomeId;
        this.FlowOutcomeValue = FlowOutcomeValue;

    }



    /// <summary>
    /// Combination of unique flow outcome identifier and its value separated by colon
    /// </summary>
    /// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
    [DataMember(Name = "flowOutcome", EmitDefaultValue = false)]
    public string FlowOutcome { get; set; }



    /// <summary>
    /// Unique identifier of a flow outcome
    /// </summary>
    /// <value>Unique identifier of a flow outcome</value>
    [DataMember(Name = "flowOutcomeId", EmitDefaultValue = false)]
    public string FlowOutcomeId { get; set; }



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
        sb.Append("class FlowMetricsTopicFlowOutcome {\n");

        sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
        sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
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
        return Equals(obj as FlowMetricsTopicFlowOutcome);
    }

    /// <summary>
    /// Returns true if FlowMetricsTopicFlowOutcome instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowMetricsTopicFlowOutcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowMetricsTopicFlowOutcome other)
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
                FlowOutcomeId == other.FlowOutcomeId ||
                FlowOutcomeId != null &&
                FlowOutcomeId.Equals(other.FlowOutcomeId)
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

            if (FlowOutcomeId != null)
            {
                hash = hash * 59 + FlowOutcomeId.GetHashCode();
            }

            if (FlowOutcomeValue != null)
            {
                hash = hash * 59 + FlowOutcomeValue.GetHashCode();
            }

            return hash;
        }
    }
}
