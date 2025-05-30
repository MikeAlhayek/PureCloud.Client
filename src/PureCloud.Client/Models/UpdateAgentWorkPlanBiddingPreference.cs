using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateAgentWorkPlanBiddingPreference
/// </summary>

public partial class UpdateAgentWorkPlanBiddingPreference : IEquatable<UpdateAgentWorkPlanBiddingPreference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateAgentWorkPlanBiddingPreference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateAgentWorkPlanBiddingPreference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateAgentWorkPlanBiddingPreference" /> class.
    /// </summary>
    /// <param name="Submitted">Whether the preference is submitted (required).</param>
    /// <param name="AgentWorkPlanBidPreferences">The list of work plan bidding preferences (required).</param>
    public UpdateAgentWorkPlanBiddingPreference(bool? Submitted = null, List<AgentWorkPlanBiddingPreferenceRequest> AgentWorkPlanBidPreferences = null)
    {
        this.Submitted = Submitted;
        this.AgentWorkPlanBidPreferences = AgentWorkPlanBidPreferences;

    }



    /// <summary>
    /// Whether the preference is submitted
    /// </summary>
    /// <value>Whether the preference is submitted</value>
    [JsonPropertyName("submitted")]
    public bool? Submitted { get; set; }



    /// <summary>
    /// The list of work plan bidding preferences
    /// </summary>
    /// <value>The list of work plan bidding preferences</value>
    [JsonPropertyName("agentWorkPlanBidPreferences")]
    public List<AgentWorkPlanBiddingPreferenceRequest> AgentWorkPlanBidPreferences { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateAgentWorkPlanBiddingPreference {\n");

        sb.Append("  Submitted: ").Append(Submitted).Append("\n");
        sb.Append("  AgentWorkPlanBidPreferences: ").Append(AgentWorkPlanBidPreferences).Append("\n");
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
        return Equals(obj as UpdateAgentWorkPlanBiddingPreference);
    }

    /// <summary>
    /// Returns true if UpdateAgentWorkPlanBiddingPreference instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateAgentWorkPlanBiddingPreference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateAgentWorkPlanBiddingPreference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Submitted == other.Submitted ||
                Submitted != null &&
                Submitted.Equals(other.Submitted)
            ) &&
            (
                AgentWorkPlanBidPreferences == other.AgentWorkPlanBidPreferences ||
                AgentWorkPlanBidPreferences != null &&
                AgentWorkPlanBidPreferences.SequenceEqual(other.AgentWorkPlanBidPreferences)
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
            if (Submitted != null)
            {
                hash = hash * 59 + Submitted.GetHashCode();
            }

            if (AgentWorkPlanBidPreferences != null)
            {
                hash = hash * 59 + AgentWorkPlanBidPreferences.GetHashCode();
            }

            return hash;
        }
    }
}
