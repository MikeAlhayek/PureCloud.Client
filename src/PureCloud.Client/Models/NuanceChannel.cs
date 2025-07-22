using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceChannel
{
    /// <summary>
    /// The channel ID
    /// </summary>
    /// <value>The channel ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The channel name
    /// </summary>
    /// <value>The channel name</value>
    public string Name { get; set; }

    /// <summary>
    /// Supported Channel Modes
    /// </summary>
    /// <value>Supported Channel Modes</value>
    public IEnumerable<string> Modes { get; set; }

    /// <summary>
    /// The Channel Color
    /// </summary>
    /// <value>The Channel Color</value>
    public string Color { get; set; }
}
