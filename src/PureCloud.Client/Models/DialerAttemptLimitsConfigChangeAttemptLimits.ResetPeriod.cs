using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerAttemptLimitsConfigChangeAttemptLimitsResetPeriodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Never for "NEVER"
    /// </summary>
    [EnumMember(Value = "NEVER")]
    Never,

    /// <summary>
    /// Enum Today for "TODAY"
    /// </summary>
    [EnumMember(Value = "TODAY")]
    Today
}
