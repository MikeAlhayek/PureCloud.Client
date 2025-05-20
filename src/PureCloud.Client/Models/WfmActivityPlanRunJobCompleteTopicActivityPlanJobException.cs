using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmActivityPlanRunJobCompleteTopicActivityPlanJobException
{
    /// <summary>
    /// Gets or Sets ExceptionType
    /// </summary>
    public WfmActivityPlanRunJobCompleteTopicActivityPlanJobExceptionExceptionTypeEnum? ExceptionType { get; set; }

    /// <summary>
    /// Gets or Sets Occurrences
    /// </summary>
    public IEnumerable<WfmActivityPlanRunJobCompleteTopicActivityPlanOccurrenceReference> Occurrences { get; set; }
}
