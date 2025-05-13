using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerResponsesetConfigChangeReaction
{
    /// <summary>
    /// Gets or Sets ReactionType
    /// </summary>
    public DialerResponsesetConfigChangeReactionReactionTypeEnum? ReactionType { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public string Data { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
