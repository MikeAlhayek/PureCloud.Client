using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The operator used to check on the criteria id.
/// </summary>
/// <value>The operator used to check on the criteria id.</value>

public enum CriteriaItemOperatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Eq for "eq"
    /// </summary>
    [EnumMember(Value = "eq")]
    Eq,

    /// <summary>
    /// Enum Gt for "gt"
    /// </summary>
    [EnumMember(Value = "gt")]
    Gt,

    /// <summary>
    /// Enum Gte for "gte"
    /// </summary>
    [EnumMember(Value = "gte")]
    Gte,

    /// <summary>
    /// Enum Lt for "lt"
    /// </summary>
    [EnumMember(Value = "lt")]
    Lt,

    /// <summary>
    /// Enum Lte for "lte"
    /// </summary>
    [EnumMember(Value = "lte")]
    Lte,

    /// <summary>
    /// Enum Not for "not"
    /// </summary>
    [EnumMember(Value = "not")]
    Not,

    /// <summary>
    /// Enum Begins for "begins"
    /// </summary>
    [EnumMember(Value = "begins")]
    Begins,

    /// <summary>
    /// Enum NotNull for "not_null"
    /// </summary>
    [EnumMember(Value = "not_null")]
    NotNull
}
