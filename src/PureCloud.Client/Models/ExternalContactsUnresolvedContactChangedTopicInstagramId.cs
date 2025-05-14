using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicInstagramId
{
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    public IEnumerable<ExternalContactsUnresolvedContactChangedTopicInstagramScopedId> Ids { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Handle
    /// </summary>
    public string Handle { get; set; }
}
