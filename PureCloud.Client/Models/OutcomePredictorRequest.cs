using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomePredictorRequest
/// </summary>

public partial class OutcomePredictorRequest : IEquatable<OutcomePredictorRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomePredictorRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomePredictorRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomePredictorRequest" /> class.
    /// </summary>
    /// <param name="Outcome">The outcome for which this predictor will provide predictions. (required).</param>
    public OutcomePredictorRequest(OutcomeRefRequest Outcome = null)
    {
        this.Outcome = Outcome;

    }



    /// <summary>
    /// The outcome for which this predictor will provide predictions.
    /// </summary>
    /// <value>The outcome for which this predictor will provide predictions.</value>
    [JsonPropertyName("outcome")]
    public OutcomeRefRequest Outcome { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomePredictorRequest {\n");

        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
        return Equals(obj as OutcomePredictorRequest);
    }

    /// <summary>
    /// Returns true if OutcomePredictorRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomePredictorRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomePredictorRequest other)
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

            return hash;
        }
    }
}
