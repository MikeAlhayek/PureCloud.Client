using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuTimeOffPlanListing
/// </summary>
[DataContract]
public partial class BuTimeOffPlanListing : IEquatable<BuTimeOffPlanListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuTimeOffPlanListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="DownloadUrl">URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl.</param>
    public BuTimeOffPlanListing(List<BuTimeOffPlanResponse> Entities = null, string DownloadUrl = null)
    {
        this.Entities = Entities;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<BuTimeOffPlanResponse> Entities { get; set; }



    /// <summary>
    /// URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl
    /// </summary>
    /// <value>URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuTimeOffPlanListing {\n");

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
        return Equals(obj as BuTimeOffPlanListing);
    }

    /// <summary>
    /// Returns true if BuTimeOffPlanListing instances are equal
    /// </summary>
    /// <param name="other">Instance of BuTimeOffPlanListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuTimeOffPlanListing other)
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
