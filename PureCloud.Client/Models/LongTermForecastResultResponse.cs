using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LongTermForecastResultResponse
/// </summary>
[DataContract]
public partial class LongTermForecastResultResponse : IEquatable<LongTermForecastResultResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LongTermForecastResultResponse" /> class.
    /// </summary>
    /// <param name="Result">The result of the operation.  Populated whenever the result is small enough to pass through the api directly.</param>
    /// <param name="DownloadUrl">The download url to fetch the result.  Only populated if the result is too large to pass through the api directly.</param>
    public LongTermForecastResultResponse(LongTermForecastResult Result = null, string DownloadUrl = null)
    {
        this.Result = Result;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The result of the operation.  Populated whenever the result is small enough to pass through the api directly
    /// </summary>
    /// <value>The result of the operation.  Populated whenever the result is small enough to pass through the api directly</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public LongTermForecastResult Result { get; set; }



    /// <summary>
    /// The download url to fetch the result.  Only populated if the result is too large to pass through the api directly
    /// </summary>
    /// <value>The download url to fetch the result.  Only populated if the result is too large to pass through the api directly</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LongTermForecastResultResponse {\n");

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
        return Equals(obj as LongTermForecastResultResponse);
    }

    /// <summary>
    /// Returns true if LongTermForecastResultResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LongTermForecastResultResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LongTermForecastResultResponse other)
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
