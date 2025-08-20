using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAsyncScheduleResponseStatus
/// </summary>
public enum BuAsyncScheduleResponseStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Processing
    /// </summary>
    [EnumMember(Value = "Processing")]
    Processing,

    /// <summary>
    /// Complete
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete,

    /// <summary>
    /// Canceled
    /// </summary>
    [EnumMember(Value = "Canceled")]
    Canceled,

    /// <summary>
    /// Error
    /// </summary>
    [EnumMember(Value = "Error")]
    Error
}
