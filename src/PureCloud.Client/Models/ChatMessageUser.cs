using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMessageUser
/// </summary>
public sealed class ChatMessageUser
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public IEnumerable<Image> Images { get; set; }
}
