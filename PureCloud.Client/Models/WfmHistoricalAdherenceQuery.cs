using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceQuery
/// </summary>
[DataContract]
public partial class WfmHistoricalAdherenceQuery : IEquatable<WfmHistoricalAdherenceQuery>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmHistoricalAdherenceQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceQuery" /> class.
    /// </summary>
    /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
    /// <param name="EndDate">End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time.</param>
    /// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input..</param>
    /// <param name="UserIds">The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds.</param>
    /// <param name="IncludeExceptions">Whether user exceptions should be returned as part of the results.</param>
    /// <param name="TeamIds">The teamIds to report on. If null or not set, adherence will be computed for requested users if applicable or otherwise all users in the management unit. Note: If teamIds is also specified, only adherence for users in the requested teams will be returned.</param>
    public WfmHistoricalAdherenceQuery(DateTime? StartDate = null, DateTime? EndDate = null, string TimeZone = null, List<string> UserIds = null, bool? IncludeExceptions = null, List<string> TeamIds = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.TimeZone = TimeZone;
        this.UserIds = UserIds;
        this.IncludeExceptions = IncludeExceptions;
        this.TeamIds = TeamIds;

    }



    /// <summary>
    /// Beginning of the date range to query in ISO-8601 format
    /// </summary>
    /// <value>Beginning of the date range to query in ISO-8601 format</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time
    /// </summary>
    /// <value>End of the date range to query in ISO-8601 format. If it is not set, end date will be set to current time</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.
    /// </summary>
    /// <value>The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds
    /// </summary>
    /// <value>The userIds to report on. If null or not set, adherence will be computed for all the users in management unit or requested teamIds</value>
    [DataMember(Name = "userIds", EmitDefaultValue = false)]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// Whether user exceptions should be returned as part of the results
    /// </summary>
    /// <value>Whether user exceptions should be returned as part of the results</value>
    [DataMember(Name = "includeExceptions", EmitDefaultValue = false)]
    public bool? IncludeExceptions { get; set; }



    /// <summary>
    /// The teamIds to report on. If null or not set, adherence will be computed for requested users if applicable or otherwise all users in the management unit. Note: If teamIds is also specified, only adherence for users in the requested teams will be returned
    /// </summary>
    /// <value>The teamIds to report on. If null or not set, adherence will be computed for requested users if applicable or otherwise all users in the management unit. Note: If teamIds is also specified, only adherence for users in the requested teams will be returned</value>
    [DataMember(Name = "teamIds", EmitDefaultValue = false)]
    public List<string> TeamIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceQuery {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  IncludeExceptions: ").Append(IncludeExceptions).Append("\n");
        sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceQuery);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
            ) &&
            (
                IncludeExceptions == other.IncludeExceptions ||
                IncludeExceptions != null &&
                IncludeExceptions.Equals(other.IncludeExceptions)
            ) &&
            (
                TeamIds == other.TeamIds ||
                TeamIds != null &&
                TeamIds.SequenceEqual(other.TeamIds)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (IncludeExceptions != null)
            {
                hash = hash * 59 + IncludeExceptions.GetHashCode();
            }

            if (TeamIds != null)
            {
                hash = hash * 59 + TeamIds.GetHashCode();
            }

            return hash;
        }
    }
}
