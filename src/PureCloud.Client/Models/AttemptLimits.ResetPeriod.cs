using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// After how long the number of attempts will be set back to 0. Defaults to NEVER.
/// </summary>
/// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
public enum AttemptLimitsResetPeriodEnum
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