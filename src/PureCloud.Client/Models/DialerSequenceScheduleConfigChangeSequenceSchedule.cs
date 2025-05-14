using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerSequenceScheduleConfigChangeSequenceSchedule
{
    /// <summary>
    /// a list of start and end times
    /// </summary>
    /// <value>a list of start and end times</value>
    public IEnumerable<DialerSequenceScheduleConfigChangeScheduleInterval> Intervals { get; set; }

    /// <summary>
    /// a list of recurrences for a schedule
    /// </summary>
    /// <value>a list of recurrences for a schedule</value>
    public IEnumerable<DialerSequenceScheduleConfigChangeScheduleRecurrence> Recurrences { get; set; }

    /// <summary>
    /// time zone identifier to be applied to the intervals; for example Africa/Abidjan
    /// </summary>
    /// <value>time zone identifier to be applied to the intervals; for example Africa/Abidjan</value>
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or Sets Sequence
    /// </summary>
    public DialerSequenceScheduleConfigChangeUriReference Sequence { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}
