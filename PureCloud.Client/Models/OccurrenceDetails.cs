using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OccurrenceDetails
/// </summary>
[DataContract]
public partial class OccurrenceDetails : IEquatable<OccurrenceDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OccurrenceDetails" /> class.
    /// </summary>
    /// <param name="DateOfNextOccurrence">The date of the next start or end occurrence for the recurrence as an ISO-8601 string.</param>
    /// <param name="NumberOfOccurrences">The number of start or end occurrences that have been processed for the recurrence..</param>
    public OccurrenceDetails(DateTime? DateOfNextOccurrence = null, int? NumberOfOccurrences = null)
    {
        this.DateOfNextOccurrence = DateOfNextOccurrence;
        this.NumberOfOccurrences = NumberOfOccurrences;

    }



    /// <summary>
    /// The date of the next start or end occurrence for the recurrence as an ISO-8601 string
    /// </summary>
    /// <value>The date of the next start or end occurrence for the recurrence as an ISO-8601 string</value>
    [DataMember(Name = "dateOfNextOccurrence", EmitDefaultValue = false)]
    public DateTime? DateOfNextOccurrence { get; set; }



    /// <summary>
    /// The number of start or end occurrences that have been processed for the recurrence.
    /// </summary>
    /// <value>The number of start or end occurrences that have been processed for the recurrence.</value>
    [DataMember(Name = "numberOfOccurrences", EmitDefaultValue = false)]
    public int? NumberOfOccurrences { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OccurrenceDetails {\n");

        sb.Append("  DateOfNextOccurrence: ").Append(DateOfNextOccurrence).Append("\n");
        sb.Append("  NumberOfOccurrences: ").Append(NumberOfOccurrences).Append("\n");
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
        return Equals(obj as OccurrenceDetails);
    }

    /// <summary>
    /// Returns true if OccurrenceDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of OccurrenceDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OccurrenceDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateOfNextOccurrence == other.DateOfNextOccurrence ||
                DateOfNextOccurrence != null &&
                DateOfNextOccurrence.Equals(other.DateOfNextOccurrence)
            ) &&
            (
                NumberOfOccurrences == other.NumberOfOccurrences ||
                NumberOfOccurrences != null &&
                NumberOfOccurrences.Equals(other.NumberOfOccurrences)
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
            if (DateOfNextOccurrence != null)
            {
                hash = hash * 59 + DateOfNextOccurrence.GetHashCode();
            }

            if (NumberOfOccurrences != null)
            {
                hash = hash * 59 + NumberOfOccurrences.GetHashCode();
            }

            return hash;
        }
    }
}
