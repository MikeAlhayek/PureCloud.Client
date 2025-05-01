using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalData
/// </summary>
[DataContract]
public partial class HistoricalData : IEquatable<HistoricalData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalData" /> class.
    /// </summary>
    /// <param name="Daily">Daily time series for historical data.</param>
    /// <param name="QuarterHour">Quarter hour time series for historical data.</param>
    public HistoricalData(Daily Daily = null, QuarterHourly QuarterHour = null)
    {
        this.Daily = Daily;
        this.QuarterHour = QuarterHour;

    }



    /// <summary>
    /// Daily time series for historical data
    /// </summary>
    /// <value>Daily time series for historical data</value>
    [DataMember(Name = "daily", EmitDefaultValue = false)]
    public Daily Daily { get; set; }



    /// <summary>
    /// Quarter hour time series for historical data
    /// </summary>
    /// <value>Quarter hour time series for historical data</value>
    [DataMember(Name = "quarterHour", EmitDefaultValue = false)]
    public QuarterHourly QuarterHour { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalData {\n");

        sb.Append("  Daily: ").Append(Daily).Append("\n");
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
        return Equals(obj as HistoricalData);
    }

    /// <summary>
    /// Returns true if HistoricalData instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Daily == other.Daily ||
                Daily != null &&
                Daily.Equals(other.Daily)
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
            if (Daily != null)
            {
                hash = hash * 59 + Daily.GetHashCode();
            }

            if (QuarterHour != null)
            {
                hash = hash * 59 + QuarterHour.GetHashCode();
            }

            return hash;
        }
    }
}
