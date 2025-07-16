using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array
/// </summary>
/// <value>Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array</value>

public enum EnrichFieldRulesDefaultArrayActionEnum
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
