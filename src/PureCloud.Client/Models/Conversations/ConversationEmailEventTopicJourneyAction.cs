using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationEmailEventTopicJourneyAction
{
    /// <summary>
    /// The ID of an action from the Journey System (an action is spawned from an actionMap)
    /// </summary>
    /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public ConversationEmailEventTopicJourneyActionMap ActionMap { get; set; }
}
