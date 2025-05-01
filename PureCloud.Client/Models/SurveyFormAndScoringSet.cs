using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyFormAndScoringSet
/// </summary>
[DataContract]
public partial class SurveyFormAndScoringSet : IEquatable<SurveyFormAndScoringSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyFormAndScoringSet" /> class.
    /// </summary>
    /// <param name="SurveyForm">SurveyForm.</param>
    /// <param name="Answers">Answers.</param>
    public SurveyFormAndScoringSet(SurveyForm SurveyForm = null, SurveyScoringSet Answers = null)
    {
        this.SurveyForm = SurveyForm;
        this.Answers = Answers;

    }



    /// <summary>
    /// Gets or Sets SurveyForm
    /// </summary>
    [DataMember(Name = "surveyForm", EmitDefaultValue = false)]
    public SurveyForm SurveyForm { get; set; }



    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [DataMember(Name = "answers", EmitDefaultValue = false)]
    public SurveyScoringSet Answers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyFormAndScoringSet {\n");

        sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
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
        return Equals(obj as SurveyFormAndScoringSet);
    }

    /// <summary>
    /// Returns true if SurveyFormAndScoringSet instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyFormAndScoringSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyFormAndScoringSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SurveyForm == other.SurveyForm ||
                SurveyForm != null &&
                SurveyForm.Equals(other.SurveyForm)
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
            if (SurveyForm != null)
            {
                hash = hash * 59 + SurveyForm.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            return hash;
        }
    }
}
