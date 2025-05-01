using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayPeriod
/// </summary>
[DataContract]
public partial class WorkdayPeriod : IEquatable<WorkdayPeriod>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayPeriod" /> class.
    /// </summary>
    /// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public WorkdayPeriod(string DateStartWorkday = null, string DateEndWorkday = null)
    {
        this.DateStartWorkday = DateStartWorkday;
        this.DateEndWorkday = DateEndWorkday;

    }



    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
    public string DateEndWorkday { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayPeriod {\n");

        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
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
        return this.Equals(obj as WorkdayPeriod);
    }

    /// <summary>
    /// Returns true if WorkdayPeriod instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayPeriod to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayPeriod other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DateStartWorkday == other.DateStartWorkday ||
                this.DateStartWorkday != null &&
                this.DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                this.DateEndWorkday == other.DateEndWorkday ||
                this.DateEndWorkday != null &&
                this.DateEndWorkday.Equals(other.DateEndWorkday)
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
            if (this.DateStartWorkday != null)
            {
                hash = hash * 59 + this.DateStartWorkday.GetHashCode();
            }

            if (this.DateEndWorkday != null)
            {
                hash = hash * 59 + this.DateEndWorkday.GetHashCode();
            }

            return hash;
        }
    }
}
