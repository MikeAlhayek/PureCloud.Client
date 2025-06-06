using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureQueryRequest
/// </summary>

public partial class LogCaptureQueryRequest : IEquatable<LogCaptureQueryRequest>
{
    /// <summary>
    /// Order of results. Default order is ASC.
    /// </summary>
    /// <value>Order of results. Default order is ASC.</value>
    
    public enum SortOrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        Asc,

        /// <summary>
        /// Enum Desc for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        Desc
    }
    /// <summary>
    /// Order of results. Default order is ASC.
    /// </summary>
    /// <value>Order of results. Default order is ASC.</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureQueryRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LogCaptureQueryRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureQueryRequest" /> class.
    /// </summary>
    /// <param name="Interval">Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="UserId">Id of the user to query. (required).</param>
    /// <param name="SortOrder">Order of results. Default order is ASC..</param>
    public LogCaptureQueryRequest(string Interval = null, string UserId = null, SortOrderEnum? SortOrder = null)
    {
        this.Interval = Interval;
        this.UserId = UserId;
        this.SortOrder = SortOrder;

    }



    /// <summary>
    /// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Id of the user to query.
    /// </summary>
    /// <value>Id of the user to query.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LogCaptureQueryRequest {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
        return Equals(obj as LogCaptureQueryRequest);
    }

    /// <summary>
    /// Returns true if LogCaptureQueryRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LogCaptureQueryRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LogCaptureQueryRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                SortOrder == other.SortOrder ||
                SortOrder != null &&
                SortOrder.Equals(other.SortOrder)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            return hash;
        }
    }
}
