using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationFormAndScoringSet
/// </summary>

public partial class EvaluationFormAndScoringSet : IEquatable<EvaluationFormAndScoringSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationFormAndScoringSet" /> class.
    /// </summary>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="Answers">Answers.</param>
    public EvaluationFormAndScoringSet(EvaluationForm EvaluationForm = null, EvaluationScoringSet Answers = null)
    {
        this.EvaluationForm = EvaluationForm;
        this.Answers = Answers;

    }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [JsonPropertyName("evaluationForm")]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [JsonPropertyName("answers")]
    public EvaluationScoringSet Answers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationFormAndScoringSet {\n");

        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
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
        return Equals(obj as EvaluationFormAndScoringSet);
    }

    /// <summary>
    /// Returns true if EvaluationFormAndScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationFormAndScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationFormAndScoringSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
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
            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            return hash;
        }
    }
}
