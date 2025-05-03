using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayForecastData
/// </summary>

public partial class WfmIntradayDataUpdateTopicIntradayForecastData : IEquatable<WfmIntradayDataUpdateTopicIntradayForecastData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayForecastData" /> class.
    /// </summary>
    /// <param name="Offered">Offered.</param>
    /// <param name="AverageTalkTimeSeconds">AverageTalkTimeSeconds.</param>
    /// <param name="AverageAfterCallWorkSeconds">AverageAfterCallWorkSeconds.</param>
    public WfmIntradayDataUpdateTopicIntradayForecastData(double? Offered = null, double? AverageTalkTimeSeconds = null, double? AverageAfterCallWorkSeconds = null)
    {
        this.Offered = Offered;
        this.AverageTalkTimeSeconds = AverageTalkTimeSeconds;
        this.AverageAfterCallWorkSeconds = AverageAfterCallWorkSeconds;

    }



    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    [JsonPropertyName("offered")]
    public double? Offered { get; set; }



    /// <summary>
    /// Gets or Sets AverageTalkTimeSeconds
    /// </summary>
    [JsonPropertyName("averageTalkTimeSeconds")]
    public double? AverageTalkTimeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets AverageAfterCallWorkSeconds
    /// </summary>
    [JsonPropertyName("averageAfterCallWorkSeconds")]
    public double? AverageAfterCallWorkSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayForecastData {\n");

        sb.Append("  Offered: ").Append(Offered).Append("\n");
        sb.Append("  AverageTalkTimeSeconds: ").Append(AverageTalkTimeSeconds).Append("\n");
        sb.Append("  AverageAfterCallWorkSeconds: ").Append(AverageAfterCallWorkSeconds).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayForecastData);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayForecastData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayForecastData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayForecastData other)
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
                AverageTalkTimeSeconds == other.AverageTalkTimeSeconds ||
                AverageTalkTimeSeconds != null &&
                AverageTalkTimeSeconds.Equals(other.AverageTalkTimeSeconds)
            ) &&
            (
                AverageAfterCallWorkSeconds == other.AverageAfterCallWorkSeconds ||
                AverageAfterCallWorkSeconds != null &&
                AverageAfterCallWorkSeconds.Equals(other.AverageAfterCallWorkSeconds)
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

            if (AverageTalkTimeSeconds != null)
            {
                hash = hash * 59 + AverageTalkTimeSeconds.GetHashCode();
            }

            if (AverageAfterCallWorkSeconds != null)
            {
                hash = hash * 59 + AverageAfterCallWorkSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
