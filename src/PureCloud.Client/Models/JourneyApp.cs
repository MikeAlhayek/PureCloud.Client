using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyApp
{
    /// <summary>
    /// Name of the application (e.g. mybankingapp).
    /// </summary>
    /// <value>Name of the application (e.g. mybankingapp).</value>
    public string Name { get; set; }

    /// <summary>
    /// Namespace of the application (e.g. com.genesys.bancodinero).
    /// </summary>
    /// <value>Namespace of the application (e.g. com.genesys.bancodinero).</value>
    public string Namespace { get; set; }

    /// <summary>
    /// Version of the application (e.g. 5.9.27).
    /// </summary>
    /// <value>Version of the application (e.g. 5.9.27).</value>
    public string Version { get; set; }

    /// <summary>
    /// Build number of the application (e.g. 701).
    /// </summary>
    /// <value>Build number of the application (e.g. 701).</value>
    public string BuildNumber { get; set; }
}
