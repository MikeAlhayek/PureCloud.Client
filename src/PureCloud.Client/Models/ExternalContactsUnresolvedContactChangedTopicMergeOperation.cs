using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicMergeOperation
{
    /// <summary>
    /// Gets or Sets SourceContactId
    /// </summary>
    public string SourceContactId { get; set; }

    /// <summary>
    /// Gets or Sets TargetContactId
    /// </summary>
    public string TargetContactId { get; set; }

    /// <summary>
    /// Gets or Sets ResultingContactId
    /// </summary>
    public string ResultingContactId { get; set; }
}
