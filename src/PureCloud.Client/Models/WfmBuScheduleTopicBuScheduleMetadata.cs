using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicBuScheduleMetadata
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    public DateTime? WeekDate { get; set; }

    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    public long? WeekCount { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    public bool? Published { get; set; }

    /// <summary>
    /// Gets or Sets ShortTermForecast
    /// </summary>
    public WfmBuScheduleTopicBuShortTermForecastReference ShortTermForecast { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnits
    /// </summary>
    public IEnumerable<WfmBuScheduleTopicBuManagementUnitScheduleSummary> ManagementUnits { get; set; }

    /// <summary>
    /// Gets or Sets GenerationResults
    /// </summary>
    public WfmBuScheduleTopicBuScheduleGenerationResultSummary GenerationResults { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    public WfmBuScheduleTopicWfmVersionedEntityMetadata Metadata { get; set; }
}
