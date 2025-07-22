using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FunctionRuntimeStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Available for "Available"
    /// </summary>
    [EnumMember(Value = "Available")]
    Available,

    /// <summary>
    /// Enum Deprecated for "Deprecated"
    /// </summary>
    [EnumMember(Value = "Deprecated")]
    Deprecated,

    /// <summary>
    /// Enum Unavailable for "Unavailable"
    /// </summary>
    [EnumMember(Value = "Unavailable")]
    Unavailable
}
