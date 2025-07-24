using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RecordingTemplateButtonTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Quickreply for "QuickReply"
    /// </summary>
    [EnumMember(Value = "QuickReply")]
    Quickreply,

    /// <summary>
    /// Enum Phonenumber for "PhoneNumber"
    /// </summary>
    [EnumMember(Value = "PhoneNumber")]
    Phonenumber,

    /// <summary>
    /// Enum Url for "Url"
    /// </summary>
    [EnumMember(Value = "Url")]
    Url
}
