using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2WemEngagementCelebrationUpdatesTopicContestCompleteDataAnonymizationEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum NoAnonymization for "NO_ANONYMIZATION"
    /// </summary>
    [EnumMember(Value = "NO_ANONYMIZATION")]
    NoAnonymization,

    /// <summary>
    /// Enum All for "ALL"
    /// </summary>
    [EnumMember(Value = "ALL")]
    All,

    /// <summary>
    /// Enum AllExceptTop for "ALL_EXCEPT_TOP"
    /// </summary>
    [EnumMember(Value = "ALL_EXCEPT_TOP")]
    AllExceptTop
}
