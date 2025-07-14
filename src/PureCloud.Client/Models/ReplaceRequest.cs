using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReplaceRequest
{
    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    public int? ChangeNumber { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    public string AuthToken { get; set; }
}
