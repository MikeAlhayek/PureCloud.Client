using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmActivityPlanJobCompleteTopicActivityPlanJobException
{
    /// <summary>
    /// Gets or Sets ExceptionType
    /// </summary>
    public WfmActivityPlanJobCompleteTopicActivityPlanJobExceptionExceptionTypeEnum? ExceptionType { get; set; }

    /// <summary>
    /// Gets or Sets Occurrences
    /// </summary>
    public IEnumerable<WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference> Occurrences { get; set; }
}
