using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAgent
/// </summary>

public partial class WfmAgent : IEquatable<WfmAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmAgent" /> class.
    /// </summary>
    /// <param name="User">The user associated with this data.</param>
    /// <param name="WorkPlan">The work plan associated with this agent, if applicable.</param>
    /// <param name="WorkPlanRotation">The work plan rotation associated with this agent, if applicable.</param>
    /// <param name="AcceptDirectShiftTrades">Whether the agent accepts direct shift trade requests.</param>
    /// <param name="WorkPlanOverrides">The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides.</param>
    /// <param name="Queues">List of queues to which this agent is capable of handling.</param>
    /// <param name="Languages">The list of languages this agent is capable of handling.</param>
    /// <param name="Skills">The list of skills this agent is capable of handling.</param>
    /// <param name="Schedulable">Whether the agent can be included in schedule generation.</param>
    /// <param name="Metadata">Metadata for this agent.</param>
    public WfmAgent(UserReference User = null, WorkPlanReference WorkPlan = null, WorkPlanRotationReference WorkPlanRotation = null, bool? AcceptDirectShiftTrades = null, List<WorkPlanOverride> WorkPlanOverrides = null, List<QueueReference> Queues = null, List<LanguageReference> Languages = null, List<RoutingSkillReference> Skills = null, bool? Schedulable = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.User = User;
        this.WorkPlan = WorkPlan;
        this.WorkPlanRotation = WorkPlanRotation;
        this.AcceptDirectShiftTrades = AcceptDirectShiftTrades;
        this.WorkPlanOverrides = WorkPlanOverrides;
        this.Queues = Queues;
        this.Languages = Languages;
        this.Skills = Skills;
        this.Schedulable = Schedulable;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The user associated with this data
    /// </summary>
    /// <value>The user associated with this data</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The work plan associated with this agent, if applicable
    /// </summary>
    /// <value>The work plan associated with this agent, if applicable</value>
    [JsonPropertyName("workPlan")]
    public WorkPlanReference WorkPlan { get; set; }



    /// <summary>
    /// The work plan rotation associated with this agent, if applicable
    /// </summary>
    /// <value>The work plan rotation associated with this agent, if applicable</value>
    [JsonPropertyName("workPlanRotation")]
    public WorkPlanRotationReference WorkPlanRotation { get; set; }



    /// <summary>
    /// Whether the agent accepts direct shift trade requests
    /// </summary>
    /// <value>Whether the agent accepts direct shift trade requests</value>
    [JsonPropertyName("acceptDirectShiftTrades")]
    public bool? AcceptDirectShiftTrades { get; set; }



    /// <summary>
    /// The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides
    /// </summary>
    /// <value>The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides</value>
    [JsonPropertyName("workPlanOverrides")]
    public List<WorkPlanOverride> WorkPlanOverrides { get; set; }



    /// <summary>
    /// List of queues to which this agent is capable of handling
    /// </summary>
    /// <value>List of queues to which this agent is capable of handling</value>
    [JsonPropertyName("queues")]
    public List<QueueReference> Queues { get; set; }



    /// <summary>
    /// The list of languages this agent is capable of handling
    /// </summary>
    /// <value>The list of languages this agent is capable of handling</value>
    [JsonPropertyName("languages")]
    public List<LanguageReference> Languages { get; set; }



    /// <summary>
    /// The list of skills this agent is capable of handling
    /// </summary>
    /// <value>The list of skills this agent is capable of handling</value>
    [JsonPropertyName("skills")]
    public List<RoutingSkillReference> Skills { get; set; }



    /// <summary>
    /// Whether the agent can be included in schedule generation
    /// </summary>
    /// <value>Whether the agent can be included in schedule generation</value>
    [JsonPropertyName("schedulable")]
    public bool? Schedulable { get; set; }



    /// <summary>
    /// Metadata for this agent
    /// </summary>
    /// <value>Metadata for this agent</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        sb.Append("class WfmAgent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  WorkPlan: ").Append(WorkPlan).Append("\n");
        sb.Append("  WorkPlanRotation: ").Append(WorkPlanRotation).Append("\n");
        sb.Append("  AcceptDirectShiftTrades: ").Append(AcceptDirectShiftTrades).Append("\n");
        sb.Append("  WorkPlanOverrides: ").Append(WorkPlanOverrides).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  Schedulable: ").Append(Schedulable).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WfmAgent);
    }

    /// <summary>
    /// Returns true if WfmAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmAgent other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                WorkPlan == other.WorkPlan ||
                WorkPlan != null &&
                WorkPlan.Equals(other.WorkPlan)
            ) &&
            (
                WorkPlanRotation == other.WorkPlanRotation ||
                WorkPlanRotation != null &&
                WorkPlanRotation.Equals(other.WorkPlanRotation)
            ) &&
            (
                AcceptDirectShiftTrades == other.AcceptDirectShiftTrades ||
                AcceptDirectShiftTrades != null &&
                AcceptDirectShiftTrades.Equals(other.AcceptDirectShiftTrades)
            ) &&
            (
                WorkPlanOverrides == other.WorkPlanOverrides ||
                WorkPlanOverrides != null &&
                WorkPlanOverrides.SequenceEqual(other.WorkPlanOverrides)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                Schedulable == other.Schedulable ||
                Schedulable != null &&
                Schedulable.Equals(other.Schedulable)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (WorkPlan != null)
            {
                hash = hash * 59 + WorkPlan.GetHashCode();
            }

            if (WorkPlanRotation != null)
            {
                hash = hash * 59 + WorkPlanRotation.GetHashCode();
            }

            if (AcceptDirectShiftTrades != null)
            {
                hash = hash * 59 + AcceptDirectShiftTrades.GetHashCode();
            }

            if (WorkPlanOverrides != null)
            {
                hash = hash * 59 + WorkPlanOverrides.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (Schedulable != null)
            {
                hash = hash * 59 + Schedulable.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
