using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicBuIntradayForecastData
/// </summary>
[DataContract]
public partial class WfmBuIntradayDataUpdateTopicBuIntradayForecastData : IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayForecastData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayForecastData" /> class.
    /// </summary>
    /// <param name="Offered">Offered.</param>
    /// <param name="AverageHandleTimeSeconds">AverageHandleTimeSeconds.</param>
    public WfmBuIntradayDataUpdateTopicBuIntradayForecastData(double? Offered = null, double? AverageHandleTimeSeconds = null)
    {
        this.Offered = Offered;
        this.AverageHandleTimeSeconds = AverageHandleTimeSeconds;

    }



    /// <summary>
    /// Gets or Sets Offered
    /// </summary>
    [DataMember(Name = "offered", EmitDefaultValue = false)]
    public double? Offered { get; set; }



    /// <summary>
    /// Gets or Sets AverageHandleTimeSeconds
    /// </summary>
    [DataMember(Name = "averageHandleTimeSeconds", EmitDefaultValue = false)]
    public double? AverageHandleTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayForecastData {\n");

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
        return Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayForecastData);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayForecastData instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayForecastData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayForecastData other)
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
