using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SingleWorkdayAveragePoints
/// </summary>
[DataContract]
public partial class SingleWorkdayAveragePoints : IEquatable<SingleWorkdayAveragePoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SingleWorkdayAveragePoints" /> class.
    /// </summary>
    public SingleWorkdayAveragePoints()
    {

    }



    /// <summary>
    /// Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Queried target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
    public string DateWorkday { get; private set; }



    /// <summary>
    /// The targeted division for the average points
    /// </summary>
    /// <value>The targeted division for the average points</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; private set; }



    /// <summary>
    /// The average points per agent earned within the division
    /// </summary>
    /// <value>The average points per agent earned within the division</value>
    [DataMember(Name = "averagePoints", EmitDefaultValue = false)]
    public double? AveragePoints { get; private set; }



    /// <summary>
    /// The targeted performance profile for the average points
    /// </summary>
    /// <value>The targeted performance profile for the average points</value>
    [DataMember(Name = "performanceProfile", EmitDefaultValue = false)]
    public AddressableEntityRef PerformanceProfile { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SingleWorkdayAveragePoints {\n");

        sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  AveragePoints: ").Append(AveragePoints).Append("\n");
        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
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
        return Equals(obj as SingleWorkdayAveragePoints);
    }

    /// <summary>
    /// Returns true if SingleWorkdayAveragePoints instances are equal
    /// </summary>
    /// <param name="other">Instance of SingleWorkdayAveragePoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SingleWorkdayAveragePoints other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                AveragePoints == other.AveragePoints ||
                AveragePoints != null &&
                AveragePoints.Equals(other.AveragePoints)
            ) &&
            (
                PerformanceProfile == other.PerformanceProfile ||
                PerformanceProfile != null &&
                PerformanceProfile.Equals(other.PerformanceProfile)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (AveragePoints != null)
            {
                hash = hash * 59 + AveragePoints.GetHashCode();
            }

            if (PerformanceProfile != null)
            {
                hash = hash * 59 + PerformanceProfile.GetHashCode();
            }

            return hash;
        }
    }
}
