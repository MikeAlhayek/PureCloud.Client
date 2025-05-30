using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsSettingsRequest
/// </summary>

public partial class InsightsSettingsRequest : IEquatable<InsightsSettingsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsSettingsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InsightsSettingsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsSettingsRequest" /> class.
    /// </summary>
    /// <param name="Enabled">The AI Insights setting (required).</param>
    public InsightsSettingsRequest(bool? Enabled = null)
    {
        this.Enabled = Enabled;

    }



    /// <summary>
    /// The AI Insights setting
    /// </summary>
    /// <value>The AI Insights setting</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsSettingsRequest {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return Equals(obj as InsightsSettingsRequest);
    }

    /// <summary>
    /// Returns true if InsightsSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            return hash;
        }
    }
}
