using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceEnvironment
{
    /// <summary>
    /// The environment ID
    /// </summary>
    /// <value>The environment ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The environment name
    /// </summary>
    /// <value>The environment name</value>
    public string Name { get; set; }

    /// <summary>
    /// The environment type, usually a value like SANDBOX or PRODUCTION
    /// </summary>
    /// <value>The environment type, usually a value like SANDBOX or PRODUCTION</value>
    public string EnvironmentDesignation { get; set; }

    /// <summary>
    /// The host used to execute this bot, similar to &#39;api.nuance.com:443&#39;
    /// </summary>
    /// <value>The host used to execute this bot, similar to &#39;api.nuance.com:443&#39;</value>
    public string ExecutionHost { get; set; }
}
