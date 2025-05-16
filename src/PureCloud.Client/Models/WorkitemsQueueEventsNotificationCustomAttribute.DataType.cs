using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WorkitemsQueueEventsNotificationCustomAttributeDataTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum String for "string"
    /// </summary>
    [EnumMember(Value = "string")]
    String,

    /// <summary>
    /// Enum Number for "number"
    /// </summary>
    [EnumMember(Value = "number")]
    Number,

    /// <summary>
    /// Enum Boolean for "boolean$"
    /// </summary>
    [EnumMember(Value = "boolean$")]
    Boolean,

    /// <summary>
    /// Enum Integer for "integer"
    /// </summary>
    [EnumMember(Value = "integer")]
    Integer
}
