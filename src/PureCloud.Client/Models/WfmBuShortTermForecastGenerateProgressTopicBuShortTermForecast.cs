using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecast
{
    /// <summary>
    /// Gets or Sets CreationMethod
    /// </summary>
    public WfmBuShortTermForecastGenerateProgressTopicBuShortTermForecastCreationMethodEnum? CreationMethod { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public string WeekDate { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Legacy
    /// </summary>
    public bool? Legacy { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceStartDate
    /// </summary>
    public DateTime? ReferenceStartDate { get; set; }

    /// <summary>
    /// Gets or Sets SourceDays
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastGenerateProgressTopicForecastSourceDayPointer> SourceDays { get; set; }

    /// <summary>
    /// Gets or Sets Modifications
    /// </summary>
    public IEnumerable<WfmBuShortTermForecastGenerateProgressTopicBuForecastModification> Modifications { get; set; }

    /// <summary>
    /// Gets or Sets TimeZone
    /// </summary>
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or Sets PlanningGroupsVersion
    /// </summary>
    public long? PlanningGroupsVersion { get; set; }

    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    public long? WeekCount { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    public WfmBuShortTermForecastGenerateProgressTopicWfmVersionedEntityMetadata Metadata { get; set; }

    /// <summary>
    /// Gets or Sets CanUseForScheduling
    /// </summary>
    public bool? CanUseForScheduling { get; set; }
}
