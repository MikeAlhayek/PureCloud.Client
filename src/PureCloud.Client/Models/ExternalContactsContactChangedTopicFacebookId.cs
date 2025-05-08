using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsContactChangedTopicFacebookId
{
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    public IEnumerable<ExternalContactsContactChangedTopicFacebookScopedId> Ids { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}
