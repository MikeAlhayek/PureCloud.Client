using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2MobiusAlertsTopicConditionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum And for "And"
    /// </summary>
    [EnumMember(Value = "And")]
    And,

    /// <summary>
    /// Enum Or for "Or"
    /// </summary>
    [EnumMember(Value = "Or")]
    Or,

    /// <summary>
    /// Enum Not for "Not"
    /// </summary>
    [EnumMember(Value = "Not")]
    Not,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
