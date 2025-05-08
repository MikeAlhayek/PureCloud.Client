using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CustomerStartDetailEventTopicJourneyContext
{
    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or Sets SessionIdType
    /// </summary>
    public string SessionIdType { get; set; }

    /// <summary>
    /// Gets or Sets ActionId
    /// </summary>
    public string ActionId { get; set; }

    /// <summary>
    /// Gets or Sets ActionMapId
    /// </summary>
    public string ActionMapId { get; set; }
}
