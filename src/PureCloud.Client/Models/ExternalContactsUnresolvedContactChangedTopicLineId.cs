using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicLineId
{
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    public IEnumerable<ExternalContactsUnresolvedContactChangedTopicLineUserId> Ids { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}
