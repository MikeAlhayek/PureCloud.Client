using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanRotationResponse
/// </summary>
[DataContract]
public partial class WorkPlanRotationResponse : IEquatable<WorkPlanRotationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanRotationResponse" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Enabled">Whether the work plan rotation is enabled for scheduling.</param>
    /// <param name="DateRange">The date range to which this work plan rotation applies.</param>
    /// <param name="Pattern">Pattern with ordered list of work plans that rotate on a weekly basis.</param>
    /// <param name="AgentCount">Number of agents in this work plan rotation.</param>
    /// <param name="Agents">Agents in this work plan rotation. Populate with expand&#x3D;agents for GET WorkPlanRotationsList (defaults to empty list).</param>
    /// <param name="Metadata">Version metadata for this work plan rotation.</param>
    public WorkPlanRotationResponse(string Name = null, bool? Enabled = null, DateRangeWithOptionalEnd DateRange = null, WorkPlanPatternResponse Pattern = null, int? AgentCount = null, List<WorkPlanRotationAgentResponse> Agents = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.Enabled = Enabled;
        this.DateRange = DateRange;
        this.Pattern = Pattern;
        this.AgentCount = AgentCount;
        this.Agents = Agents;
        this.Metadata = Metadata;

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
    /// Whether the work plan rotation is enabled for scheduling
    /// </summary>
    /// <value>Whether the work plan rotation is enabled for scheduling</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The date range to which this work plan rotation applies
    /// </summary>
    /// <value>The date range to which this work plan rotation applies</value>
    [DataMember(Name = "dateRange", EmitDefaultValue = false)]
    public DateRangeWithOptionalEnd DateRange { get; set; }



    /// <summary>
    /// Pattern with ordered list of work plans that rotate on a weekly basis
    /// </summary>
    /// <value>Pattern with ordered list of work plans that rotate on a weekly basis</value>
    [DataMember(Name = "pattern", EmitDefaultValue = false)]
    public WorkPlanPatternResponse Pattern { get; set; }



    /// <summary>
    /// Number of agents in this work plan rotation
    /// </summary>
    /// <value>Number of agents in this work plan rotation</value>
    [DataMember(Name = "agentCount", EmitDefaultValue = false)]
    public int? AgentCount { get; set; }



    /// <summary>
    /// Agents in this work plan rotation. Populate with expand&#x3D;agents for GET WorkPlanRotationsList (defaults to empty list)
    /// </summary>
    /// <value>Agents in this work plan rotation. Populate with expand&#x3D;agents for GET WorkPlanRotationsList (defaults to empty list)</value>
    [DataMember(Name = "agents", EmitDefaultValue = false)]
    public List<WorkPlanRotationAgentResponse> Agents { get; set; }



    /// <summary>
    /// Version metadata for this work plan rotation
    /// </summary>
    /// <value>Version metadata for this work plan rotation</value>
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
        sb.Append("class WorkPlanRotationResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  DateRange: ").Append(DateRange).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
        sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
        sb.Append("  Agents: ").Append(Agents).Append("\n");
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
        return Equals(obj as WorkPlanRotationResponse);
    }

    /// <summary>
    /// Returns true if WorkPlanRotationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanRotationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanRotationResponse other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                DateRange == other.DateRange ||
                DateRange != null &&
                DateRange.Equals(other.DateRange)
            ) &&
            (
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
            ) &&
            (
                AgentCount == other.AgentCount ||
                AgentCount != null &&
                AgentCount.Equals(other.AgentCount)
            ) &&
            (
                Agents == other.Agents ||
                Agents != null &&
                Agents.SequenceEqual(other.Agents)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (DateRange != null)
            {
                hash = hash * 59 + DateRange.GetHashCode();
            }

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            if (AgentCount != null)
            {
                hash = hash * 59 + AgentCount.GetHashCode();
            }

            if (Agents != null)
            {
                hash = hash * 59 + Agents.GetHashCode();
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
