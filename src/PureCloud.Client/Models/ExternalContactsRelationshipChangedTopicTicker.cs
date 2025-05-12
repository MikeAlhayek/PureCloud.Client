using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsRelationshipChangedTopicTicker
{
    /// <summary>
    /// Gets or Sets Symbol
    /// </summary>
    public string Symbol { get; set; }

    /// <summary>
    /// Gets or Sets Exchange
    /// </summary>
    public string Exchange { get; set; }
}
