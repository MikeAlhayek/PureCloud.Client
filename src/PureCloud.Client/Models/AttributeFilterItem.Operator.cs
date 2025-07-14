using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AttributeFilterItemOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum In for "IN"
    /// </summary>
    [EnumMember(Value = "IN")]
    In,

    /// <summary>
    /// Enum Range for "RANGE"
    /// </summary>
    [EnumMember(Value = "RANGE")]
    Range,

    /// <summary>
    /// Enum Equals for "EQUALS"
    /// </summary>
    [EnumMember(Value = "EQUALS")]
    Equals,

    /// <summary>
    /// Enum Notequals for "NOTEQUALS"
    /// </summary>
    [EnumMember(Value = "NOTEQUALS")]
    Notequals,

    /// <summary>
    /// Enum Lessthan for "LESSTHAN"
    /// </summary>
    [EnumMember(Value = "LESSTHAN")]
    Lessthan,

    /// <summary>
    /// Enum Lessthanequals for "LESSTHANEQUALS"
    /// </summary>
    [EnumMember(Value = "LESSTHANEQUALS")]
    Lessthanequals,

    /// <summary>
    /// Enum Greaterthan for "GREATERTHAN"
    /// </summary>
    [EnumMember(Value = "GREATERTHAN")]
    Greaterthan,

    /// <summary>
    /// Enum Greaterthanequals for "GREATERTHANEQUALS"
    /// </summary>
    [EnumMember(Value = "GREATERTHANEQUALS")]
    Greaterthanequals,

    /// <summary>
    /// Enum Contains for "CONTAINS"
    /// </summary>
    [EnumMember(Value = "CONTAINS")]
    Contains
}
