namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCodeContainer
/// </summary>
public sealed class ActivityCodeContainer
{
    /// <summary>
    /// Map of activity code id to activity code
    /// </summary>
    /// <value>Map of activity code id to activity code</value>
    public Dictionary<string, ActivityCode> ActivityCodes { get; set; }

    /// <summary>
    /// Version metadata for the associated management unit's list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated management unit's list of activity codes</value>
    public WfmVersionedEntityMetadata Metadata { get; set; }
}
