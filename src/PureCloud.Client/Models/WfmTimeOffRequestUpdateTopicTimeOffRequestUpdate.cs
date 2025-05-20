using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmTimeOffRequestUpdateTopicTimeOffRequestUpdateStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Substatus
    /// </summary>
    public WfmTimeOffRequestUpdateTopicTimeOffRequestUpdateSubstatusEnum? Substatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public WfmTimeOffRequestUpdateTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets IsFullDayRequest
    /// </summary>
    public bool? IsFullDayRequest { get; set; }

    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    public bool? MarkedAsRead { get; set; }

    /// <summary>
    /// Gets or Sets ActivityCodeId
    /// </summary>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// Gets or Sets Paid
    /// </summary>
    public bool? Paid { get; set; }

    /// <summary>
    /// Gets or Sets PartialDayStartDateTimes
    /// </summary>
    public IEnumerable<string> PartialDayStartDateTimes { get; set; }

    /// <summary>
    /// Gets or Sets FullDayManagementUnitDates
    /// </summary>
    public IEnumerable<string> FullDayManagementUnitDates { get; set; }

    /// <summary>
    /// Gets or Sets DailyDurationMinutes
    /// </summary>
    public long? DailyDurationMinutes { get; set; }

    /// <summary>
    /// Gets or Sets DurationMinutes
    /// </summary>
    public IEnumerable<long?> DurationMinutes { get; set; }

    /// <summary>
    /// Gets or Sets PayableMinutes
    /// </summary>
    public IEnumerable<long?> PayableMinutes { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    public string ReviewedDate { get; set; }

    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    public string ReviewedBy { get; set; }

    /// <summary>
    /// Gets or Sets SubmittedDate
    /// </summary>
    public string SubmittedDate { get; set; }

    /// <summary>
    /// Gets or Sets SubmittedBy
    /// </summary>
    public string SubmittedBy { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public string ModifiedDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public string ModifiedBy { get; set; }
}
