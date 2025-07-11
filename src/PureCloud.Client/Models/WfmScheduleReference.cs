using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmScheduleReference
{
    /// <summary>
    /// The ID of the WFM schedule
    /// </summary>
    /// <value>The ID of the WFM schedule</value>
    public string Id { get; set; }

    /// <summary>
    /// A reference to a Workforce Management Business Unit
    /// </summary>
    /// <value>A reference to a Workforce Management Business Unit</value>
    public WfmBusinessUnitReference BusinessUnit { get; set; }

    /// <summary>
    /// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string WeekDate { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
