using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ApiUsageRow
/// </summary>

public partial class ApiUsageRow : IEquatable<ApiUsageRow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiUsageRow" /> class.
    /// </summary>
    /// <param name="ClientId">Client Id associated with this query result.</param>
    /// <param name="ClientName">Client Name associated with this query result.</param>
    /// <param name="OrganizationId">Organization Id associated with this query result.</param>
    /// <param name="UserId">User Id associated with this query result.</param>
    /// <param name="TemplateUri">Template Uri associated with this query result.</param>
    /// <param name="HttpMethod">HTTP Method associated with this query result.</param>
    /// <param name="Status200">Number of requests resulting in a 2xx HTTP status code.</param>
    /// <param name="Status300">Number of requests resulting in a 3xx HTTP status code.</param>
    /// <param name="Status400">Number of requests resulting in a 4xx HTTP status code.</param>
    /// <param name="Status500">Number of requests resulting in a 5xx HTTP status code.</param>
    /// <param name="Status429">Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400.</param>
    /// <param name="Requests">Total number of requests.</param>
    /// <param name="Date">Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ApiUsageRow(string ClientId = null, string ClientName = null, string OrganizationId = null, string UserId = null, string TemplateUri = null, string HttpMethod = null, long? Status200 = null, long? Status300 = null, long? Status400 = null, long? Status500 = null, long? Status429 = null, long? Requests = null, DateTime? Date = null)
    {
        this.ClientId = ClientId;
        this.ClientName = ClientName;
        this.OrganizationId = OrganizationId;
        this.UserId = UserId;
        this.TemplateUri = TemplateUri;
        this.HttpMethod = HttpMethod;
        this.Status200 = Status200;
        this.Status300 = Status300;
        this.Status400 = Status400;
        this.Status500 = Status500;
        this.Status429 = Status429;
        this.Requests = Requests;
        this.Date = Date;

    }



    /// <summary>
    /// Client Id associated with this query result
    /// </summary>
    /// <value>Client Id associated with this query result</value>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }



    /// <summary>
    /// Client Name associated with this query result
    /// </summary>
    /// <value>Client Name associated with this query result</value>
    [JsonPropertyName("clientName")]
    public string ClientName { get; set; }



    /// <summary>
    /// Organization Id associated with this query result
    /// </summary>
    /// <value>Organization Id associated with this query result</value>
    [JsonPropertyName("organizationId")]
    public string OrganizationId { get; set; }



    /// <summary>
    /// User Id associated with this query result
    /// </summary>
    /// <value>User Id associated with this query result</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Template Uri associated with this query result
    /// </summary>
    /// <value>Template Uri associated with this query result</value>
    [JsonPropertyName("templateUri")]
    public string TemplateUri { get; set; }



    /// <summary>
    /// HTTP Method associated with this query result
    /// </summary>
    /// <value>HTTP Method associated with this query result</value>
    [JsonPropertyName("httpMethod")]
    public string HttpMethod { get; set; }



    /// <summary>
    /// Number of requests resulting in a 2xx HTTP status code
    /// </summary>
    /// <value>Number of requests resulting in a 2xx HTTP status code</value>
    [JsonPropertyName("status200")]
    public long? Status200 { get; set; }



    /// <summary>
    /// Number of requests resulting in a 3xx HTTP status code
    /// </summary>
    /// <value>Number of requests resulting in a 3xx HTTP status code</value>
    [JsonPropertyName("status300")]
    public long? Status300 { get; set; }



    /// <summary>
    /// Number of requests resulting in a 4xx HTTP status code
    /// </summary>
    /// <value>Number of requests resulting in a 4xx HTTP status code</value>
    [JsonPropertyName("status400")]
    public long? Status400 { get; set; }



    /// <summary>
    /// Number of requests resulting in a 5xx HTTP status code
    /// </summary>
    /// <value>Number of requests resulting in a 5xx HTTP status code</value>
    [JsonPropertyName("status500")]
    public long? Status500 { get; set; }



    /// <summary>
    /// Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400
    /// </summary>
    /// <value>Number of requests resulting in a 429 HTTP status code, this is a subset of the count returned with status400</value>
    [JsonPropertyName("status429")]
    public long? Status429 { get; set; }



    /// <summary>
    /// Total number of requests
    /// </summary>
    /// <value>Total number of requests</value>
    [JsonPropertyName("requests")]
    public long? Requests { get; set; }



    /// <summary>
    /// Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of requests, based on granularity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ApiUsageRow {\n");

        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  ClientName: ").Append(ClientName).Append("\n");
        sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  TemplateUri: ").Append(TemplateUri).Append("\n");
        sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
        sb.Append("  Status200: ").Append(Status200).Append("\n");
        sb.Append("  Status300: ").Append(Status300).Append("\n");
        sb.Append("  Status400: ").Append(Status400).Append("\n");
        sb.Append("  Status500: ").Append(Status500).Append("\n");
        sb.Append("  Status429: ").Append(Status429).Append("\n");
        sb.Append("  Requests: ").Append(Requests).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
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
        return Equals(obj as ApiUsageRow);
    }

    /// <summary>
    /// Returns true if ApiUsageRow instances are equal
    /// </summary>
    /// <param name="other">Instance of ApiUsageRow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ApiUsageRow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ClientId == other.ClientId ||
                ClientId != null &&
                ClientId.Equals(other.ClientId)
            ) &&
            (
                ClientName == other.ClientName ||
                ClientName != null &&
                ClientName.Equals(other.ClientName)
            ) &&
            (
                OrganizationId == other.OrganizationId ||
                OrganizationId != null &&
                OrganizationId.Equals(other.OrganizationId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                TemplateUri == other.TemplateUri ||
                TemplateUri != null &&
                TemplateUri.Equals(other.TemplateUri)
            ) &&
            (
                HttpMethod == other.HttpMethod ||
                HttpMethod != null &&
                HttpMethod.Equals(other.HttpMethod)
            ) &&
            (
                Status200 == other.Status200 ||
                Status200 != null &&
                Status200.Equals(other.Status200)
            ) &&
            (
                Status300 == other.Status300 ||
                Status300 != null &&
                Status300.Equals(other.Status300)
            ) &&
            (
                Status400 == other.Status400 ||
                Status400 != null &&
                Status400.Equals(other.Status400)
            ) &&
            (
                Status500 == other.Status500 ||
                Status500 != null &&
                Status500.Equals(other.Status500)
            ) &&
            (
                Status429 == other.Status429 ||
                Status429 != null &&
                Status429.Equals(other.Status429)
            ) &&
            (
                Requests == other.Requests ||
                Requests != null &&
                Requests.Equals(other.Requests)
            ) &&
            (
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
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
            if (ClientId != null)
            {
                hash = hash * 59 + ClientId.GetHashCode();
            }

            if (ClientName != null)
            {
                hash = hash * 59 + ClientName.GetHashCode();
            }

            if (OrganizationId != null)
            {
                hash = hash * 59 + OrganizationId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (TemplateUri != null)
            {
                hash = hash * 59 + TemplateUri.GetHashCode();
            }

            if (HttpMethod != null)
            {
                hash = hash * 59 + HttpMethod.GetHashCode();
            }

            if (Status200 != null)
            {
                hash = hash * 59 + Status200.GetHashCode();
            }

            if (Status300 != null)
            {
                hash = hash * 59 + Status300.GetHashCode();
            }

            if (Status400 != null)
            {
                hash = hash * 59 + Status400.GetHashCode();
            }

            if (Status500 != null)
            {
                hash = hash * 59 + Status500.GetHashCode();
            }

            if (Status429 != null)
            {
                hash = hash * 59 + Status429.GetHashCode();
            }

            if (Requests != null)
            {
                hash = hash * 59 + Requests.GetHashCode();
            }

            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            return hash;
        }
    }
}
