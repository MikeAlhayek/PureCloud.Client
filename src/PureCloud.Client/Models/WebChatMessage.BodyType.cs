using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WebChatMessageBodyTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Standard for "standard"
    /// </summary>
    [EnumMember(Value = "standard")]
    Standard,

    /// <summary>
    /// Enum Notice for "notice"
    /// </summary>
    [EnumMember(Value = "notice")]
    Notice,

    /// <summary>
    /// Enum Memberjoin for "member-join"
    /// </summary>
    [EnumMember(Value = "member-join")]
    Memberjoin,

    /// <summary>
    /// Enum Memberleave for "member-leave"
    /// </summary>
    [EnumMember(Value = "member-leave")]
    Memberleave,

    /// <summary>
    /// Enum Mediarequest for "media-request"
    /// </summary>
    [EnumMember(Value = "media-request")]
    Mediarequest
}
