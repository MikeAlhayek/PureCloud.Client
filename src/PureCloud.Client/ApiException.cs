namespace PureCloud.Client;

/// <summary>
/// API Exception
/// </summary>
public class ApiException : Exception
{
    /// <summary>
    /// Gets or sets the error code (HTTP status code)
    /// </summary>
    /// <value>The error code (HTTP status code).</value>
    public int ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the error content (body json object)
    /// </summary>
    /// <value>The error content (HTTP response body).</value>
    public dynamic ErrorContent { get; set; }

    /// <summary>
    /// Gets or sets the HTTP headers
    /// </summary>
    /// <value>HTTP headers</value>
    public IDictionary<string, string> Headers { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    public ApiException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    /// <param name="errorCode">HTTP status code.</param>
    /// <param name="message">Error message.</param>
    public ApiException(int errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiException"/> class.
    /// </summary>
    /// <param name="errorCode">HTTP status code.</param>
    /// <param name="message">Error message.</param>
    /// <param name="errorContent">Error content.</param>
    /// <param name="headers">HTTP headers.</param>
    public ApiException(int errorCode, string message, dynamic errorContent = null, IDictionary<string, string> headers = null) : base(message)
    {
        ErrorCode = errorCode;
        ErrorContent = errorContent;
        Headers = headers;
    }
}
