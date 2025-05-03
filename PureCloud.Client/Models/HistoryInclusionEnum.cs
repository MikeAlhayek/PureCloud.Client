using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum HistoryInclusionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Include for "Include"
    /// </summary>
    [EnumMember(Value = "Include")]
    Include,

    /// <summary>
    /// Enum Exclude for "Exclude"
    /// </summary>
    [EnumMember(Value = "Exclude")]
    Exclude,

    /// <summary>
    /// Enum Optional for "Optional"
    /// </summary>
    [EnumMember(Value = "Optional")]
    Optional
}
