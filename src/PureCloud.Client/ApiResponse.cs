namespace PureCloud.Client;

/// <summary>
/// API Response
/// </summary>
public class ApiResponse<T>
{
    /// <summary>
    /// Gets or sets the status code (HTTP status code)
    /// </summary>
    /// <value>The status code.</value>
    public int StatusCode { get; set; }

    /// <summary>
    /// Gets or sets the response HTTP headers
    /// </summary>
    /// <value>HTTP headers</value>
    public IDictionary<string, string> Headers { get; set; }

    /// <summary>
    /// Gets or sets the data (parsed HTTP body)
    /// </summary>
    /// <value>The data.</value>
    public T Data { get; set; }

    /// <summary>
    /// Gets or sets the raw data (un-parsed HTTP body)
    /// </summary>
    public string RawData { get; set; }

    /// <summary>
    /// Gets or sets the status description (HTTP status description)
    /// </summary>
    public string StatusDescription { get; set; }

    /// <summary>
    /// Gets the inin-correlation-id header's value
    /// </summary>
    public string CorrelationId
    {
        get
        {
            return Headers.FirstOrDefault(h => h.Key.ToLowerInvariant() == "inin-correlation-id").Value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
    /// </summary>
    /// <param name="statusCode">HTTP status code.</param>
    /// <param name="headers">HTTP headers.</param>
    /// <param name="data">Data (parsed HTTP body)</param>
    /// <param name="rawData">Raw data (un-parsed HTTP body)</param>
    /// <param name="statusDescription">Status description (HTTP status description)</param>
    public ApiResponse(int statusCode, IDictionary<string, string> headers, T data, string rawData, string statusDescription)
    {
        StatusCode = statusCode;
        Headers = headers;
        Data = data;
        RawData = rawData;
        StatusDescription = statusDescription;
    }
}
