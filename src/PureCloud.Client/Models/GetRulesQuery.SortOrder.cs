using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The order in which response will be sorted.  The accepted choices are Asc and Desc
/// </summary>
/// <value>The order in which response will be sorted.  The accepted choices are Asc and Desc</value>

public enum GetRulesQuerySortOrderEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Asc for "Asc"
    /// </summary>
    [EnumMember(Value = "Asc")]
    Asc,

    /// <summary>
    /// Enum Desc for "Desc"
    /// </summary>
    [EnumMember(Value = "Desc")]
    Desc
}
