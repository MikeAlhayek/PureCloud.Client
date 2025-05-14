using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerContactlistfilterConfigChangeFilterPredicateColumnTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Numeric for "numeric"
    /// </summary>
    [EnumMember(Value = "numeric")]
    Numeric,

    /// <summary>
    /// Enum Alphabetic for "alphabetic"
    /// </summary>
    [EnumMember(Value = "alphabetic")]
    Alphabetic
}
