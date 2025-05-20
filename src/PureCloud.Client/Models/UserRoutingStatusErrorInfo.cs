using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserRoutingStatusErrorInfo
{
    /// <summary>
    /// A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND
    /// </summary>
    /// <value>A code unique to this error. Typically prefixed with the service that originated the error. For example CONFIG_USER_NOT_FOUND</value>
    public string ErrorCode { get; set; }

    /// <summary>
    /// The HTTP status code for this message. If left blank the status code from the HTTP response is used.
    /// </summary>
    /// <value>The HTTP status code for this message. If left blank the status code from the HTTP response is used.</value>
    public long? Status { get; set; }

    /// <summary>
    /// The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.
    /// </summary>
    /// <value>The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.</value>
    public string CorrelationId { get; set; }

    /// <summary>
    /// A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id
    /// </summary>
    /// <value>A customer friendly message. This should be a complete sentence, use proper grammar and only include information useful to a customer. This is not a dev message and should not include things like Org Id</value>
    public string UserMessage { get; set; }

    /// <summary>
    /// This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;
    /// </summary>
    /// <value>This is the same as userMessage except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;</value>
    public string UserParamsMessage { get; set; }

    /// <summary>
    /// Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39;
    /// </summary>
    /// <value>Used in conjunction with userParamsMessage. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;chuck.pulfer&#39;</value>
    public IEnumerable<UserRoutingStatusUserParam> UserParams { get; set; }
}
