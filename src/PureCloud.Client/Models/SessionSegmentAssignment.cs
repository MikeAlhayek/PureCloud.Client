using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionSegmentAssignment
/// </summary>

public partial class SessionSegmentAssignment : IEquatable<SessionSegmentAssignment>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SessionSegmentAssignment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SessionSegmentAssignment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionSegmentAssignment" /> class.
    /// </summary>
    /// <param name="Segment">The segment that was assigned. (required).</param>
    /// <param name="AssignedDate">Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public SessionSegmentAssignment(AssignedSegment Segment = null, DateTime? AssignedDate = null)
    {
        this.Segment = Segment;
        this.AssignedDate = AssignedDate;

    }



    /// <summary>
    /// The segment that was assigned.
    /// </summary>
    /// <value>The segment that was assigned.</value>
    [JsonPropertyName("segment")]
    public AssignedSegment Segment { get; set; }



    /// <summary>
    /// Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("assignedDate")]
    public DateTime? AssignedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionSegmentAssignment {\n");

        sb.Append("  Segment: ").Append(Segment).Append("\n");
        sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
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
        return Equals(obj as SessionSegmentAssignment);
    }

    /// <summary>
    /// Returns true if SessionSegmentAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionSegmentAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionSegmentAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Segment == other.Segment ||
                Segment != null &&
                Segment.Equals(other.Segment)
            ) &&
            (
                AssignedDate == other.AssignedDate ||
                AssignedDate != null &&
                AssignedDate.Equals(other.AssignedDate)
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
            if (Segment != null)
            {
                hash = hash * 59 + Segment.GetHashCode();
            }

            if (AssignedDate != null)
            {
                hash = hash * 59 + AssignedDate.GetHashCode();
            }

            return hash;
        }
    }
}
