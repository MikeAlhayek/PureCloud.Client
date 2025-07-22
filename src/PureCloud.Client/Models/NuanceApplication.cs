using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceApplication
{
    /// <summary>
    /// The application ID
    /// </summary>
    /// <value>The application ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The application Tag
    /// </summary>
    /// <value>The application Tag</value>
    public string Tag { get; set; }

    /// <summary>
    /// The application name
    /// </summary>
    /// <value>The application name</value>
    public string Name { get; set; }
}
