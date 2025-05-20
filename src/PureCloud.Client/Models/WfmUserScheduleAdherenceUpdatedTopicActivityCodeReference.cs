using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserScheduleAdherenceUpdatedTopicActivityCodeReference
{
    /// <summary>
    /// Gets or Sets Id
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryPresences
    /// </summary>
    public IEnumerable<WfmUserScheduleAdherenceUpdatedTopicSecondaryPresenceReference> SecondaryPresences { get; set; }
}
