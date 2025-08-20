using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>
public enum StationStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Available for "AVAILABLE"
    /// </summary>
    [EnumMember(Value = "AVAILABLE")]
    Available,

    /// <summary>
    /// Enum Associated for "ASSOCIATED"
    /// </summary>
    [EnumMember(Value = "ASSOCIATED")]
    Associated
}
