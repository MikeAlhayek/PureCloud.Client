using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatFavorite
{
    /// <summary>
    /// The guid id of the favorite
    /// </summary>
    /// <value>The guid id of the favorite</value>
    public string Id { get; set; }

    /// <summary>
    /// The external id of the favorite
    /// </summary>
    /// <value>The external id of the favorite</value>
    public string ExternalId { get; set; }
}
