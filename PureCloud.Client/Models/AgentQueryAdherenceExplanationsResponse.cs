using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentQueryAdherenceExplanationsResponse
/// </summary>
[DataContract]
public partial class AgentQueryAdherenceExplanationsResponse : IEquatable<AgentQueryAdherenceExplanationsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentQueryAdherenceExplanationsResponse" /> class.
    /// </summary>
    /// <param name="Job">The asynchronous job handling the query.</param>
    /// <param name="Result">The result of the query. May come via notification.</param>
    /// <param name="DownloadUrl">The URL from which to download the result. May come via notification.</param>
    public AgentQueryAdherenceExplanationsResponse(AdherenceExplanationJobReference Job = null, AdherenceExplanationListingAgentQueryResponse Result = null, string DownloadUrl = null)
    {
        this.Job = Job;
        this.Result = Result;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The asynchronous job handling the query
    /// </summary>
    /// <value>The asynchronous job handling the query</value>
    [DataMember(Name = "job", EmitDefaultValue = false)]
    public AdherenceExplanationJobReference Job { get; set; }



    /// <summary>
    /// The result of the query. May come via notification
    /// </summary>
    /// <value>The result of the query. May come via notification</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public AdherenceExplanationListingAgentQueryResponse Result { get; set; }



    /// <summary>
    /// The URL from which to download the result. May come via notification
    /// </summary>
    /// <value>The URL from which to download the result. May come via notification</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentQueryAdherenceExplanationsResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
        return Equals(obj as AgentQueryAdherenceExplanationsResponse);
    }

    /// <summary>
    /// Returns true if AgentQueryAdherenceExplanationsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentQueryAdherenceExplanationsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentQueryAdherenceExplanationsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Job == other.Job ||
                Job != null &&
                Job.Equals(other.Job)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
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
            if (Job != null)
            {
                hash = hash * 59 + Job.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
