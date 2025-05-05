using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffRequestLookup
/// </summary>

public partial class TimeOffRequestLookup : IEquatable<TimeOffRequestLookup>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestLookup" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffRequestLookup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestLookup" /> class.
    /// </summary>
    /// <param name="TimeOffRequestId">The ID of the time off request (required).</param>
    /// <param name="UserId">The ID of the user to whom the time off request belongs (required).</param>
    public TimeOffRequestLookup(string TimeOffRequestId = null, string UserId = null)
    {
        this.TimeOffRequestId = TimeOffRequestId;
        this.UserId = UserId;

    }



    /// <summary>
    /// The ID of the time off request
    /// </summary>
    /// <value>The ID of the time off request</value>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }



    /// <summary>
    /// The ID of the user to whom the time off request belongs
    /// </summary>
    /// <value>The ID of the user to whom the time off request belongs</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffRequestLookup {\n");

        sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as TimeOffRequestLookup);
    }

    /// <summary>
    /// Returns true if TimeOffRequestLookup instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffRequestLookup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffRequestLookup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequestId == other.TimeOffRequestId ||
                TimeOffRequestId != null &&
                TimeOffRequestId.Equals(other.TimeOffRequestId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
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
            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            return hash;
        }
    }
}
