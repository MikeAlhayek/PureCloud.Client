using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentEvaluatorActivity
/// </summary>
[DataContract]
public partial class AgentEvaluatorActivity : IEquatable<AgentEvaluatorActivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentEvaluatorActivity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Evaluator">Evaluator.</param>
    /// <param name="NumEvaluations">NumEvaluations.</param>
    /// <param name="AverageEvaluationScore">AverageEvaluationScore.</param>
    /// <param name="NumEvaluationsWithoutViewPermission">NumEvaluationsWithoutViewPermission.</param>
    public AgentEvaluatorActivity(string Name = null, User Agent = null, User Evaluator = null, int? NumEvaluations = null, int? AverageEvaluationScore = null, int? NumEvaluationsWithoutViewPermission = null)
    {
        this.Name = Name;
        this.Agent = Agent;
        this.Evaluator = Evaluator;
        this.NumEvaluations = NumEvaluations;
        this.AverageEvaluationScore = AverageEvaluationScore;
        this.NumEvaluationsWithoutViewPermission = NumEvaluationsWithoutViewPermission;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [DataMember(Name = "agent", EmitDefaultValue = false)]
    public User Agent { get; set; }



    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    [DataMember(Name = "evaluator", EmitDefaultValue = false)]
    public User Evaluator { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluations
    /// </summary>
    [DataMember(Name = "numEvaluations", EmitDefaultValue = false)]
    public int? NumEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets AverageEvaluationScore
    /// </summary>
    [DataMember(Name = "averageEvaluationScore", EmitDefaultValue = false)]
    public int? AverageEvaluationScore { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsWithoutViewPermission
    /// </summary>
    [DataMember(Name = "numEvaluationsWithoutViewPermission", EmitDefaultValue = false)]
    public int? NumEvaluationsWithoutViewPermission { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentEvaluatorActivity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
        sb.Append("  NumEvaluations: ").Append(NumEvaluations).Append("\n");
        sb.Append("  AverageEvaluationScore: ").Append(AverageEvaluationScore).Append("\n");
        sb.Append("  NumEvaluationsWithoutViewPermission: ").Append(NumEvaluationsWithoutViewPermission).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as AgentEvaluatorActivity);
    }

    /// <summary>
    /// Returns true if AgentEvaluatorActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentEvaluatorActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentEvaluatorActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Evaluator == other.Evaluator ||
                Evaluator != null &&
                Evaluator.Equals(other.Evaluator)
            ) &&
            (
                NumEvaluations == other.NumEvaluations ||
                NumEvaluations != null &&
                NumEvaluations.Equals(other.NumEvaluations)
            ) &&
            (
                AverageEvaluationScore == other.AverageEvaluationScore ||
                AverageEvaluationScore != null &&
                AverageEvaluationScore.Equals(other.AverageEvaluationScore)
            ) &&
            (
                NumEvaluationsWithoutViewPermission == other.NumEvaluationsWithoutViewPermission ||
                NumEvaluationsWithoutViewPermission != null &&
                NumEvaluationsWithoutViewPermission.Equals(other.NumEvaluationsWithoutViewPermission)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Evaluator != null)
            {
                hash = hash * 59 + Evaluator.GetHashCode();
            }

            if (NumEvaluations != null)
            {
                hash = hash * 59 + NumEvaluations.GetHashCode();
            }

            if (AverageEvaluationScore != null)
            {
                hash = hash * 59 + AverageEvaluationScore.GetHashCode();
            }

            if (NumEvaluationsWithoutViewPermission != null)
            {
                hash = hash * 59 + NumEvaluationsWithoutViewPermission.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
