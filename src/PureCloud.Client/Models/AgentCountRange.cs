using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentCountRange
/// </summary>

public partial class AgentCountRange : IEquatable<AgentCountRange>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCountRange" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentCountRange() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCountRange" /> class.
    /// </summary>
    /// <param name="Minimum">The minimum value of agent count per work plan (required).</param>
    /// <param name="Maximum">The maximum value of agent count per work plan (required).</param>
    public AgentCountRange(int? Minimum = null, int? Maximum = null)
    {
        this.Minimum = Minimum;
        this.Maximum = Maximum;

    }



    /// <summary>
    /// The minimum value of agent count per work plan
    /// </summary>
    /// <value>The minimum value of agent count per work plan</value>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }



    /// <summary>
    /// The maximum value of agent count per work plan
    /// </summary>
    /// <value>The maximum value of agent count per work plan</value>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentCountRange {\n");

        sb.Append("  Minimum: ").Append(Minimum).Append("\n");
        sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
        return Equals(obj as AgentCountRange);
    }

    /// <summary>
    /// Returns true if AgentCountRange instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentCountRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentCountRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Minimum == other.Minimum ||
                Minimum != null &&
                Minimum.Equals(other.Minimum)
            ) &&
            (
                Maximum == other.Maximum ||
                Maximum != null &&
                Maximum.Equals(other.Maximum)
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
            if (Minimum != null)
            {
                hash = hash * 59 + Minimum.GetHashCode();
            }

            if (Maximum != null)
            {
                hash = hash * 59 + Maximum.GetHashCode();
            }

            return hash;
        }
    }
}
