using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentActivity
/// </summary>
public sealed class AgentActivity
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public User Agent { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluations
    /// </summary>
    [JsonPropertyName("numEvaluations")]
    public int? NumEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets AverageEvaluationScore
    /// </summary>
    [JsonPropertyName("averageEvaluationScore")]
    public int? AverageEvaluationScore { get; set; }



    /// <summary>
    /// Gets or Sets NumCriticalEvaluations
    /// </summary>
    [JsonPropertyName("numCriticalEvaluations")]
    public int? NumCriticalEvaluations { get; set; }



    /// <summary>
    /// Gets or Sets AverageCriticalScore
    /// </summary>
    [JsonPropertyName("averageCriticalScore")]
    public float? AverageCriticalScore { get; set; }



    /// <summary>
    /// Gets or Sets HighestEvaluationScore
    /// </summary>
    [JsonPropertyName("highestEvaluationScore")]
    public float? HighestEvaluationScore { get; set; }



    /// <summary>
    /// Gets or Sets LowestEvaluationScore
    /// </summary>
    [JsonPropertyName("lowestEvaluationScore")]
    public float? LowestEvaluationScore { get; set; }



    /// <summary>
    /// Gets or Sets HighestCriticalScore
    /// </summary>
    [JsonPropertyName("highestCriticalScore")]
    public float? HighestCriticalScore { get; set; }



    /// <summary>
    /// Gets or Sets LowestCriticalScore
    /// </summary>
    [JsonPropertyName("lowestCriticalScore")]
    public float? LowestCriticalScore { get; set; }



    /// <summary>
    /// Gets or Sets AgentEvaluatorActivityList
    /// </summary>
    [JsonPropertyName("agentEvaluatorActivityList")]
    public IEnumerable<AgentEvaluatorActivity> AgentEvaluatorActivityList { get; set; }



    /// <summary>
    /// Gets or Sets NumEvaluationsWithoutViewPermission
    /// </summary>
    [JsonPropertyName("numEvaluationsWithoutViewPermission")]
    public int? NumEvaluationsWithoutViewPermission { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentActivity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  NumEvaluations: ").Append(NumEvaluations).Append("\n");
        sb.Append("  AverageEvaluationScore: ").Append(AverageEvaluationScore).Append("\n");
        sb.Append("  NumCriticalEvaluations: ").Append(NumCriticalEvaluations).Append("\n");
        sb.Append("  AverageCriticalScore: ").Append(AverageCriticalScore).Append("\n");
        sb.Append("  HighestEvaluationScore: ").Append(HighestEvaluationScore).Append("\n");
        sb.Append("  LowestEvaluationScore: ").Append(LowestEvaluationScore).Append("\n");
        sb.Append("  HighestCriticalScore: ").Append(HighestCriticalScore).Append("\n");
        sb.Append("  LowestCriticalScore: ").Append(LowestCriticalScore).Append("\n");
        sb.Append("  AgentEvaluatorActivityList: ").Append(AgentEvaluatorActivityList).Append("\n");
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
        return Equals(obj as AgentActivity);
    }

    /// <summary>
    /// Returns true if AgentActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentActivity other)
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
                NumCriticalEvaluations == other.NumCriticalEvaluations ||
                NumCriticalEvaluations != null &&
                NumCriticalEvaluations.Equals(other.NumCriticalEvaluations)
            ) &&
            (
                AverageCriticalScore == other.AverageCriticalScore ||
                AverageCriticalScore != null &&
                AverageCriticalScore.Equals(other.AverageCriticalScore)
            ) &&
            (
                HighestEvaluationScore == other.HighestEvaluationScore ||
                HighestEvaluationScore != null &&
                HighestEvaluationScore.Equals(other.HighestEvaluationScore)
            ) &&
            (
                LowestEvaluationScore == other.LowestEvaluationScore ||
                LowestEvaluationScore != null &&
                LowestEvaluationScore.Equals(other.LowestEvaluationScore)
            ) &&
            (
                HighestCriticalScore == other.HighestCriticalScore ||
                HighestCriticalScore != null &&
                HighestCriticalScore.Equals(other.HighestCriticalScore)
            ) &&
            (
                LowestCriticalScore == other.LowestCriticalScore ||
                LowestCriticalScore != null &&
                LowestCriticalScore.Equals(other.LowestCriticalScore)
            ) &&
            (
                AgentEvaluatorActivityList == other.AgentEvaluatorActivityList ||
                AgentEvaluatorActivityList != null &&
                AgentEvaluatorActivityList.SequenceEqual(other.AgentEvaluatorActivityList)
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

            if (NumEvaluations != null)
            {
                hash = hash * 59 + NumEvaluations.GetHashCode();
            }

            if (AverageEvaluationScore != null)
            {
                hash = hash * 59 + AverageEvaluationScore.GetHashCode();
            }

            if (NumCriticalEvaluations != null)
            {
                hash = hash * 59 + NumCriticalEvaluations.GetHashCode();
            }

            if (AverageCriticalScore != null)
            {
                hash = hash * 59 + AverageCriticalScore.GetHashCode();
            }

            if (HighestEvaluationScore != null)
            {
                hash = hash * 59 + HighestEvaluationScore.GetHashCode();
            }

            if (LowestEvaluationScore != null)
            {
                hash = hash * 59 + LowestEvaluationScore.GetHashCode();
            }

            if (HighestCriticalScore != null)
            {
                hash = hash * 59 + HighestCriticalScore.GetHashCode();
            }

            if (LowestCriticalScore != null)
            {
                hash = hash * 59 + LowestCriticalScore.GetHashCode();
            }

            if (AgentEvaluatorActivityList != null)
            {
                hash = hash * 59 + AgentEvaluatorActivityList.GetHashCode();
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
