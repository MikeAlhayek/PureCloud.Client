using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemStatusFilter
{
    /// <summary>
    /// Worktype ID belonging to the selected workitem status
    /// </summary>
    /// <value>Worktype ID belonging to the selected workitem status</value>
    public string WorktypeId { get; set; }

    /// <summary>
    /// Workitem status ID
    /// </summary>
    /// <value>Workitem status ID</value>
    public string WorkitemStatusId { get; set; }
}
