using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ObjectiveZoneDirectionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Up for "Up"
    /// </summary>
    [EnumMember(Value = "Up")]
    Up,

    /// <summary>
    /// Enum Down for "Down"
    /// </summary>
    [EnumMember(Value = "Down")]
    Down,

    /// <summary>
    /// Enum Flat for "Flat"
    /// </summary>
    [EnumMember(Value = "Flat")]
    Flat
}
