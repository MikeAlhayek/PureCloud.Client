namespace PureCloud.Client;

/// <summary>
/// Represents configuration aspects required to interact with the API endpoints.
/// </summary>
public interface IApiAccessor
{
    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    Configuration Configuration { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    string GetBasePath();
}
