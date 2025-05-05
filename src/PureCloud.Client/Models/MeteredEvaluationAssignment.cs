using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MeteredEvaluationAssignment
/// </summary>

public partial class MeteredEvaluationAssignment : IEquatable<MeteredEvaluationAssignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MeteredEvaluationAssignment" /> class.
    /// </summary>
    /// <param name="EvaluationContextId">EvaluationContextId.</param>
    /// <param name="Evaluators">Evaluators.</param>
    /// <param name="MaxNumberEvaluations">MaxNumberEvaluations.</param>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="AssignToActiveUser">AssignToActiveUser.</param>
    /// <param name="TimeInterval">TimeInterval.</param>
    public MeteredEvaluationAssignment(string EvaluationContextId = null, List<User> Evaluators = null, int? MaxNumberEvaluations = null, EvaluationForm EvaluationForm = null, bool? AssignToActiveUser = null, TimeInterval TimeInterval = null)
    {
        this.EvaluationContextId = EvaluationContextId;
        this.Evaluators = Evaluators;
        this.MaxNumberEvaluations = MaxNumberEvaluations;
        this.EvaluationForm = EvaluationForm;
        this.AssignToActiveUser = AssignToActiveUser;
        this.TimeInterval = TimeInterval;

    }



    /// <summary>
    /// Gets or Sets EvaluationContextId
    /// </summary>
    [JsonPropertyName("evaluationContextId")]
    public string EvaluationContextId { get; set; }



    /// <summary>
    /// Gets or Sets Evaluators
    /// </summary>
    [JsonPropertyName("evaluators")]
    public List<User> Evaluators { get; set; }



    /// <summary>
    /// Gets or Sets MaxNumberEvaluations
    /// </summary>
    [JsonPropertyName("maxNumberEvaluations")]
    public int? MaxNumberEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [JsonPropertyName("evaluationForm")]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets AssignToActiveUser
    /// </summary>
    [JsonPropertyName("assignToActiveUser")]
    public bool? AssignToActiveUser { get; set; }



    /// <summary>
    /// Gets or Sets TimeInterval
    /// </summary>
    [JsonPropertyName("timeInterval")]
    public TimeInterval TimeInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MeteredEvaluationAssignment {\n");

        sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
        sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
        sb.Append("  MaxNumberEvaluations: ").Append(MaxNumberEvaluations).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  AssignToActiveUser: ").Append(AssignToActiveUser).Append("\n");
        sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
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
        return Equals(obj as MeteredEvaluationAssignment);
    }

    /// <summary>
    /// Returns true if MeteredEvaluationAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of MeteredEvaluationAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MeteredEvaluationAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationContextId == other.EvaluationContextId ||
                EvaluationContextId != null &&
                EvaluationContextId.Equals(other.EvaluationContextId)
            ) &&
            (
                Evaluators == other.Evaluators ||
                Evaluators != null &&
                Evaluators.SequenceEqual(other.Evaluators)
            ) &&
            (
                MaxNumberEvaluations == other.MaxNumberEvaluations ||
                MaxNumberEvaluations != null &&
                MaxNumberEvaluations.Equals(other.MaxNumberEvaluations)
            ) &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                AssignToActiveUser == other.AssignToActiveUser ||
                AssignToActiveUser != null &&
                AssignToActiveUser.Equals(other.AssignToActiveUser)
            ) &&
            (
                TimeInterval == other.TimeInterval ||
                TimeInterval != null &&
                TimeInterval.Equals(other.TimeInterval)
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
            if (EvaluationContextId != null)
            {
                hash = hash * 59 + EvaluationContextId.GetHashCode();
            }

            if (Evaluators != null)
            {
                hash = hash * 59 + Evaluators.GetHashCode();
            }

            if (MaxNumberEvaluations != null)
            {
                hash = hash * 59 + MaxNumberEvaluations.GetHashCode();
            }

            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (AssignToActiveUser != null)
            {
                hash = hash * 59 + AssignToActiveUser.GetHashCode();
            }

            if (TimeInterval != null)
            {
                hash = hash * 59 + TimeInterval.GetHashCode();
            }

            return hash;
        }
    }
}
