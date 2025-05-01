using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// NextOccurrenceDetails
/// </summary>
[DataContract]
public partial class NextOccurrenceDetails : IEquatable<NextOccurrenceDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NextOccurrenceDetails" /> class.
    /// </summary>
    /// <param name="StartOccurrenceDetails">The details for the next start occurrence for the recurrence..</param>
    /// <param name="EndOccurrenceDetails">The details for the next end occurrence for the recurrence..</param>
    public NextOccurrenceDetails(OccurrenceDetails StartOccurrenceDetails = null, OccurrenceDetails EndOccurrenceDetails = null)
    {
        this.StartOccurrenceDetails = StartOccurrenceDetails;
        this.EndOccurrenceDetails = EndOccurrenceDetails;

    }



    /// <summary>
    /// The details for the next start occurrence for the recurrence.
    /// </summary>
    /// <value>The details for the next start occurrence for the recurrence.</value>
    [DataMember(Name = "startOccurrenceDetails", EmitDefaultValue = false)]
    public OccurrenceDetails StartOccurrenceDetails { get; set; }



    /// <summary>
    /// The details for the next end occurrence for the recurrence.
    /// </summary>
    /// <value>The details for the next end occurrence for the recurrence.</value>
    [DataMember(Name = "endOccurrenceDetails", EmitDefaultValue = false)]
    public OccurrenceDetails EndOccurrenceDetails { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NextOccurrenceDetails {\n");

        sb.Append("  StartOccurrenceDetails: ").Append(StartOccurrenceDetails).Append("\n");
        sb.Append("  EndOccurrenceDetails: ").Append(EndOccurrenceDetails).Append("\n");
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
        return Equals(obj as NextOccurrenceDetails);
    }

    /// <summary>
    /// Returns true if NextOccurrenceDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of NextOccurrenceDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NextOccurrenceDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartOccurrenceDetails == other.StartOccurrenceDetails ||
                StartOccurrenceDetails != null &&
                StartOccurrenceDetails.Equals(other.StartOccurrenceDetails)
            ) &&
            (
                EndOccurrenceDetails == other.EndOccurrenceDetails ||
                EndOccurrenceDetails != null &&
                EndOccurrenceDetails.Equals(other.EndOccurrenceDetails)
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
            if (StartOccurrenceDetails != null)
            {
                hash = hash * 59 + StartOccurrenceDetails.GetHashCode();
            }

            if (EndOccurrenceDetails != null)
            {
                hash = hash * 59 + EndOccurrenceDetails.GetHashCode();
            }

            return hash;
        }
    }
}
