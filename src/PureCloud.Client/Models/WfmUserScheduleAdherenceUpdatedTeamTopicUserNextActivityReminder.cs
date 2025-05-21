using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserScheduleAdherenceUpdatedTeamTopicUserNextActivityReminder
{
    /// <summary>
    /// Gets or Sets ActivityCategory
    /// </summary>
    public string ActivityCategory { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }
}
