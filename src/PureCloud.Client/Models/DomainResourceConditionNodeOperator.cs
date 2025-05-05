using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DomainResourceConditionNodeOperator
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Eq for "EQ"
    /// </summary>
    [EnumMember(Value = "EQ")]
    Eq,

    /// <summary>
    /// Enum In for "IN"
    /// </summary>
    [EnumMember(Value = "IN")]
    In,

    /// <summary>
    /// Enum Ge for "GE"
    /// </summary>
    [EnumMember(Value = "GE")]
    Ge,

    /// <summary>
    /// Enum Gt for "GT"
    /// </summary>
    [EnumMember(Value = "GT")]
    Gt,

    /// <summary>
    /// Enum Le for "LE"
    /// </summary>
    [EnumMember(Value = "LE")]
    Le,

    /// <summary>
    /// Enum Lt for "LT"
    /// </summary>
    [EnumMember(Value = "LT")]
    Lt
}
