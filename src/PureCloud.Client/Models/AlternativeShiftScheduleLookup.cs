using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftScheduleLookup
/// </summary>

public partial class AlternativeShiftScheduleLookup : IEquatable<AlternativeShiftScheduleLookup>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftScheduleLookup" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftScheduleLookup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftScheduleLookup" /> class.
    /// </summary>
    /// <param name="Id">The unique identifier of the schedule (required).</param>
    /// <param name="WeekDate">The start date for this schedule in yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    public AlternativeShiftScheduleLookup(string Id = null, string WeekDate = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;

    }



    /// <summary>
    /// The unique identifier of the schedule
    /// </summary>
    /// <value>The unique identifier of the schedule</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The start date for this schedule in yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date for this schedule in yyyy-MM-dd. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeShiftScheduleLookup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
        return Equals(obj as AlternativeShiftScheduleLookup);
    }

    /// <summary>
    /// Returns true if AlternativeShiftScheduleLookup instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftScheduleLookup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftScheduleLookup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            return hash;
        }
    }
}
