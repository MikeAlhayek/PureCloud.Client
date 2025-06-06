using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonRuleBulkDeleteRequest
/// </summary>

public partial class CommonRuleBulkDeleteRequest : IEquatable<CommonRuleBulkDeleteRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleBulkDeleteRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonRuleBulkDeleteRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleBulkDeleteRequest" /> class.
    /// </summary>
    /// <param name="RuleIds">The user supplied rule ids to be deleted (required).</param>
    public CommonRuleBulkDeleteRequest(List<string> RuleIds = null)
    {
        this.RuleIds = RuleIds;

    }



    /// <summary>
    /// The user supplied rule ids to be deleted
    /// </summary>
    /// <value>The user supplied rule ids to be deleted</value>
    [JsonPropertyName("ruleIds")]
    public List<string> RuleIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonRuleBulkDeleteRequest {\n");

        sb.Append("  RuleIds: ").Append(RuleIds).Append("\n");
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
        return Equals(obj as CommonRuleBulkDeleteRequest);
    }

    /// <summary>
    /// Returns true if CommonRuleBulkDeleteRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonRuleBulkDeleteRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonRuleBulkDeleteRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RuleIds == other.RuleIds ||
                RuleIds != null &&
                RuleIds.SequenceEqual(other.RuleIds)
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
            if (RuleIds != null)
            {
                hash = hash * 59 + RuleIds.GetHashCode();
            }

            return hash;
        }
    }
}
