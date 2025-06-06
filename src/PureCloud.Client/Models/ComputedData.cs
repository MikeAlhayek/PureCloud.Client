using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ComputedData
/// </summary>

public partial class ComputedData : IEquatable<ComputedData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ComputedData" /> class.
    /// </summary>
    /// <param name="Weekly">Weekly time series for forecast data.</param>
    /// <param name="QuarterHour">Quarter hour time series for forecast data.</param>
    public ComputedData(Weekly Weekly = null, QuarterHourly QuarterHour = null)
    {
        this.Weekly = Weekly;
        this.QuarterHour = QuarterHour;

    }



    /// <summary>
    /// Weekly time series for forecast data
    /// </summary>
    /// <value>Weekly time series for forecast data</value>
    [JsonPropertyName("weekly")]
    public Weekly Weekly { get; set; }



    /// <summary>
    /// Quarter hour time series for forecast data
    /// </summary>
    /// <value>Quarter hour time series for forecast data</value>
    [JsonPropertyName("quarterHour")]
    public QuarterHourly QuarterHour { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ComputedData {\n");

        sb.Append("  Weekly: ").Append(Weekly).Append("\n");
        sb.Append("  QuarterHour: ").Append(QuarterHour).Append("\n");
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
        return Equals(obj as ComputedData);
    }

    /// <summary>
    /// Returns true if ComputedData instances are equal
    /// </summary>
    /// <param name="other">Instance of ComputedData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ComputedData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Weekly == other.Weekly ||
                Weekly != null &&
                Weekly.Equals(other.Weekly)
            ) &&
            (
                QuarterHour == other.QuarterHour ||
                QuarterHour != null &&
                QuarterHour.Equals(other.QuarterHour)
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
            if (Weekly != null)
            {
                hash = hash * 59 + Weekly.GetHashCode();
            }

            if (QuarterHour != null)
            {
                hash = hash * 59 + QuarterHour.GetHashCode();
            }

            return hash;
        }
    }
}
