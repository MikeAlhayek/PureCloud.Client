using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryPresences
    /// </summary>
    public IEnumerable<WfmUserScheduleAdherenceUpdatedMuTopicSecondaryPresenceReference> SecondaryPresences { get; set; }
}
