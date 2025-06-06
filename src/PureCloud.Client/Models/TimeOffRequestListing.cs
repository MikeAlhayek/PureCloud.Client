using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffRequestListing
/// </summary>

public partial class TimeOffRequestListing : IEquatable<TimeOffRequestListing>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestListing" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TimeOffRequestListing() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffRequestListing" /> class.
    /// </summary>
    /// <param name="Entities">List of time off requests (required).</param>
    /// <param name="DownloadUrl">URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl.</param>
    public TimeOffRequestListing(List<TimeOffRequest> Entities = null, string DownloadUrl = null)
    {
        this.Entities = Entities;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// List of time off requests
    /// </summary>
    /// <value>List of time off requests</value>
    [JsonPropertyName("entities")]
    public List<TimeOffRequest> Entities { get; set; }



    /// <summary>
    /// URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl
    /// </summary>
    /// <value>URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffRequestListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as TimeOffRequestListing);
    }

    /// <summary>
    /// Returns true if TimeOffRequestListing instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffRequestListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffRequestListing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
