using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit
/// </summary>

public partial class WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit : IEquatable<WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    public WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit);
    }

    /// <summary>
    /// Returns true if WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmAgentAdherenceExplanationChangedBusinessUnitTopicManagementUnit other)
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

            return hash;
        }
    }
}
