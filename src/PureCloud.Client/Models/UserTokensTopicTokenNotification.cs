using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserTokensTopicTokenNotification
{
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public UserTokensTopicUriReference User { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets TokenExpirationDate
    /// </summary>
    public string TokenExpirationDate { get; set; }

    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets TokenHash
    /// </summary>
    public string TokenHash { get; set; }
}
