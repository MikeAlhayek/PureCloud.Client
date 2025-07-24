using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The Operand type of the category
/// </summary>
/// <value>The Operand type of the category</value>
public enum OperandType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Term for "Term"
    /// </summary>
    [EnumMember(Value = "Term")]
    Term,

    /// <summary>
    /// Enum Topic for "Topic"
    /// </summary>
    [EnumMember(Value = "Topic")]
    Topic,

    /// <summary>
    /// Enum Operandgroup for "OperandGroup"
    /// </summary>
    [EnumMember(Value = "OperandGroup")]
    Operandgroup
}