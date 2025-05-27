using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthzGrantPolicy
{
    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    public IEnumerable<string> Actions { get; set; }

    /// <summary>
    /// Gets or Sets Condition
    /// </summary>
    public string Condition { get; set; }

    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    public string EntityName { get; set; }
}
