using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleHistoryChangeMetadata
/// </summary>
[DataContract]
public partial class BuAgentScheduleHistoryChangeMetadata : IEquatable<BuAgentScheduleHistoryChangeMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleHistoryChangeMetadata" /> class.
    /// </summary>
    /// <param name="DateModified">The timestamp of the schedule change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">The user that made the schedule change. The id may be &#39;System&#39; if it was an automated process.</param>
    public BuAgentScheduleHistoryChangeMetadata(DateTime? DateModified = null, UserReference ModifiedBy = null)
    {
        this.DateModified = DateModified;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// The timestamp of the schedule change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of the schedule change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The user that made the schedule change. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user that made the schedule change. The id may be &#39;System&#39; if it was an automated process</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleHistoryChangeMetadata {\n");

        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return Equals(obj as BuAgentScheduleHistoryChangeMetadata);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleHistoryChangeMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleHistoryChangeMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleHistoryChangeMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
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
            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            return hash;
        }
    }
}
