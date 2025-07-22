using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PublishDraftInput
{
    /// <summary>
    /// The current draft version.
    /// </summary>
    /// <value>The current draft version.</value>
    public int? Version { get; set; }
}
