using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActionMapEstimateOutcomeCriteria
/// </summary>

public partial class ActionMapEstimateOutcomeCriteria : IEquatable<ActionMapEstimateOutcomeCriteria>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionMapEstimateOutcomeCriteria" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActionMapEstimateOutcomeCriteria() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionMapEstimateOutcomeCriteria" /> class.
    /// </summary>
    /// <param name="OutcomeId">ID of outcome. (required).</param>
    /// <param name="MaxProbability">Probability value for the selected outcome at or above which the action map will trigger..</param>
    /// <param name="Probability">Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value..</param>
    /// <param name="Quantile">Represents the quantity of sessions that have a maximum probability less than the predicted probability..</param>
    /// <param name="MaxQuantile">Represents the quantity of sessions that have a maximum probability less than the predicted session max probability..</param>
    public ActionMapEstimateOutcomeCriteria(string OutcomeId = null, float? MaxProbability = null, float? Probability = null, float? Quantile = null, float? MaxQuantile = null)
    {
        this.OutcomeId = OutcomeId;
        this.MaxProbability = MaxProbability;
        this.Probability = Probability;
        this.Quantile = Quantile;
        this.MaxQuantile = MaxQuantile;

    }



    /// <summary>
    /// ID of outcome.
    /// </summary>
    /// <value>ID of outcome.</value>
    [JsonPropertyName("outcomeId")]
    public string OutcomeId { get; set; }



    /// <summary>
    /// Probability value for the selected outcome at or above which the action map will trigger.
    /// </summary>
    /// <value>Probability value for the selected outcome at or above which the action map will trigger.</value>
    [JsonPropertyName("maxProbability")]
    public float? MaxProbability { get; set; }



    /// <summary>
    /// Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value.
    /// </summary>
    /// <value>Additional probability condition, where if set, the action map will trigger if the current outcome probability is lower or equal to the value.</value>
    [JsonPropertyName("probability")]
    public float? Probability { get; set; }



    /// <summary>
    /// Represents the quantity of sessions that have a maximum probability less than the predicted probability.
    /// </summary>
    /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted probability.</value>
    [JsonPropertyName("quantile")]
    public float? Quantile { get; set; }



    /// <summary>
    /// Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.
    /// </summary>
    /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.</value>
    [JsonPropertyName("maxQuantile")]
    public float? MaxQuantile { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionMapEstimateOutcomeCriteria {\n");

        sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
        sb.Append("  MaxProbability: ").Append(MaxProbability).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
        sb.Append("  Quantile: ").Append(Quantile).Append("\n");
        sb.Append("  MaxQuantile: ").Append(MaxQuantile).Append("\n");
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
        return Equals(obj as ActionMapEstimateOutcomeCriteria);
    }

    /// <summary>
    /// Returns true if ActionMapEstimateOutcomeCriteria instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionMapEstimateOutcomeCriteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionMapEstimateOutcomeCriteria other)
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
                MaxProbability == other.MaxProbability ||
                MaxProbability != null &&
                MaxProbability.Equals(other.MaxProbability)
            ) &&
            (
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
            ) &&
            (
                Quantile == other.Quantile ||
                Quantile != null &&
                Quantile.Equals(other.Quantile)
            ) &&
            (
                MaxQuantile == other.MaxQuantile ||
                MaxQuantile != null &&
                MaxQuantile.Equals(other.MaxQuantile)
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

            if (MaxProbability != null)
            {
                hash = hash * 59 + MaxProbability.GetHashCode();
            }

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            if (Quantile != null)
            {
                hash = hash * 59 + Quantile.GetHashCode();
            }

            if (MaxQuantile != null)
            {
                hash = hash * 59 + MaxQuantile.GetHashCode();
            }

            return hash;
        }
    }
}
