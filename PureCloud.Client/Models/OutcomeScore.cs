using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeScore
/// </summary>
[DataContract]
public partial class OutcomeScore : IEquatable<OutcomeScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeScore" /> class.
    /// </summary>
    /// <param name="Outcome">The outcome that the score was calculated for..</param>
    /// <param name="SessionMaxProbability">Represents the max probability reached in the session..</param>
    /// <param name="Probability">Represents the likelihood of a customer reaching or achieving a given outcome..</param>
    /// <param name="Percentile">(Deprecated: use the &#39;quantile&#39; field instead) Represents the predicted probability&#39;s percentile score when compared with all other generated probabilities for a given outcome..</param>
    /// <param name="SessionMaxPercentile">(Deprecated: use the &#39;quantile&#39; field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session..</param>
    /// <param name="Quantile">Represents the quantity of sessions that have a maximum probability less than the predicted probability..</param>
    /// <param name="SessionMaxQuantile">Represents the quantity of sessions that have a maximum probability less than the predicted session max probability..</param>
    public OutcomeScore(AddressableEntityRef Outcome = null, float? SessionMaxProbability = null, float? Probability = null, int? Percentile = null, int? SessionMaxPercentile = null, float? Quantile = null, float? SessionMaxQuantile = null)
    {
        this.Outcome = Outcome;
        this.SessionMaxProbability = SessionMaxProbability;
        this.Probability = Probability;
        this.Percentile = Percentile;
        this.SessionMaxPercentile = SessionMaxPercentile;
        this.Quantile = Quantile;
        this.SessionMaxQuantile = SessionMaxQuantile;

    }



    /// <summary>
    /// The outcome that the score was calculated for.
    /// </summary>
    /// <value>The outcome that the score was calculated for.</value>
    [DataMember(Name = "outcome", EmitDefaultValue = false)]
    public AddressableEntityRef Outcome { get; set; }



    /// <summary>
    /// Represents the max probability reached in the session.
    /// </summary>
    /// <value>Represents the max probability reached in the session.</value>
    [DataMember(Name = "sessionMaxProbability", EmitDefaultValue = false)]
    public float? SessionMaxProbability { get; set; }



    /// <summary>
    /// Represents the likelihood of a customer reaching or achieving a given outcome.
    /// </summary>
    /// <value>Represents the likelihood of a customer reaching or achieving a given outcome.</value>
    [DataMember(Name = "probability", EmitDefaultValue = false)]
    public float? Probability { get; set; }



    /// <summary>
    /// (Deprecated: use the &#39;quantile&#39; field instead) Represents the predicted probability&#39;s percentile score when compared with all other generated probabilities for a given outcome.
    /// </summary>
    /// <value>(Deprecated: use the &#39;quantile&#39; field instead) Represents the predicted probability&#39;s percentile score when compared with all other generated probabilities for a given outcome.</value>
    [DataMember(Name = "percentile", EmitDefaultValue = false)]
    public int? Percentile { get; set; }



    /// <summary>
    /// (Deprecated: use the &#39;quantile&#39; field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session.
    /// </summary>
    /// <value>(Deprecated: use the &#39;quantile&#39; field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session.</value>
    [DataMember(Name = "sessionMaxPercentile", EmitDefaultValue = false)]
    public int? SessionMaxPercentile { get; set; }



    /// <summary>
    /// Represents the quantity of sessions that have a maximum probability less than the predicted probability.
    /// </summary>
    /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted probability.</value>
    [DataMember(Name = "quantile", EmitDefaultValue = false)]
    public float? Quantile { get; set; }



    /// <summary>
    /// Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.
    /// </summary>
    /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.</value>
    [DataMember(Name = "sessionMaxQuantile", EmitDefaultValue = false)]
    public float? SessionMaxQuantile { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeScore {\n");

        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
        sb.Append("  SessionMaxProbability: ").Append(SessionMaxProbability).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
        sb.Append("  Percentile: ").Append(Percentile).Append("\n");
        sb.Append("  SessionMaxPercentile: ").Append(SessionMaxPercentile).Append("\n");
        sb.Append("  Quantile: ").Append(Quantile).Append("\n");
        sb.Append("  SessionMaxQuantile: ").Append(SessionMaxQuantile).Append("\n");
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
        return Equals(obj as OutcomeScore);
    }

    /// <summary>
    /// Returns true if OutcomeScore instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Outcome == other.Outcome ||
                Outcome != null &&
                Outcome.Equals(other.Outcome)
            ) &&
            (
                SessionMaxProbability == other.SessionMaxProbability ||
                SessionMaxProbability != null &&
                SessionMaxProbability.Equals(other.SessionMaxProbability)
            ) &&
            (
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
            ) &&
            (
                Percentile == other.Percentile ||
                Percentile != null &&
                Percentile.Equals(other.Percentile)
            ) &&
            (
                SessionMaxPercentile == other.SessionMaxPercentile ||
                SessionMaxPercentile != null &&
                SessionMaxPercentile.Equals(other.SessionMaxPercentile)
            ) &&
            (
                Quantile == other.Quantile ||
                Quantile != null &&
                Quantile.Equals(other.Quantile)
            ) &&
            (
                SessionMaxQuantile == other.SessionMaxQuantile ||
                SessionMaxQuantile != null &&
                SessionMaxQuantile.Equals(other.SessionMaxQuantile)
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
            if (Outcome != null)
            {
                hash = hash * 59 + Outcome.GetHashCode();
            }

            if (SessionMaxProbability != null)
            {
                hash = hash * 59 + SessionMaxProbability.GetHashCode();
            }

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            if (Percentile != null)
            {
                hash = hash * 59 + Percentile.GetHashCode();
            }

            if (SessionMaxPercentile != null)
            {
                hash = hash * 59 + SessionMaxPercentile.GetHashCode();
            }

            if (Quantile != null)
            {
                hash = hash * 59 + Quantile.GetHashCode();
            }

            if (SessionMaxQuantile != null)
            {
                hash = hash * 59 + SessionMaxQuantile.GetHashCode();
            }

            return hash;
        }
    }
}
