using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BuHeadcountForecastResponse
/// </summary>
[DataContract]
public partial class BuHeadcountForecastResponse : IEquatable<BuHeadcountForecastResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuHeadcountForecastResponse" /> class.
    /// </summary>
    /// <param name="Result">The headcount forecast, null when downloadUrl is provided.</param>
    /// <param name="DownloadUrl">Download URL.  Null unless the response is too large to pass directly through the api.</param>
    public BuHeadcountForecastResponse(BuHeadcountForecast Result = null, string DownloadUrl = null)
    {
        this.Result = Result;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The headcount forecast, null when downloadUrl is provided
    /// </summary>
    /// <value>The headcount forecast, null when downloadUrl is provided</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public BuHeadcountForecast Result { get; set; }



    /// <summary>
    /// Download URL.  Null unless the response is too large to pass directly through the api
    /// </summary>
    /// <value>Download URL.  Null unless the response is too large to pass directly through the api</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuHeadcountForecastResponse {\n");

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
        return Equals(obj as BuHeadcountForecastResponse);
    }

    /// <summary>
    /// Returns true if BuHeadcountForecastResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuHeadcountForecastResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuHeadcountForecastResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
