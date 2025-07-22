using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceGeography
{
    /// <summary>
    /// The geography ID
    /// </summary>
    /// <value>The geography ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The geography name
    /// </summary>
    /// <value>The geography name</value>
    public string Name { get; set; }
}
