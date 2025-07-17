using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum InsightsAgentsGranularityEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Daily for "Daily"
    /// </summary>
    [EnumMember(Value = "Daily")]
    Daily,

    /// <summary>
    /// Enum Weekly for "Weekly"
    /// </summary>
    [EnumMember(Value = "Weekly")]
    Weekly,

    /// <summary>
    /// Enum Monthly for "Monthly"
    /// </summary>
    [EnumMember(Value = "Monthly")]
    Monthly
}
