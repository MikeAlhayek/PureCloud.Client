using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CalibrationAssignment
/// </summary>
[DataContract]
public partial class CalibrationAssignment : IEquatable<CalibrationAssignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CalibrationAssignment" /> class.
    /// </summary>
    /// <param name="Calibrator">Calibrator.</param>
    /// <param name="Evaluators">Evaluators.</param>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="ExpertEvaluator">ExpertEvaluator.</param>
    public CalibrationAssignment(User Calibrator = null, List<User> Evaluators = null, EvaluationForm EvaluationForm = null, User ExpertEvaluator = null)
    {
        this.Calibrator = Calibrator;
        this.Evaluators = Evaluators;
        this.EvaluationForm = EvaluationForm;
        this.ExpertEvaluator = ExpertEvaluator;

    }



    /// <summary>
    /// Gets or Sets Calibrator
    /// </summary>
    [DataMember(Name = "calibrator", EmitDefaultValue = false)]
    public User Calibrator { get; set; }



    /// <summary>
    /// Gets or Sets Evaluators
    /// </summary>
    [DataMember(Name = "evaluators", EmitDefaultValue = false)]
    public List<User> Evaluators { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [DataMember(Name = "evaluationForm", EmitDefaultValue = false)]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets ExpertEvaluator
    /// </summary>
    [DataMember(Name = "expertEvaluator", EmitDefaultValue = false)]
    public User ExpertEvaluator { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CalibrationAssignment {\n");

        sb.Append("  Calibrator: ").Append(Calibrator).Append("\n");
        sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  ExpertEvaluator: ").Append(ExpertEvaluator).Append("\n");
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
        return Equals(obj as CalibrationAssignment);
    }

    /// <summary>
    /// Returns true if CalibrationAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of CalibrationAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CalibrationAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Calibrator == other.Calibrator ||
                Calibrator != null &&
                Calibrator.Equals(other.Calibrator)
            ) &&
            (
                Evaluators == other.Evaluators ||
                Evaluators != null &&
                Evaluators.SequenceEqual(other.Evaluators)
            ) &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                ExpertEvaluator == other.ExpertEvaluator ||
                ExpertEvaluator != null &&
                ExpertEvaluator.Equals(other.ExpertEvaluator)
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
            if (Calibrator != null)
            {
                hash = hash * 59 + Calibrator.GetHashCode();
            }

            if (Evaluators != null)
            {
                hash = hash * 59 + Evaluators.GetHashCode();
            }

            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (ExpertEvaluator != null)
            {
                hash = hash * 59 + ExpertEvaluator.GetHashCode();
            }

            return hash;
        }
    }
}
