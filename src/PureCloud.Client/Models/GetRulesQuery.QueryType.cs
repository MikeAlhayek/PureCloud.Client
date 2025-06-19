using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of query being performed.
/// </summary>
/// <value>The type of query being performed.</value>

public enum GetRulesQueryQueryTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Info for "Info"
    /// </summary>
    [EnumMember(Value = "Info")]
    Info,

    /// <summary>
    /// Enum Count for "Count"
    /// </summary>
    [EnumMember(Value = "Count")]
    Count
}
