using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AutoStatusTransitionDetail
/// </summary>

public partial class AutoStatusTransitionDetail : IEquatable<AutoStatusTransitionDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutoStatusTransitionDetail" /> class.
    /// </summary>
    /// <param name="NextStatus">Next status of auto status transition..</param>
    /// <param name="DateOfTransition">Date at which auto status transition occurs. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ErrorDetails">This property will be set if auto status transition is failed..</param>
    public AutoStatusTransitionDetail(WorkitemStatusReference NextStatus = null, DateTime? DateOfTransition = null, TaskManagementErrorDetails ErrorDetails = null)
    {
        this.NextStatus = NextStatus;
        this.DateOfTransition = DateOfTransition;
        this.ErrorDetails = ErrorDetails;

    }



    /// <summary>
    /// Next status of auto status transition.
    /// </summary>
    /// <value>Next status of auto status transition.</value>
    [JsonPropertyName("nextStatus")]
    public WorkitemStatusReference NextStatus { get; set; }



    /// <summary>
    /// Date at which auto status transition occurs. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date at which auto status transition occurs. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateOfTransition")]
    public DateTime? DateOfTransition { get; set; }



    /// <summary>
    /// This property will be set if auto status transition is failed.
    /// </summary>
    /// <value>This property will be set if auto status transition is failed.</value>
    [JsonPropertyName("errorDetails")]
    public TaskManagementErrorDetails ErrorDetails { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AutoStatusTransitionDetail {\n");

        sb.Append("  NextStatus: ").Append(NextStatus).Append("\n");
        sb.Append("  DateOfTransition: ").Append(DateOfTransition).Append("\n");
        sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
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
        return Equals(obj as AutoStatusTransitionDetail);
    }

    /// <summary>
    /// Returns true if AutoStatusTransitionDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of AutoStatusTransitionDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AutoStatusTransitionDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NextStatus == other.NextStatus ||
                NextStatus != null &&
                NextStatus.Equals(other.NextStatus)
            ) &&
            (
                DateOfTransition == other.DateOfTransition ||
                DateOfTransition != null &&
                DateOfTransition.Equals(other.DateOfTransition)
            ) &&
            (
                ErrorDetails == other.ErrorDetails ||
                ErrorDetails != null &&
                ErrorDetails.Equals(other.ErrorDetails)
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
            if (NextStatus != null)
            {
                hash = hash * 59 + NextStatus.GetHashCode();
            }

            if (DateOfTransition != null)
            {
                hash = hash * 59 + DateOfTransition.GetHashCode();
            }

            if (ErrorDetails != null)
            {
                hash = hash * 59 + ErrorDetails.GetHashCode();
            }

            return hash;
        }
    }
}
