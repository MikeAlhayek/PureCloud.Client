using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayPointsTrendItem
/// </summary>

public partial class WorkdayPointsTrendItem : IEquatable<WorkdayPointsTrendItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayPointsTrendItem" /> class.
    /// </summary>
    public WorkdayPointsTrendItem()
    {

    }



    /// <summary>
    /// workday date for the points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>workday date for the points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateWorkday")]
    public string DateWorkday { get; private set; }



    /// <summary>
    /// workday points for the date
    /// </summary>
    /// <value>workday points for the date</value>
    [JsonPropertyName("points")]
    public double? Points { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayPointsTrendItem {\n");

        sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
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
        return Equals(obj as WorkdayPointsTrendItem);
    }

    /// <summary>
    /// Returns true if WorkdayPointsTrendItem instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayPointsTrendItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayPointsTrendItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateWorkday == other.DateWorkday ||
                DateWorkday != null &&
                DateWorkday.Equals(other.DateWorkday)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
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
            if (DateWorkday != null)
            {
                hash = hash * 59 + DateWorkday.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            return hash;
        }
    }
}
