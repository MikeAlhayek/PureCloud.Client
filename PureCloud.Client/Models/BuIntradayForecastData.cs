using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuIntradayForecastData
/// </summary>

public partial class BuIntradayForecastData : IEquatable<BuIntradayForecastData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuIntradayForecastData" /> class.
    /// </summary>
    /// <param name="Offered">The number of interactions routed into the queues in the selected planning groups for the given media type for an agent to answer.</param>
    /// <param name="AverageHandleTimeSeconds">The average handle time in seconds an agent spent handling interactions.</param>
    public BuIntradayForecastData(double? Offered = null, double? AverageHandleTimeSeconds = null)
    {
        this.Offered = Offered;
        this.AverageHandleTimeSeconds = AverageHandleTimeSeconds;

    }



    /// <summary>
    /// The number of interactions routed into the queues in the selected planning groups for the given media type for an agent to answer
    /// </summary>
    /// <value>The number of interactions routed into the queues in the selected planning groups for the given media type for an agent to answer</value>
    [JsonPropertyName("offered")]
    public double? Offered { get; set; }



    /// <summary>
    /// The average handle time in seconds an agent spent handling interactions
    /// </summary>
    /// <value>The average handle time in seconds an agent spent handling interactions</value>
    [JsonPropertyName("averageHandleTimeSeconds")]
    public double? AverageHandleTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuIntradayForecastData {\n");

        sb.Append("  Offered: ").Append(Offered).Append("\n");
        sb.Append("  AverageHandleTimeSeconds: ").Append(AverageHandleTimeSeconds).Append("\n");
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
        return Equals(obj as BuIntradayForecastData);
    }

    /// <summary>
    /// Returns true if BuIntradayForecastData instances are equal
    /// </summary>
    /// <param name="other">Instance of BuIntradayForecastData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuIntradayForecastData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Offered == other.Offered ||
                Offered != null &&
                Offered.Equals(other.Offered)
            ) &&
            (
                AverageHandleTimeSeconds == other.AverageHandleTimeSeconds ||
                AverageHandleTimeSeconds != null &&
                AverageHandleTimeSeconds.Equals(other.AverageHandleTimeSeconds)
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
            if (Offered != null)
            {
                hash = hash * 59 + Offered.GetHashCode();
            }

            if (AverageHandleTimeSeconds != null)
            {
                hash = hash * 59 + AverageHandleTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
