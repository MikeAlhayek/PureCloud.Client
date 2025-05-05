using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeQuantileCondition
/// </summary>

public partial class OutcomeQuantileCondition : IEquatable<OutcomeQuantileCondition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeQuantileCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomeQuantileCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeQuantileCondition" /> class.
    /// </summary>
    /// <param name="OutcomeId">The outcome ID. (required).</param>
    /// <param name="MaxQuantileThreshold">This Outcome Quantile Condition is met when sessionMaxQuantile of the OutcomeScore is above this value, (unless fallbackQuantile is set). Range 0.00-1.00 (required).</param>
    /// <param name="FallbackQuantileThreshold">(Optional) If set, this Condition is met when maxQuantileThreshold is met, AND the current quantile of the OutcomeScore is below this fallbackQuantileThreshold. Range 0.00-1.00.</param>
    public OutcomeQuantileCondition(string OutcomeId = null, float? MaxQuantileThreshold = null, float? FallbackQuantileThreshold = null)
    {
        this.OutcomeId = OutcomeId;
        this.MaxQuantileThreshold = MaxQuantileThreshold;
        this.FallbackQuantileThreshold = FallbackQuantileThreshold;

    }



    /// <summary>
    /// The outcome ID.
    /// </summary>
    /// <value>The outcome ID.</value>
    [JsonPropertyName("outcomeId")]
    public string OutcomeId { get; set; }



    /// <summary>
    /// This Outcome Quantile Condition is met when sessionMaxQuantile of the OutcomeScore is above this value, (unless fallbackQuantile is set). Range 0.00-1.00
    /// </summary>
    /// <value>This Outcome Quantile Condition is met when sessionMaxQuantile of the OutcomeScore is above this value, (unless fallbackQuantile is set). Range 0.00-1.00</value>
    [JsonPropertyName("maxQuantileThreshold")]
    public float? MaxQuantileThreshold { get; set; }



    /// <summary>
    /// (Optional) If set, this Condition is met when maxQuantileThreshold is met, AND the current quantile of the OutcomeScore is below this fallbackQuantileThreshold. Range 0.00-1.00
    /// </summary>
    /// <value>(Optional) If set, this Condition is met when maxQuantileThreshold is met, AND the current quantile of the OutcomeScore is below this fallbackQuantileThreshold. Range 0.00-1.00</value>
    [JsonPropertyName("fallbackQuantileThreshold")]
    public float? FallbackQuantileThreshold { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeQuantileCondition {\n");

        sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
        sb.Append("  MaxQuantileThreshold: ").Append(MaxQuantileThreshold).Append("\n");
        sb.Append("  FallbackQuantileThreshold: ").Append(FallbackQuantileThreshold).Append("\n");
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
        return Equals(obj as OutcomeQuantileCondition);
    }

    /// <summary>
    /// Returns true if OutcomeQuantileCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeQuantileCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeQuantileCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutcomeId == other.OutcomeId ||
                OutcomeId != null &&
                OutcomeId.Equals(other.OutcomeId)
            ) &&
            (
                MaxQuantileThreshold == other.MaxQuantileThreshold ||
                MaxQuantileThreshold != null &&
                MaxQuantileThreshold.Equals(other.MaxQuantileThreshold)
            ) &&
            (
                FallbackQuantileThreshold == other.FallbackQuantileThreshold ||
                FallbackQuantileThreshold != null &&
                FallbackQuantileThreshold.Equals(other.FallbackQuantileThreshold)
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
            if (OutcomeId != null)
            {
                hash = hash * 59 + OutcomeId.GetHashCode();
            }

            if (MaxQuantileThreshold != null)
            {
                hash = hash * 59 + MaxQuantileThreshold.GetHashCode();
            }

            if (FallbackQuantileThreshold != null)
            {
                hash = hash * 59 + FallbackQuantileThreshold.GetHashCode();
            }

            return hash;
        }
    }
}
