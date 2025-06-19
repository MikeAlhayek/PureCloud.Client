using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.
/// </summary>
/// <value>Specifies how strict the name search needs to be. Expected values are Exact and Contains if querying by name.</value>

public enum GetRulesQueryNameSearchTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Exact for "Exact"
    /// </summary>
    [EnumMember(Value = "Exact")]
    Exact,

    /// <summary>
    /// Enum Contains for "Contains"
    /// </summary>
    [EnumMember(Value = "Contains")]
    Contains,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
