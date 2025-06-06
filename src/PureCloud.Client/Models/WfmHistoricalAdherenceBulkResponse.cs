using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceBulkResponse
/// </summary>

public partial class WfmHistoricalAdherenceBulkResponse : IEquatable<WfmHistoricalAdherenceBulkResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkResponse" /> class.
    /// </summary>
    /// <param name="Job">A reference to the job that was started by the request.</param>
    /// <param name="DownloadUrls">The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete.</param>
    /// <param name="DownloadResult">Results will always come via downloadUrls; however the schema is included for documentation.</param>
    public WfmHistoricalAdherenceBulkResponse(WfmHistoricalAdherenceBulkJobReference Job = null, List<string> DownloadUrls = null, WfmHistoricalAdherenceBulkResult DownloadResult = null)
    {
        this.Job = Job;
        this.DownloadUrls = DownloadUrls;
        this.DownloadResult = DownloadResult;

    }



    /// <summary>
    /// A reference to the job that was started by the request
    /// </summary>
    /// <value>A reference to the job that was started by the request</value>
    [JsonPropertyName("job")]
    public WfmHistoricalAdherenceBulkJobReference Job { get; set; }



    /// <summary>
    /// The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete
    /// </summary>
    /// <value>The uri list to GET the results of the Historical Adherence query. This field is populated only if query state is Complete</value>
    [JsonPropertyName("downloadUrls")]
    public List<string> DownloadUrls { get; set; }



    /// <summary>
    /// Results will always come via downloadUrls; however the schema is included for documentation
    /// </summary>
    /// <value>Results will always come via downloadUrls; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public WfmHistoricalAdherenceBulkResult DownloadResult { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceBulkResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
        sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceBulkResponse);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceBulkResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceBulkResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceBulkResponse other)
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
                DownloadUrls == other.DownloadUrls ||
                DownloadUrls != null &&
                DownloadUrls.SequenceEqual(other.DownloadUrls)
            ) &&
            (
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
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

            if (DownloadUrls != null)
            {
                hash = hash * 59 + DownloadUrls.GetHashCode();
            }

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
            }

            return hash;
        }
    }
}
