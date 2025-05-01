using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WeekScheduleResponse
/// </summary>
[DataContract]
public partial class WeekScheduleResponse : IEquatable<WeekScheduleResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeekScheduleResponse" /> class.
    /// </summary>
    /// <param name="Result">The result of the request. The value will be null if response is large.</param>
    /// <param name="DownloadUrl">The url to fetch the result for large responses. The value is null if result contains the data.</param>
    public WeekScheduleResponse(WeekSchedule Result = null, string DownloadUrl = null)
    {
        this.Result = Result;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The result of the request. The value will be null if response is large
    /// </summary>
    /// <value>The result of the request. The value will be null if response is large</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public WeekSchedule Result { get; set; }



    /// <summary>
    /// The url to fetch the result for large responses. The value is null if result contains the data
    /// </summary>
    /// <value>The url to fetch the result for large responses. The value is null if result contains the data</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WeekScheduleResponse {\n");

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
        return Equals(obj as WeekScheduleResponse);
    }

    /// <summary>
    /// Returns true if WeekScheduleResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WeekScheduleResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WeekScheduleResponse other)
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
