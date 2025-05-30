using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlans
/// </summary>

public partial class AgentWorkPlans : IEquatable<AgentWorkPlans>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlans" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlans() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlans" /> class.
    /// </summary>
    /// <param name="User">The user (agent) for whom the work plans were requested (required).</param>
    /// <param name="WorkPlanLookupKeysPerWeek">The list of weekly work plan lookup keys. Keys to be searched under workPlanLookup property at top level of result (required).</param>
    public AgentWorkPlans(UserReference User = null, List<int?> WorkPlanLookupKeysPerWeek = null)
    {
        this.User = User;
        this.WorkPlanLookupKeysPerWeek = WorkPlanLookupKeysPerWeek;

    }



    /// <summary>
    /// The user (agent) for whom the work plans were requested
    /// </summary>
    /// <value>The user (agent) for whom the work plans were requested</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The list of weekly work plan lookup keys. Keys to be searched under workPlanLookup property at top level of result
    /// </summary>
    /// <value>The list of weekly work plan lookup keys. Keys to be searched under workPlanLookup property at top level of result</value>
    [JsonPropertyName("workPlanLookupKeysPerWeek")]
    public List<int?> WorkPlanLookupKeysPerWeek { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlans {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  WorkPlanLookupKeysPerWeek: ").Append(WorkPlanLookupKeysPerWeek).Append("\n");
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
        return Equals(obj as AgentWorkPlans);
    }

    /// <summary>
    /// Returns true if AgentWorkPlans instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlans to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlans other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                WorkPlanLookupKeysPerWeek == other.WorkPlanLookupKeysPerWeek ||
                WorkPlanLookupKeysPerWeek != null &&
                WorkPlanLookupKeysPerWeek.SequenceEqual(other.WorkPlanLookupKeysPerWeek)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (WorkPlanLookupKeysPerWeek != null)
            {
                hash = hash * 59 + WorkPlanLookupKeysPerWeek.GetHashCode();
            }

            return hash;
        }
    }
}
