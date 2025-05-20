using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdateTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets ShiftStartDates
    /// </summary>
    public IEnumerable<DateTime?> ShiftStartDates { get; set; }
}
