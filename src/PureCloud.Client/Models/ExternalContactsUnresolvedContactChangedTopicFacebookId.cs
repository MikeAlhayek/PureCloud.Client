using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicFacebookId
{
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    public IEnumerable<ExternalContactsUnresolvedContactChangedTopicFacebookScopedId> Ids { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}
