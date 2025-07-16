using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContactImportJobStatusUpdateResponseStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Continue for "Continue"
    /// </summary>
    [EnumMember(Value = "Continue")]
    Continue,

    /// <summary>
    /// Enum Cancel for "Cancel"
    /// </summary>
    [EnumMember(Value = "Cancel")]
    Cancel,

    /// <summary>
    /// Enum Retry for "Retry"
    /// </summary>
    [EnumMember(Value = "Retry")]
    Retry
}
