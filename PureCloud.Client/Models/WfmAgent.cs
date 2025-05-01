using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAgent
/// </summary>
[DataContract]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The user associated with this data
    /// </summary>
    /// <value>The user associated with this data</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// The work plan associated with this agent, if applicable
    /// </summary>
    /// <value>The work plan associated with this agent, if applicable</value>
    [DataMember(Name = "workPlan", EmitDefaultValue = false)]
    public WorkPlanReference WorkPlan { get; set; }



    /// <summary>
    /// The work plan rotation associated with this agent, if applicable
    /// </summary>
    /// <value>The work plan rotation associated with this agent, if applicable</value>
    [DataMember(Name = "workPlanRotation", EmitDefaultValue = false)]
    public WorkPlanRotationReference WorkPlanRotation { get; set; }



    /// <summary>
    /// Whether the agent accepts direct shift trade requests
    /// </summary>
    /// <value>Whether the agent accepts direct shift trade requests</value>
    [DataMember(Name = "acceptDirectShiftTrades", EmitDefaultValue = false)]
    public bool? AcceptDirectShiftTrades { get; set; }



    /// <summary>
    /// The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides
    /// </summary>
    /// <value>The work plan overrides associated with this agent. Populate with expand&#x3D;workPlanOverrides</value>
    [DataMember(Name = "workPlanOverrides", EmitDefaultValue = false)]
    public List<WorkPlanOverride> WorkPlanOverrides { get; set; }



    /// <summary>
    /// List of queues to which this agent is capable of handling
    /// </summary>
    /// <value>List of queues to which this agent is capable of handling</value>
    [DataMember(Name = "queues", EmitDefaultValue = false)]
    public List<QueueReference> Queues { get; set; }



    /// <summary>
    /// The list of languages this agent is capable of handling
    /// </summary>
    /// <value>The list of languages this agent is capable of handling</value>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public List<LanguageReference> Languages { get; set; }



    /// <summary>
    /// The list of skills this agent is capable of handling
    /// </summary>
    /// <value>The list of skills this agent is capable of handling</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<RoutingSkillReference> Skills { get; set; }



    /// <summary>
    /// Whether the agent can be included in schedule generation
    /// </summary>
    /// <value>Whether the agent can be included in schedule generation</value>
    [DataMember(Name = "schedulable", EmitDefaultValue = false)]
    public bool? Schedulable { get; set; }



    /// <summary>
    /// Metadata for this agent
    /// </summary>
    /// <value>Metadata for this agent</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        return this.Equals(obj as WfmAgent);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.User == other.User ||
                this.User != null &&
                this.User.Equals(other.User)
            ) &&
            (
                this.WorkPlan == other.WorkPlan ||
                this.WorkPlan != null &&
                this.WorkPlan.Equals(other.WorkPlan)
            ) &&
            (
                this.WorkPlanRotation == other.WorkPlanRotation ||
                this.WorkPlanRotation != null &&
                this.WorkPlanRotation.Equals(other.WorkPlanRotation)
            ) &&
            (
                this.AcceptDirectShiftTrades == other.AcceptDirectShiftTrades ||
                this.AcceptDirectShiftTrades != null &&
                this.AcceptDirectShiftTrades.Equals(other.AcceptDirectShiftTrades)
            ) &&
            (
                this.WorkPlanOverrides == other.WorkPlanOverrides ||
                this.WorkPlanOverrides != null &&
                this.WorkPlanOverrides.SequenceEqual(other.WorkPlanOverrides)
            ) &&
            (
                this.Queues == other.Queues ||
                this.Queues != null &&
                this.Queues.SequenceEqual(other.Queues)
            ) &&
            (
                this.Languages == other.Languages ||
                this.Languages != null &&
                this.Languages.SequenceEqual(other.Languages)
            ) &&
            (
                this.Skills == other.Skills ||
                this.Skills != null &&
                this.Skills.SequenceEqual(other.Skills)
            ) &&
            (
                this.Schedulable == other.Schedulable ||
                this.Schedulable != null &&
                this.Schedulable.Equals(other.Schedulable)
            ) &&
            (
                this.Metadata == other.Metadata ||
                this.Metadata != null &&
                this.Metadata.Equals(other.Metadata)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.User != null)
            {
                hash = hash * 59 + this.User.GetHashCode();
            }

            if (this.WorkPlan != null)
            {
                hash = hash * 59 + this.WorkPlan.GetHashCode();
            }

            if (this.WorkPlanRotation != null)
            {
                hash = hash * 59 + this.WorkPlanRotation.GetHashCode();
            }

            if (this.AcceptDirectShiftTrades != null)
            {
                hash = hash * 59 + this.AcceptDirectShiftTrades.GetHashCode();
            }

            if (this.WorkPlanOverrides != null)
            {
                hash = hash * 59 + this.WorkPlanOverrides.GetHashCode();
            }

            if (this.Queues != null)
            {
                hash = hash * 59 + this.Queues.GetHashCode();
            }

            if (this.Languages != null)
            {
                hash = hash * 59 + this.Languages.GetHashCode();
            }

            if (this.Skills != null)
            {
                hash = hash * 59 + this.Skills.GetHashCode();
            }

            if (this.Schedulable != null)
            {
                hash = hash * 59 + this.Schedulable.GetHashCode();
            }

            if (this.Metadata != null)
            {
                hash = hash * 59 + this.Metadata.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
