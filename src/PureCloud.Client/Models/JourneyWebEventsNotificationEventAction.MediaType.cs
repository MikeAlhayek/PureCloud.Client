using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyWebEventsNotificationEventActionMediaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Webchat for "webchat"
    /// </summary>
    [EnumMember(Value = "webchat")]
    Webchat,

    /// <summary>
    /// Enum Webmessagingoffer for "webMessagingOffer"
    /// </summary>
    [EnumMember(Value = "webMessagingOffer")]
    Webmessagingoffer,

    /// <summary>
    /// Enum Contentoffer for "contentOffer"
    /// </summary>
    [EnumMember(Value = "contentOffer")]
    Contentoffer,

    /// <summary>
    /// Enum Architectflow for "architectFlow"
    /// </summary>
    [EnumMember(Value = "architectFlow")]
    Architectflow
}
