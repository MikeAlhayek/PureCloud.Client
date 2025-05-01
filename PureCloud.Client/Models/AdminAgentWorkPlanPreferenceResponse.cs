using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdminAgentWorkPlanPreferenceResponse
/// </summary>
[DataContract]
public partial class AdminAgentWorkPlanPreferenceResponse : IEquatable<AdminAgentWorkPlanPreferenceResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AdminAgentWorkPlanPreferenceResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AdminAgentWorkPlanPreferenceResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdminAgentWorkPlanPreferenceResponse" /> class.
    /// </summary>
    /// <param name="WorkPlans">The list of work plans that belong to this bid group (required).</param>
    /// <param name="AgentWorkPlanBidPreferences">The list of agents work plan bidding preferences (required).</param>
    public AdminAgentWorkPlanPreferenceResponse(List<WorkPlanReference> WorkPlans = null, List<AdminAgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences = null)
    {
        this.WorkPlans = WorkPlans;
        this.AgentWorkPlanBidPreferences = AgentWorkPlanBidPreferences;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The list of work plans that belong to this bid group
    /// </summary>
    /// <value>The list of work plans that belong to this bid group</value>
    [DataMember(Name = "workPlans", EmitDefaultValue = false)]
    public List<WorkPlanReference> WorkPlans { get; set; }



    /// <summary>
    /// The list of agents work plan bidding preferences
    /// </summary>
    /// <value>The list of agents work plan bidding preferences</value>
    [DataMember(Name = "agentWorkPlanBidPreferences", EmitDefaultValue = false)]
    public List<AdminAgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences { get; set; }



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
        sb.Append("class AdminAgentWorkPlanPreferenceResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
        sb.Append("  AgentWorkPlanBidPreferences: ").Append(AgentWorkPlanBidPreferences).Append("\n");
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
        return Equals(obj as AdminAgentWorkPlanPreferenceResponse);
    }

    /// <summary>
    /// Returns true if AdminAgentWorkPlanPreferenceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AdminAgentWorkPlanPreferenceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdminAgentWorkPlanPreferenceResponse other)
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
                WorkPlans == other.WorkPlans ||
                WorkPlans != null &&
                WorkPlans.SequenceEqual(other.WorkPlans)
            ) &&
            (
                AgentWorkPlanBidPreferences == other.AgentWorkPlanBidPreferences ||
                AgentWorkPlanBidPreferences != null &&
                AgentWorkPlanBidPreferences.SequenceEqual(other.AgentWorkPlanBidPreferences)
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

            if (WorkPlans != null)
            {
                hash = hash * 59 + WorkPlans.GetHashCode();
            }

            if (AgentWorkPlanBidPreferences != null)
            {
                hash = hash * 59 + AgentWorkPlanBidPreferences.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
