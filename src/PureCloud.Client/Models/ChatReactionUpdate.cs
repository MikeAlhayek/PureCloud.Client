using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatReactionUpdate
{
    /// <summary>
    /// Reactions to update
    /// </summary>
    /// <value>Reactions to update</value>
    public IEnumerable<string> Reactions { get; set; }
}
