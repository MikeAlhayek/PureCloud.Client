using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchShiftTradesResponse
/// </summary>
[DataContract]
public partial class SearchShiftTradesResponse : IEquatable<SearchShiftTradesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchShiftTradesResponse" /> class.
    /// </summary>
    /// <param name="Trades">The shift trades that match the search criteria.</param>
    /// <param name="DownloadUrl">URL from which to fetch results for requests with a large result set. If populated, the downloaded data will conform to the same schema as would normally be returned, excepting downloaded data will never itself contain a downloadUrl.</param>
    public SearchShiftTradesResponse(List<SearchShiftTradeResponse> Trades = null, string DownloadUrl = null)
    {
        this.Trades = Trades;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The shift trades that match the search criteria
    /// </summary>
    /// <value>The shift trades that match the search criteria</value>
    [DataMember(Name = "trades", EmitDefaultValue = false)]
    public List<SearchShiftTradeResponse> Trades { get; set; }



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
        sb.Append("class SearchShiftTradesResponse {\n");

        sb.Append("  Trades: ").Append(Trades).Append("\n");
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
        return Equals(obj as SearchShiftTradesResponse);
    }

    /// <summary>
    /// Returns true if SearchShiftTradesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchShiftTradesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchShiftTradesResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Trades == other.Trades ||
                Trades != null &&
                Trades.SequenceEqual(other.Trades)
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
            if (Trades != null)
            {
                hash = hash * 59 + Trades.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
