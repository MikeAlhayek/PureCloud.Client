using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeInterval
/// </summary>
[DataContract]
public partial class TimeInterval : IEquatable<TimeInterval>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeInterval" /> class.
    /// </summary>
    /// <param name="Months">Months.</param>
    /// <param name="Weeks">Weeks.</param>
    /// <param name="Days">Days.</param>
    /// <param name="Hours">Hours.</param>
    public TimeInterval(int? Months = null, int? Weeks = null, int? Days = null, int? Hours = null)
    {
        this.Months = Months;
        this.Weeks = Weeks;
        this.Days = Days;
        this.Hours = Hours;

    }



    /// <summary>
    /// Gets or Sets Months
    /// </summary>
    [DataMember(Name = "months", EmitDefaultValue = false)]
    public int? Months { get; set; }



    /// <summary>
    /// Gets or Sets Weeks
    /// </summary>
    [DataMember(Name = "weeks", EmitDefaultValue = false)]
    public int? Weeks { get; set; }



    /// <summary>
    /// Gets or Sets Days
    /// </summary>
    [DataMember(Name = "days", EmitDefaultValue = false)]
    public int? Days { get; set; }



    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name = "hours", EmitDefaultValue = false)]
    public int? Hours { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeInterval {\n");

        sb.Append("  Months: ").Append(Months).Append("\n");
        sb.Append("  Weeks: ").Append(Weeks).Append("\n");
        sb.Append("  Days: ").Append(Days).Append("\n");
        sb.Append("  Hours: ").Append(Hours).Append("\n");
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
        return Equals(obj as TimeInterval);
    }

    /// <summary>
    /// Returns true if TimeInterval instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeInterval to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeInterval other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Months == other.Months ||
                Months != null &&
                Months.Equals(other.Months)
            ) &&
            (
                Weeks == other.Weeks ||
                Weeks != null &&
                Weeks.Equals(other.Weeks)
            ) &&
            (
                Days == other.Days ||
                Days != null &&
                Days.Equals(other.Days)
            ) &&
            (
                Hours == other.Hours ||
                Hours != null &&
                Hours.Equals(other.Hours)
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
            if (Months != null)
            {
                hash = hash * 59 + Months.GetHashCode();
            }

            if (Weeks != null)
            {
                hash = hash * 59 + Weeks.GetHashCode();
            }

            if (Days != null)
            {
                hash = hash * 59 + Days.GetHashCode();
            }

            if (Hours != null)
            {
                hash = hash * 59 + Hours.GetHashCode();
            }

            return hash;
        }
    }
}
