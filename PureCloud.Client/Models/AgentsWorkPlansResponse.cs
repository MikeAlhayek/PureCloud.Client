using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentsWorkPlansResponse
/// </summary>

public partial class AgentsWorkPlansResponse : IEquatable<AgentsWorkPlansResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentsWorkPlansResponse" /> class.
    /// </summary>
    /// <param name="DownloadUrl">URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl.</param>
    /// <param name="Result">The result of agent(s) work plans query.</param>
    public AgentsWorkPlansResponse(string DownloadUrl = null, MuAgentsWorkPlansResult Result = null)
    {
        this.DownloadUrl = DownloadUrl;
        this.Result = Result;

    }



    /// <summary>
    /// URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl
    /// </summary>
    /// <value>URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// The result of agent(s) work plans query
    /// </summary>
    /// <value>The result of agent(s) work plans query</value>
    [JsonPropertyName("result")]
    public MuAgentsWorkPlansResult Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentsWorkPlansResponse {\n");

        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as AgentsWorkPlansResponse);
    }

    /// <summary>
    /// Returns true if AgentsWorkPlansResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentsWorkPlansResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentsWorkPlansResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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
            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}
