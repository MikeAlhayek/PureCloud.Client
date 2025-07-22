using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureUserConfiguration
/// </summary>
public sealed class LogCaptureUserConfiguration
{
    /// <summary>
    /// Indicates the method by which the logs were captured.
    /// </summary>
    /// <value>Indicates the method by which the logs were captured.</value>
    public enum CaptureMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ondemand for "OnDemand"
        /// </summary>
        [EnumMember(Value = "OnDemand")]
        Ondemand,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled
    }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }

    /// <summary>
    /// Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpired")]
    public DateTime? DateExpired { get; set; }

    /// <summary>
    /// Indicates the method by which the logs were captured.
    /// </summary>
    /// <value>Indicates the method by which the logs were captured.</value>
    [JsonPropertyName("captureMethod")]
    public CaptureMethodEnum? CaptureMethod { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }
}