using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureQueryRequest
/// </summary>
public sealed class LogCaptureQueryRequest
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
    /// Order of results. Default order is ASC.
    /// </summary>
    /// <value>Order of results. Default order is ASC.</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }
}