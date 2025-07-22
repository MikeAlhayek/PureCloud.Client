using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class NuanceBotCredentials
{
    /// <summary>
    /// The application ID
    /// </summary>
    /// <value>The application ID</value>
    public string AppId { get; set; }

    /// <summary>
    /// The credentials client ID
    /// </summary>
    /// <value>The credentials client ID</value>
    public string ClientId { get; set; }

    /// <summary>
    /// The credentials client secret
    /// </summary>
    /// <value>The credentials client secret</value>
    public string ClientSecret { get; set; }

    /// <summary>
    /// True if the credentials secret is set (but not returned due to security reasons)
    /// </summary>
    /// <value>True if the credentials secret is set (but not returned due to security reasons)</value>
    public bool? ClientSecretProvided { get; set; }
}
