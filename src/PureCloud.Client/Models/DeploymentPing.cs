using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DeploymentPing
/// </summary>

public partial class DeploymentPing : IEquatable<DeploymentPing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeploymentPing" /> class.
    /// </summary>
    /// <param name="Actions">Collection of actions to be offered or displayed to the visitor..</param>
    /// <param name="PollIntervalMilliseconds">Custom poll interval in milliseconds; when the return value is -1, disable pings..</param>
    public DeploymentPing(List<DeploymentWebAction> Actions = null, int? PollIntervalMilliseconds = null)
    {
        this.Actions = Actions;
        this.PollIntervalMilliseconds = PollIntervalMilliseconds;

    }



    /// <summary>
    /// Collection of actions to be offered or displayed to the visitor.
    /// </summary>
    /// <value>Collection of actions to be offered or displayed to the visitor.</value>
    [JsonPropertyName("actions")]
    public List<DeploymentWebAction> Actions { get; set; }



    /// <summary>
    /// Custom poll interval in milliseconds; when the return value is -1, disable pings.
    /// </summary>
    /// <value>Custom poll interval in milliseconds; when the return value is -1, disable pings.</value>
    [JsonPropertyName("pollIntervalMilliseconds")]
    public int? PollIntervalMilliseconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DeploymentPing {\n");

        sb.Append("  Actions: ").Append(Actions).Append("\n");
        sb.Append("  PollIntervalMilliseconds: ").Append(PollIntervalMilliseconds).Append("\n");
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
        return Equals(obj as DeploymentPing);
    }

    /// <summary>
    /// Returns true if DeploymentPing instances are equal
    /// </summary>
    /// <param name="other">Instance of DeploymentPing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DeploymentPing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
            ) &&
            (
                PollIntervalMilliseconds == other.PollIntervalMilliseconds ||
                PollIntervalMilliseconds != null &&
                PollIntervalMilliseconds.Equals(other.PollIntervalMilliseconds)
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
            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            if (PollIntervalMilliseconds != null)
            {
                hash = hash * 59 + PollIntervalMilliseconds.GetHashCode();
            }

            return hash;
        }
    }
}
