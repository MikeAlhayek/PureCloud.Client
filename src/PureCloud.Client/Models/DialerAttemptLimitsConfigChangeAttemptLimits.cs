using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerAttemptLimitsConfigChangeAttemptLimits
{
    /// <summary>
    /// After how long the number of attempts will be set back to 0
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0</value>
    public DialerAttemptLimitsConfigChangeAttemptLimitsResetPeriodEnum? ResetPeriod { get; set; }

    /// <summary>
    /// Gets or Sets MaxAttemptsPerContact
    /// </summary>
    public long? MaxAttemptsPerContact { get; set; }

    /// <summary>
    /// Gets or Sets MaxAttemptsPerNumber
    /// </summary>
    public long? MaxAttemptsPerNumber { get; set; }

    /// <summary>
    /// The timezone is necessary to define when \&quot;today\&quot; starts and ends
    /// </summary>
    /// <value>The timezone is necessary to define when \&quot;today\&quot; starts and ends</value>
    public string TimeZoneId { get; set; }

    /// <summary>
    /// Configuration for recall attempts
    /// </summary>
    /// <value>Configuration for recall attempts</value>
    public Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries { get; set; }

    /// <summary>
    /// Whether recalls are performed before considering other numbers (true) or after (false)
    /// </summary>
    /// <value>Whether recalls are performed before considering other numbers (true) or after (false)</value>
    public bool? BreadthFirstRecalls { get; set; }

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
