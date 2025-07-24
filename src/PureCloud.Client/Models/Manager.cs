using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM manager.
/// </summary>
public sealed class Manager
{
    /// <summary>
    /// The ID of the manager.
    /// </summary>
    /// <value>The ID of the manager.</value>
    public string Value { get; set; }

    /// <summary>
    /// The reference URI of the manager's user record.
    /// </summary>
    /// <value>The reference URI of the manager's user record.</value>
    public string Ref { get; set; }
}
