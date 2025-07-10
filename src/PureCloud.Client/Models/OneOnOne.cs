using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OneOnOne
{
    /// <summary>
    /// Room&#39;s pinned messages
    /// </summary>
    /// <value>Room&#39;s pinned messages</value>
    public IEnumerable<AddressableEntityRef> PinnedMessages { get; set; }
}
