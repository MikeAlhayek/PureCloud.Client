using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines response components of the Action Request.
/// </summary>

public partial class RequestConfig : IEquatable<RequestConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestConfig" /> class.
    /// </summary>
    /// <param name="RequestUrlTemplate">URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created..</param>
    /// <param name="RequestTemplate">Velocity template to define request body sent to 3rd party service..</param>
    /// <param name="RequestTemplateUri">URI to retrieve requestTemplate.</param>
    /// <param name="RequestType">HTTP method to use for request.</param>
    /// <param name="Headers">Headers to include in request in (Header Name, Value) pairs..</param>
    public RequestConfig(string RequestUrlTemplate = null, string RequestTemplate = null, string RequestTemplateUri = null, string RequestType = null, Dictionary<string, string> Headers = null)
    {
        this.RequestUrlTemplate = RequestUrlTemplate;
        this.RequestTemplate = RequestTemplate;
        this.RequestTemplateUri = RequestTemplateUri;
        this.RequestType = RequestType;
        this.Headers = Headers;

    }



    /// <summary>
    /// URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created.
    /// </summary>
    /// <value>URL that may include placeholders for requests to 3rd party service. This value is read only for Function Integrations and will be set when a draft is created.</value>
    [JsonPropertyName("requestUrlTemplate")]
    public string RequestUrlTemplate { get; set; }



    /// <summary>
    /// Velocity template to define request body sent to 3rd party service.
    /// </summary>
    /// <value>Velocity template to define request body sent to 3rd party service.</value>
    [JsonPropertyName("requestTemplate")]
    public string RequestTemplate { get; set; }



    /// <summary>
    /// URI to retrieve requestTemplate
    /// </summary>
    /// <value>URI to retrieve requestTemplate</value>
    [JsonPropertyName("requestTemplateUri")]
    public string RequestTemplateUri { get; set; }



    /// <summary>
    /// HTTP method to use for request
    /// </summary>
    /// <value>HTTP method to use for request</value>
    [JsonPropertyName("requestType")]
    public string RequestType { get; set; }



    /// <summary>
    /// Headers to include in request in (Header Name, Value) pairs.
    /// </summary>
    /// <value>Headers to include in request in (Header Name, Value) pairs.</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestConfig {\n");

        sb.Append("  RequestUrlTemplate: ").Append(RequestUrlTemplate).Append("\n");
        sb.Append("  RequestTemplate: ").Append(RequestTemplate).Append("\n");
        sb.Append("  RequestTemplateUri: ").Append(RequestTemplateUri).Append("\n");
        sb.Append("  RequestType: ").Append(RequestType).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as RequestConfig);
    }

    /// <summary>
    /// Returns true if RequestConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RequestUrlTemplate == other.RequestUrlTemplate ||
                RequestUrlTemplate != null &&
                RequestUrlTemplate.Equals(other.RequestUrlTemplate)
            ) &&
            (
                RequestTemplate == other.RequestTemplate ||
                RequestTemplate != null &&
                RequestTemplate.Equals(other.RequestTemplate)
            ) &&
            (
                RequestTemplateUri == other.RequestTemplateUri ||
                RequestTemplateUri != null &&
                RequestTemplateUri.Equals(other.RequestTemplateUri)
            ) &&
            (
                RequestType == other.RequestType ||
                RequestType != null &&
                RequestType.Equals(other.RequestType)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (RequestUrlTemplate != null)
            {
                hash = hash * 59 + RequestUrlTemplate.GetHashCode();
            }

            if (RequestTemplate != null)
            {
                hash = hash * 59 + RequestTemplate.GetHashCode();
            }

            if (RequestTemplateUri != null)
            {
                hash = hash * 59 + RequestTemplateUri.GetHashCode();
            }

            if (RequestType != null)
            {
                hash = hash * 59 + RequestType.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            return hash;
        }
    }
}
