using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Agent
/// </summary>

public partial class Agent : IEquatable<Agent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Agent" /> class.
    /// </summary>
    /// <param name="Stage">The current stage for this agent.</param>
    public Agent(string Stage = null)
    {
        this.Stage = Stage;

    }



    /// <summary>
    /// The current stage for this agent
    /// </summary>
    /// <value>The current stage for this agent</value>
    [JsonPropertyName("stage")]
    public string Stage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Agent {\n");

        sb.Append("  Stage: ").Append(Stage).Append("\n");
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
        return Equals(obj as Agent);
    }

    /// <summary>
    /// Returns true if Agent instances are equal
    /// </summary>
    /// <param name="other">Instance of Agent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Agent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Stage == other.Stage ||
                Stage != null &&
                Stage.Equals(other.Stage)
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
            if (Stage != null)
            {
                hash = hash * 59 + Stage.GetHashCode();
            }

            return hash;
        }
    }
}
