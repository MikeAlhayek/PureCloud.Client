using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>

public enum WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotificationStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Processing for "Processing"
    /// </summary>
    [EnumMember(Value = "Processing")]
    Processing,

    /// <summary>
    /// Enum Complete for "Complete"
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error
}
