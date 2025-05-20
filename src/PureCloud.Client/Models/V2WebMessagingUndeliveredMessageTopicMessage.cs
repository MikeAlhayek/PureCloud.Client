using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WebMessagingUndeliveredMessageTopicMessage
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets EventTimeMs
    /// </summary>
    public long? EventTimeMs { get; set; }
}
