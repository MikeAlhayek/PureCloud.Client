using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum MaskingRuleTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Custom for "Custom"
    /// </summary>
    [EnumMember(Value = "Custom")]
    Custom,

    /// <summary>
    /// Enum Predefined for "Predefined"
    /// </summary>
    [EnumMember(Value = "Predefined")]
    Predefined,

    /// <summary>
    /// Enum Default for "Default"
    /// </summary>
    [EnumMember(Value = "Default")]
    Default
}
