using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatReaction
{
    /// <summary>
    /// The emoji string for the reaction
    /// </summary>
    /// <value>The emoji string for the reaction</value>
    public string Emoji { get; set; }

    /// <summary>
    /// The users that reacted with an emoji
    /// </summary>
    /// <value>The users that reacted with an emoji</value>
    public IEnumerable<AddressableEntityRef> Users { get; set; }
}
