using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceBulkItem
/// </summary>

public partial class WfmHistoricalAdherenceBulkItem : IEquatable<WfmHistoricalAdherenceBulkItem>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmHistoricalAdherenceBulkItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkItem" /> class.
    /// </summary>
    /// <param name="ManagementUnitId">The ID of the management unit to query (required).</param>
    /// <param name="StartDate">Beginning of the date range to query in ISO-8601 format (required).</param>
    /// <param name="EndDate">End of the date range to query in ISO-8601 format (required).</param>
    /// <param name="UserIds">The IDs of the users to query. If not included, will query every user in the management unit.</param>
    /// <param name="IncludeExceptions">Whether user exceptions should be returned as part of the results. Defaults to false if not specified..</param>
    /// <param name="IncludeActuals">Whether user actual activities should be returned as part of the results. Defaults to false if not specified..</param>
    public WfmHistoricalAdherenceBulkItem(string ManagementUnitId = null, DateTime? StartDate = null, DateTime? EndDate = null, List<string> UserIds = null, bool? IncludeExceptions = null, bool? IncludeActuals = null)
    {
        this.ManagementUnitId = ManagementUnitId;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.UserIds = UserIds;
        this.IncludeExceptions = IncludeExceptions;
        this.IncludeActuals = IncludeActuals;

    }



    /// <summary>
    /// The ID of the management unit to query
    /// </summary>
    /// <value>The ID of the management unit to query</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// Beginning of the date range to query in ISO-8601 format
    /// </summary>
    /// <value>Beginning of the date range to query in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End of the date range to query in ISO-8601 format
    /// </summary>
    /// <value>End of the date range to query in ISO-8601 format</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The IDs of the users to query. If not included, will query every user in the management unit
    /// </summary>
    /// <value>The IDs of the users to query. If not included, will query every user in the management unit</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// Whether user exceptions should be returned as part of the results. Defaults to false if not specified.
    /// </summary>
    /// <value>Whether user exceptions should be returned as part of the results. Defaults to false if not specified.</value>
    [JsonPropertyName("includeExceptions")]
    public bool? IncludeExceptions { get; set; }



    /// <summary>
    /// Whether user actual activities should be returned as part of the results. Defaults to false if not specified.
    /// </summary>
    /// <value>Whether user actual activities should be returned as part of the results. Defaults to false if not specified.</value>
    [JsonPropertyName("includeActuals")]
    public bool? IncludeActuals { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceBulkItem {\n");

        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  IncludeExceptions: ").Append(IncludeExceptions).Append("\n");
        sb.Append("  IncludeActuals: ").Append(IncludeActuals).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceBulkItem);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceBulkItem instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceBulkItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceBulkItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
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
                IncludeActuals == other.IncludeActuals ||
                IncludeActuals != null &&
                IncludeActuals.Equals(other.IncludeActuals)
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
            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (IncludeExceptions != null)
            {
                hash = hash * 59 + IncludeExceptions.GetHashCode();
            }

            if (IncludeActuals != null)
            {
                hash = hash * 59 + IncludeActuals.GetHashCode();
            }

            return hash;
        }
    }
}
