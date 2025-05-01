using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffSettingsRequest
/// </summary>
[DataContract]
public partial class TimeOffSettingsRequest : IEquatable<TimeOffSettingsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffSettingsRequest" /> class.
    /// </summary>
    /// <param name="SubmissionRangeEnforced">Whether to enforce a submission range for agent time off requests.</param>
    /// <param name="SubmissionEarliestDaysFromNow">The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past.</param>
    /// <param name="SubmissionLatestDaysFromNow">The latest number of days from now for which an agent can submit a time off request.</param>
    public TimeOffSettingsRequest(bool? SubmissionRangeEnforced = null, int? SubmissionEarliestDaysFromNow = null, int? SubmissionLatestDaysFromNow = null)
    {
        this.SubmissionRangeEnforced = SubmissionRangeEnforced;
        this.SubmissionEarliestDaysFromNow = SubmissionEarliestDaysFromNow;
        this.SubmissionLatestDaysFromNow = SubmissionLatestDaysFromNow;

    }



    /// <summary>
    /// Whether to enforce a submission range for agent time off requests
    /// </summary>
    /// <value>Whether to enforce a submission range for agent time off requests</value>
    [DataMember(Name = "submissionRangeEnforced", EmitDefaultValue = false)]
    public bool? SubmissionRangeEnforced { get; set; }



    /// <summary>
    /// The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past
    /// </summary>
    /// <value>The earliest number of days from now for which an agent can submit a time off request.  Use negative numbers to indicate days in the past</value>
    [DataMember(Name = "submissionEarliestDaysFromNow", EmitDefaultValue = false)]
    public int? SubmissionEarliestDaysFromNow { get; set; }



    /// <summary>
    /// The latest number of days from now for which an agent can submit a time off request
    /// </summary>
    /// <value>The latest number of days from now for which an agent can submit a time off request</value>
    [DataMember(Name = "submissionLatestDaysFromNow", EmitDefaultValue = false)]
    public int? SubmissionLatestDaysFromNow { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffSettingsRequest {\n");

        sb.Append("  SubmissionRangeEnforced: ").Append(SubmissionRangeEnforced).Append("\n");
        sb.Append("  SubmissionEarliestDaysFromNow: ").Append(SubmissionEarliestDaysFromNow).Append("\n");
        sb.Append("  SubmissionLatestDaysFromNow: ").Append(SubmissionLatestDaysFromNow).Append("\n");
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
        return this.Equals(obj as TimeOffSettingsRequest);
    }

    /// <summary>
    /// Returns true if TimeOffSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.SubmissionRangeEnforced == other.SubmissionRangeEnforced ||
                this.SubmissionRangeEnforced != null &&
                this.SubmissionRangeEnforced.Equals(other.SubmissionRangeEnforced)
            ) &&
            (
                this.SubmissionEarliestDaysFromNow == other.SubmissionEarliestDaysFromNow ||
                this.SubmissionEarliestDaysFromNow != null &&
                this.SubmissionEarliestDaysFromNow.Equals(other.SubmissionEarliestDaysFromNow)
            ) &&
            (
                this.SubmissionLatestDaysFromNow == other.SubmissionLatestDaysFromNow ||
                this.SubmissionLatestDaysFromNow != null &&
                this.SubmissionLatestDaysFromNow.Equals(other.SubmissionLatestDaysFromNow)
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
            if (this.SubmissionRangeEnforced != null)
            {
                hash = hash * 59 + this.SubmissionRangeEnforced.GetHashCode();
            }

            if (this.SubmissionEarliestDaysFromNow != null)
            {
                hash = hash * 59 + this.SubmissionEarliestDaysFromNow.GetHashCode();
            }

            if (this.SubmissionLatestDaysFromNow != null)
            {
                hash = hash * 59 + this.SubmissionLatestDaysFromNow.GetHashCode();
            }

            return hash;
        }
    }
}
