using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RequestConfig
{
    /// <summary>
    /// URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created.
    /// </summary>
    /// <value>URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created.</value>
    public string RequestUrlTemplate { get; set; }

    /// <summary>
    /// Velocity template to define request body sent to 3rd party service.
    /// </summary>
    /// <value>Velocity template to define request body sent to 3rd party service.</value>
    public string RequestTemplate { get; set; }

    /// <summary>
    /// URI to retrieve requestTemplate
    /// </summary>
    /// <value>URI to retrieve requestTemplate</value>
    public string RequestTemplateUri { get; set; }

    /// <summary>
    /// HTTP method to use for request
    /// </summary>
    /// <value>HTTP method to use for request</value>
    public string RequestType { get; set; }

    /// <summary>
    /// Headers to include in request in (Header Name, Value) pairs.
    /// </summary>
    /// <value>Headers to include in request in (Header Name, Value) pairs.</value>
    public Dictionary<string, string> Headers { get; set; }
}
