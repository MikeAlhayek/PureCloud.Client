using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyOutcomeEventsNotificationAssociatedValueDataTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Number for "Number"
    /// </summary>
    [EnumMember(Value = "Number")]
    Number,

    /// <summary>
    /// Enum Integer for "Integer"
    /// </summary>
    [EnumMember(Value = "Integer")]
    Integer
}
