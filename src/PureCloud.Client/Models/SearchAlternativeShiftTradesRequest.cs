using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchAlternativeShiftTradesRequest
/// </summary>

public partial class SearchAlternativeShiftTradesRequest : IEquatable<SearchAlternativeShiftTradesRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchAlternativeShiftTradesRequest" /> class.
    /// </summary>
    /// <param name="ManagementUnitIds">The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required.</param>
    /// <param name="AgentIds">The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required.</param>
    public SearchAlternativeShiftTradesRequest(List<string> ManagementUnitIds = null, List<string> AgentIds = null)
    {
        this.ManagementUnitIds = ManagementUnitIds;
        this.AgentIds = AgentIds;

    }



    /// <summary>
    /// The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required
    /// </summary>
    /// <value>The list of management unit IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required</value>
    [JsonPropertyName("managementUnitIds")]
    public List<string> ManagementUnitIds { get; set; }



    /// <summary>
    /// The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required
    /// </summary>
    /// <value>The list of agent IDs for this alternative shift trade search. Either managementUnitIds or agentIds is required</value>
    [JsonPropertyName("agentIds")]
    public List<string> AgentIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchAlternativeShiftTradesRequest {\n");

        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
        sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
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
        return Equals(obj as SearchAlternativeShiftTradesRequest);
    }

    /// <summary>
    /// Returns true if SearchAlternativeShiftTradesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchAlternativeShiftTradesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchAlternativeShiftTradesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
            ) &&
            (
                AgentIds == other.AgentIds ||
                AgentIds != null &&
                AgentIds.SequenceEqual(other.AgentIds)
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
            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
            }

            if (AgentIds != null)
            {
                hash = hash * 59 + AgentIds.GetHashCode();
            }

            return hash;
        }
    }
}
