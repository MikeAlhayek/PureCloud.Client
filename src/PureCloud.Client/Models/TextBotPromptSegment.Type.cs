using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TextBotPromptSegmentTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Text for "Text"
    /// </summary>
    [EnumMember(Value = "Text")]
    Text,

    /// <summary>
    /// Enum Richmedia for "RichMedia"
    /// </summary>
    [EnumMember(Value = "RichMedia")]
    Richmedia,

    /// <summary>
    /// Enum Messageevent for "MessageEvent"
    /// </summary>
    [EnumMember(Value = "MessageEvent")]
    Messageevent
}
