using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum OperandPositionStartingPositionDirectionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Fromstart for "FromStart"
    /// </summary>
    [EnumMember(Value = "FromStart")]
    Fromstart,

    /// <summary>
    /// Enum Fromend for "FromEnd"
    /// </summary>
    [EnumMember(Value = "FromEnd")]
    Fromend
}
