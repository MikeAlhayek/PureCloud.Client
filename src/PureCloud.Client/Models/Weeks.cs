using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Weeks
/// </summary>

public partial class Weeks : IEquatable<Weeks>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Weeks" /> class.
    /// </summary>
    /// <param name="WeekOffset">The week offset from data start date.</param>
    /// <param name="Values">data per interval (daily or quarter hour) for this week. The value could be double or null.</param>
    public Weeks(int? WeekOffset = null, List<double?> Values = null)
    {
        this.WeekOffset = WeekOffset;
        this.Values = Values;

    }



    /// <summary>
    /// The week offset from data start date
    /// </summary>
    /// <value>The week offset from data start date</value>
    [JsonPropertyName("weekOffset")]
    public int? WeekOffset { get; set; }



    /// <summary>
    /// data per interval (daily or quarter hour) for this week. The value could be double or null
    /// </summary>
    /// <value>data per interval (daily or quarter hour) for this week. The value could be double or null</value>
    [JsonPropertyName("values")]
    public List<double?> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Weeks {\n");

        sb.Append("  WeekOffset: ").Append(WeekOffset).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as Weeks);
    }

    /// <summary>
    /// Returns true if Weeks instances are equal
    /// </summary>
    /// <param name="other">Instance of Weeks to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Weeks other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekOffset == other.WeekOffset ||
                WeekOffset != null &&
                WeekOffset.Equals(other.WeekOffset)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (WeekOffset != null)
            {
                hash = hash * 59 + WeekOffset.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
