using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The behavior for how to combine items in array field from the request body and the database.
/// </summary>
/// <value>The behavior for how to combine items in array field from the request body and the database.</value>

public enum EnrichFieldRuleArrayActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Replace for "Replace"
    /// </summary>
    [EnumMember(Value = "Replace")]
    Replace,

    /// <summary>
    /// Enum Extend for "Extend"
    /// </summary>
    [EnumMember(Value = "Extend")]
    Extend,

    /// <summary>
    /// Enum Fill for "Fill"
    /// </summary>
    [EnumMember(Value = "Fill")]
    Fill
}
