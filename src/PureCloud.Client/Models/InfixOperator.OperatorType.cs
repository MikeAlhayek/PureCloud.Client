using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The logical operation that is applied on the operand against the following operand
/// </summary>
public enum InfixOperatorOperatorTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Or for "Or"
    /// </summary>
    [EnumMember(Value = "Or")]
    Or,

    /// <summary>
    /// Enum And for "And"
    /// </summary>
    [EnumMember(Value = "And")]
    And,

    /// <summary>
    /// Enum Near for "Near"
    /// </summary>
    [EnumMember(Value = "Near")]
    Near
}
