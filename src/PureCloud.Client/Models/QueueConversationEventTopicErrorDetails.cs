using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationEventTopicErrorDetails
{
    /// <summary>
    /// The HTTP status code for this message (400, 401, 403, 404, 500, etc.
    /// </summary>
    /// <value>The HTTP status code for this message (400, 401, 403, 404, 500, etc.</value>
    public long? Status { get; set; }

    /// <summary>
    /// A code unique to this error.
    /// </summary>
    /// <value>A code unique to this error.</value>
    public string Code { get; set; }

    /// <summary>
    /// Friendly description of this error.
    /// </summary>
    /// <value>Friendly description of this error.</value>
    public string Message { get; set; }

    /// <summary>
    /// This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;
    /// </summary>
    /// <value>This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;</value>
    public string MessageWithParams { get; set; }

    /// <summary>
    /// Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39;
    /// </summary>
    /// <value>Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39;</value>
    public Dictionary<string, string> MessageParams { get; set; }

    /// <summary>
    /// The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.
    /// </summary>
    /// <value>The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.</value>
    public string ContextId { get; set; }

    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    public string Uri { get; set; }
}
