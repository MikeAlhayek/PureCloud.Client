using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemRuleSettings
/// </summary>

public partial class WorkitemRuleSettings : IEquatable<WorkitemRuleSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemRuleSettings" /> class.
    /// </summary>
    /// <param name="FlowRulesEnabled">When set to true, the worktypes flow rules will be processed. Default value is false..</param>
    public WorkitemRuleSettings(bool? FlowRulesEnabled = null)
    {
        this.FlowRulesEnabled = FlowRulesEnabled;

    }



    /// <summary>
    /// When set to true, the worktypes flow rules will be processed. Default value is false.
    /// </summary>
    /// <value>When set to true, the worktypes flow rules will be processed. Default value is false.</value>
    [JsonPropertyName("flowRulesEnabled")]
    public bool? FlowRulesEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemRuleSettings {\n");

        sb.Append("  FlowRulesEnabled: ").Append(FlowRulesEnabled).Append("\n");
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
        return Equals(obj as WorkitemRuleSettings);
    }

    /// <summary>
    /// Returns true if WorkitemRuleSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemRuleSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemRuleSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowRulesEnabled == other.FlowRulesEnabled ||
                FlowRulesEnabled != null &&
                FlowRulesEnabled.Equals(other.FlowRulesEnabled)
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
            if (FlowRulesEnabled != null)
            {
                hash = hash * 59 + FlowRulesEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
