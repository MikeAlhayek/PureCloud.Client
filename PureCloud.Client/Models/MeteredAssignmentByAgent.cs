using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// MeteredAssignmentByAgent
/// </summary>
[DataContract]
public partial class MeteredAssignmentByAgent : IEquatable<MeteredAssignmentByAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MeteredAssignmentByAgent" /> class.
    /// </summary>
    /// <param name="EvaluationContextId">EvaluationContextId.</param>
    /// <param name="Evaluators">Evaluators.</param>
    /// <param name="MaxNumberEvaluations">MaxNumberEvaluations.</param>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="TimeInterval">TimeInterval.</param>
    /// <param name="TimeZone">TimeZone.</param>
    public MeteredAssignmentByAgent(string EvaluationContextId = null, List<User> Evaluators = null, int? MaxNumberEvaluations = null, EvaluationForm EvaluationForm = null, TimeInterval TimeInterval = null, string TimeZone = null)
    {
        this.EvaluationContextId = EvaluationContextId;
        this.Evaluators = Evaluators;
        this.MaxNumberEvaluations = MaxNumberEvaluations;
        this.EvaluationForm = EvaluationForm;
        this.TimeInterval = TimeInterval;
        this.TimeZone = TimeZone;

    }



    /// <summary>
    /// Gets or Sets EvaluationContextId
    /// </summary>
    [DataMember(Name = "evaluationContextId", EmitDefaultValue = false)]
    public string EvaluationContextId { get; set; }



    /// <summary>
    /// Gets or Sets Evaluators
    /// </summary>
    [DataMember(Name = "evaluators", EmitDefaultValue = false)]
    public List<User> Evaluators { get; set; }



    /// <summary>
    /// Gets or Sets MaxNumberEvaluations
    /// </summary>
    [DataMember(Name = "maxNumberEvaluations", EmitDefaultValue = false)]
    public int? MaxNumberEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [DataMember(Name = "evaluationForm", EmitDefaultValue = false)]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets TimeInterval
    /// </summary>
    [DataMember(Name = "timeInterval", EmitDefaultValue = false)]
    public TimeInterval TimeInterval { get; set; }



    /// <summary>
    /// Gets or Sets TimeZone
    /// </summary>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MeteredAssignmentByAgent {\n");

        sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
        sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
        sb.Append("  MaxNumberEvaluations: ").Append(MaxNumberEvaluations).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
        return Equals(obj as MeteredAssignmentByAgent);
    }

    /// <summary>
    /// Returns true if MeteredAssignmentByAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of MeteredAssignmentByAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MeteredAssignmentByAgent other)
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
                TimeInterval == other.TimeInterval ||
                TimeInterval != null &&
                TimeInterval.Equals(other.TimeInterval)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
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

            if (TimeInterval != null)
            {
                hash = hash * 59 + TimeInterval.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            return hash;
        }
    }
}
