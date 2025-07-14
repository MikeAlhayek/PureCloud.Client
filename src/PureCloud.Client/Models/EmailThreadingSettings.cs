using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailThreadingSettings
{
    /// <summary>
    /// This setting controls whether a new conversation is started if the subject of an inbound email is different from the subject of the current conversation. RE: and FWD: prefixes in any language are ignored.
    /// </summary>
    /// <value>This setting controls whether a new conversation is started if the subject of an inbound email is different from the subject of the current conversation. RE: and FWD: prefixes in any language are ignored.</value>
    public bool? StartNewConversationOnSubjectChange { get; set; }

    /// <summary>
    /// In minutes, how long an email conversation should keep being threaded after being disconnected.
    /// </summary>
    /// <value>In minutes, how long an email conversation should keep being threaded after being disconnected.</value>
    public long? TimeoutInMinutes { get; set; }
}
