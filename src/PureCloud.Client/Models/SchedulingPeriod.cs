using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingPeriod
/// </summary>

public partial class SchedulingPeriod : IEquatable<SchedulingPeriod>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingPeriod" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SchedulingPeriod() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingPeriod" /> class.
    /// </summary>
    /// <param name="EarliestStartDate">The earliest date the associated activity plan can begin, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="LatestEndDate">The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    public SchedulingPeriod(string EarliestStartDate = null, string LatestEndDate = null)
    {
        this.EarliestStartDate = EarliestStartDate;
        this.LatestEndDate = LatestEndDate;

    }



    /// <summary>
    /// The earliest date the associated activity plan can begin, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The earliest date the associated activity plan can begin, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("earliestStartDate")]
    public string EarliestStartDate { get; set; }



    /// <summary>
    /// The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The latest date the associated activity plan can end, in YYYY-MM-DD format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("latestEndDate")]
    public string LatestEndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingPeriod {\n");

        sb.Append("  EarliestStartDate: ").Append(EarliestStartDate).Append("\n");
        sb.Append("  LatestEndDate: ").Append(LatestEndDate).Append("\n");
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
        return Equals(obj as SchedulingPeriod);
    }

    /// <summary>
    /// Returns true if SchedulingPeriod instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingPeriod to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingPeriod other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EarliestStartDate == other.EarliestStartDate ||
                EarliestStartDate != null &&
                EarliestStartDate.Equals(other.EarliestStartDate)
            ) &&
            (
                LatestEndDate == other.LatestEndDate ||
                LatestEndDate != null &&
                LatestEndDate.Equals(other.LatestEndDate)
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
            if (EarliestStartDate != null)
            {
                hash = hash * 59 + EarliestStartDate.GetHashCode();
            }

            if (LatestEndDate != null)
            {
                hash = hash * 59 + LatestEndDate.GetHashCode();
            }

            return hash;
        }
    }
}
