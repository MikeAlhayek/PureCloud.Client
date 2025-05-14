using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicExternalId
{
    /// <summary>
    /// Gets or Sets ExternalSource
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicExternalSource ExternalSource { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
