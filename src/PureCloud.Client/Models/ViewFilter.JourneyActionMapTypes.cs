using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets JourneyActionMapTypes
/// </summary>

public enum ViewFilterJourneyActionMapTypesEnum
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
    /// Enum Integrationaction for "integrationAction"
    /// </summary>
    [EnumMember(Value = "integrationAction")]
    Integrationaction,

    /// <summary>
    /// Enum Architectflow for "architectFlow"
    /// </summary>
    [EnumMember(Value = "architectFlow")]
    Architectflow,

    /// <summary>
    /// Enum Openaction for "openAction"
    /// </summary>
    [EnumMember(Value = "openAction")]
    Openaction
}
