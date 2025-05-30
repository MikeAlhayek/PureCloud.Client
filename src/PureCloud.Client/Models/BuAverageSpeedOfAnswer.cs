using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAverageSpeedOfAnswer
/// </summary>

public partial class BuAverageSpeedOfAnswer : IEquatable<BuAverageSpeedOfAnswer>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuAverageSpeedOfAnswer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuAverageSpeedOfAnswer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAverageSpeedOfAnswer" /> class.
    /// </summary>
    /// <param name="Include">Whether to include average speed of answer (ASA) in the associated configuration (required).</param>
    /// <param name="Seconds">The target average speed of answer (ASA) in seconds. Required if include &#x3D;&#x3D; true.</param>
    public BuAverageSpeedOfAnswer(bool? Include = null, int? Seconds = null)
    {
        this.Include = Include;
        this.Seconds = Seconds;

    }



    /// <summary>
    /// Whether to include average speed of answer (ASA) in the associated configuration
    /// </summary>
    /// <value>Whether to include average speed of answer (ASA) in the associated configuration</value>
    [JsonPropertyName("include")]
    public bool? Include { get; set; }



    /// <summary>
    /// The target average speed of answer (ASA) in seconds. Required if include &#x3D;&#x3D; true
    /// </summary>
    /// <value>The target average speed of answer (ASA) in seconds. Required if include &#x3D;&#x3D; true</value>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAverageSpeedOfAnswer {\n");

        sb.Append("  Include: ").Append(Include).Append("\n");
        sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
        return Equals(obj as BuAverageSpeedOfAnswer);
    }

    /// <summary>
    /// Returns true if BuAverageSpeedOfAnswer instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAverageSpeedOfAnswer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAverageSpeedOfAnswer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Include == other.Include ||
                Include != null &&
                Include.Equals(other.Include)
            ) &&
            (
                Seconds == other.Seconds ||
                Seconds != null &&
                Seconds.Equals(other.Seconds)
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
            if (Include != null)
            {
                hash = hash * 59 + Include.GetHashCode();
            }

            if (Seconds != null)
            {
                hash = hash * 59 + Seconds.GetHashCode();
            }

            return hash;
        }
    }
}
