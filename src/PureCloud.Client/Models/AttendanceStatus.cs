using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AttendanceStatus
{
    /// <summary>
    /// the attendance status
    /// </summary>
    /// <value>the attendance status</value>
    public AttendanceStatusAttendanceStatusTypeEnum? AttendanceStatusType { get; set; }

    /// <summary>
    /// the quality evaluation score status
    /// </summary>
    /// <value>the quality evaluation score status</value>
    public AttendanceStatusHasEvaluationEnum? HasEvaluation { get; set; }
}
