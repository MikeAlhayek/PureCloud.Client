using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AllTimePoints
/// </summary>

public partial class AllTimePoints : IEquatable<AllTimePoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AllTimePoints" /> class.
    /// </summary>
    public AllTimePoints()
    {

    }



    /// <summary>
    /// Queried user
    /// </summary>
    /// <value>Queried user</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// All time point collected bt the user
    /// </summary>
    /// <value>All time point collected bt the user</value>
    [JsonPropertyName("allTimePoints")]
    public long? _AllTimePoints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AllTimePoints {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  _AllTimePoints: ").Append(_AllTimePoints).Append("\n");
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
        return Equals(obj as AllTimePoints);
    }

    /// <summary>
    /// Returns true if AllTimePoints instances are equal
    /// </summary>
    /// <param name="other">Instance of AllTimePoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AllTimePoints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                DateEndWorkday == other.DateEndWorkday ||
                DateEndWorkday != null &&
                DateEndWorkday.Equals(other.DateEndWorkday)
            ) &&
            (
                _AllTimePoints == other._AllTimePoints ||
                _AllTimePoints != null &&
                _AllTimePoints.Equals(other._AllTimePoints)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (_AllTimePoints != null)
            {
                hash = hash * 59 + _AllTimePoints.GetHashCode();
            }

            return hash;
        }
    }
}
