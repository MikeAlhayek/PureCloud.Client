using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyWebEventsNotificationCustomEventAttributeDataTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum String for "STRING"
    /// </summary>
    [EnumMember(Value = "STRING")]
    String,

    /// <summary>
    /// Enum Boolean for "BOOLEAN"
    /// </summary>
    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    /// <summary>
    /// Enum Number for "NUMBER"
    /// </summary>
    [EnumMember(Value = "NUMBER")]
    Number
}
