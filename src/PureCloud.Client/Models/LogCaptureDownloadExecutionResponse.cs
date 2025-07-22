using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureDownloadExecutionResponse
/// </summary>
public sealed class LogCaptureDownloadExecutionResponse
{
    /// <summary>
    /// Execution state of the download.
    /// </summary>
    /// <value>Execution state of the download.</value>
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }

    /// <summary>
    /// Id of file download job.
    /// </summary>
    /// <value>Id of file download job.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Execution state of the download.
    /// </summary>
    /// <value>Execution state of the download.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// Url of a file with query result.
    /// </summary>
    /// <value>Url of a file with query result.</value>
    [JsonPropertyName("fileUrl")]
    public string FileUrl { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

    /// <summary>
    /// Details of the user that created the job
    /// </summary>
    /// <value>Details of the user that created the job</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }
}