using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeProbabilityCondition
/// </summary>

public partial class OutcomeProbabilityCondition : IEquatable<OutcomeProbabilityCondition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeProbabilityCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomeProbabilityCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeProbabilityCondition" /> class.
    /// </summary>
    /// <param name="OutcomeId">The outcome ID. (required).</param>
    /// <param name="MaximumProbability">Probability value for the selected outcome at or above which the action map will trigger. (required).</param>
    /// <param name="Probability">Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value..</param>
    public OutcomeProbabilityCondition(string OutcomeId = null, float? MaximumProbability = null, float? Probability = null)
    {
        this.OutcomeId = OutcomeId;
        this.MaximumProbability = MaximumProbability;
        this.Probability = Probability;

    }



    /// <summary>
    /// The outcome ID.
    /// </summary>
    /// <value>The outcome ID.</value>
    [JsonPropertyName("outcomeId")]
    public string OutcomeId { get; set; }



    /// <summary>
    /// Probability value for the selected outcome at or above which the action map will trigger.
    /// </summary>
    /// <value>Probability value for the selected outcome at or above which the action map will trigger.</value>
    [JsonPropertyName("maximumProbability")]
    public float? MaximumProbability { get; set; }



    /// <summary>
    /// Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value.
    /// </summary>
    /// <value>Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value.</value>
    [JsonPropertyName("probability")]
    public float? Probability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeProbabilityCondition {\n");

        sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
        sb.Append("  MaximumProbability: ").Append(MaximumProbability).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
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
        return Equals(obj as OutcomeProbabilityCondition);
    }

    /// <summary>
    /// Returns true if OutcomeProbabilityCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeProbabilityCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeProbabilityCondition other)
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
                MaximumProbability == other.MaximumProbability ||
                MaximumProbability != null &&
                MaximumProbability.Equals(other.MaximumProbability)
            ) &&
            (
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
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

            if (MaximumProbability != null)
            {
                hash = hash * 59 + MaximumProbability.GetHashCode();
            }

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            return hash;
        }
    }
}
