using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmScheduleActivity
{
    /// <summary>
    /// ID of user that the schedule is for
    /// </summary>
    /// <value>ID of user that the schedule is for</value>
    public UserReference UserReference { get; set; }

    /// <summary>
    /// List of user&#39;s scheduled activities
    /// </summary>
    /// <value>List of user&#39;s scheduled activities</value>
    public IEnumerable<ScheduleActivity> Activities { get; set; }

    /// <summary>
    /// List of user&#39;s days off
    /// </summary>
    /// <value>List of user&#39;s days off</value>
    public IEnumerable<FullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }
}
