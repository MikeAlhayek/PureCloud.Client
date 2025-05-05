using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastServiceLevelResponse
/// </summary>

public partial class ForecastServiceLevelResponse : IEquatable<ForecastServiceLevelResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastServiceLevelResponse" /> class.
    /// </summary>
    /// <param name="Percent">The percent of calls to answer in the number of seconds defined.</param>
    /// <param name="Seconds">The number of seconds to define for the percent of calls to be answered.</param>
    public ForecastServiceLevelResponse(int? Percent = null, int? Seconds = null)
    {
        this.Percent = Percent;
        this.Seconds = Seconds;

    }



    /// <summary>
    /// The percent of calls to answer in the number of seconds defined
    /// </summary>
    /// <value>The percent of calls to answer in the number of seconds defined</value>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }



    /// <summary>
    /// The number of seconds to define for the percent of calls to be answered
    /// </summary>
    /// <value>The number of seconds to define for the percent of calls to be answered</value>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastServiceLevelResponse {\n");

        sb.Append("  Percent: ").Append(Percent).Append("\n");
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
        return Equals(obj as ForecastServiceLevelResponse);
    }

    /// <summary>
    /// Returns true if ForecastServiceLevelResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastServiceLevelResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastServiceLevelResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Percent == other.Percent ||
                Percent != null &&
                Percent.Equals(other.Percent)
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
            if (Percent != null)
            {
                hash = hash * 59 + Percent.GetHashCode();
            }

            if (Seconds != null)
            {
                hash = hash * 59 + Seconds.GetHashCode();
            }

            return hash;
        }
    }
}
