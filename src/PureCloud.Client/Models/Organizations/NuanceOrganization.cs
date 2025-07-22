using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceOrganization
{
    /// <summary>
    /// The organization ID
    /// </summary>
    /// <value>The organization ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The organization name
    /// </summary>
    /// <value>The organization name</value>
    public string Name { get; set; }
}
